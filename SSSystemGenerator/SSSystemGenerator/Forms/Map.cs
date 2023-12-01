using SSSystemGenerator.Classes;
using SSSystemGenerator.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class Map : Form
    {
        public float zoomValue { get; set; } = 0f;

        public PointF renderCenter { get; set; } = new PointF(0f, 0f);

        #region to remove flicker ///// https://stackoverflow.com/questions/4690426/why-do-my-winforms-controls-flicker-and-resize-slowly
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
            RefreshPanel();
        }
        #endregion

        public VeBlib_StarSystemData selectedSystem { get; set; } = new VeBlib_StarSystemData();

        public PanelRenderer PanelDrawer { get; set; } = null;

        #region mouse

        private void pnl_Map_MouseWheel(object sender, MouseEventArgs e)
        {//https://stackoverflow.com/questions/45325726/move-shapes-on-a-panel-by-mouse
            zoomValue += (e.Delta / 100f) * 0.3f;

            try
            {
                //TrackBar_Zoom.Value = (int)(zoomValue * 100f);
            }//"value must be in min-max uwu :3"
            catch (Exception ex)
            {
            }

            if (zoomValue < -1f || zoomValue == -1f)
            {
                zoomValue = -0.99f;
                RefreshPanel();
                return;
            }



            #region i hate zooming
            //get current center
            //get location
            //subtract location/2 to center when zooming 2x

            //if (e.Delta > 0)
            //{
            //    //renderCenter = Helper.SubtractCoordinates(renderCenter, new PointF(e.X / (e.Delta / 100f), e.Y / (e.Delta / 100f)));//hope this works!
            //    renderCenter = Helper.SubtractCoordinates(renderCenter, new PointF(pnl_Map.Width * ((e.Delta / 100f) - 1), pnl_Map.Height * ((e.Delta / 100f) - 1)));//hope this works!
            //}
            //else
            //{
            //    renderCenter = Helper.CombineCoordinates(renderCenter, new PointF(e.X, e.Y));//hope this works!
            //}

            PanelDrawer.rendererValues.mouseEventArgs = e;

            PanelDrawer.rendererValues.zooming = true;

            //renderCenter = new PointF(-(e.X * (zoomValue)), -(e.Y * (zoomValue))); 
            #endregion

            RefreshPanel();
        }

        public bool moveEnabled { get; set; }

        public PointF startLocation { get; set; } = new PointF(0, 0);
        public PointF endLocation { get; set; } = new PointF(0, 0);

        private void pnl_Map_MouseDown(object sender, MouseEventArgs e)
        {
            startLocation = new PointF(e.X, e.Y);

            moveEnabled = true;




            //pnl_Map.MouseMove += Pnl_Map_MouseMove;
            pnl_Map.MouseUp += Pnl_Map_MouseUp;
        }

        //private void Pnl_Map_MouseMove(object sender, EventArgs e)
        //{//change center point
        // //get current coordinates
        // //get the last coordinates
        // //subtract bla bla
        // //change center
        // //re render

        //    if (!moveEnabled) return;

        //    MouseEventArgs mouseEventArgs = (e as MouseEventArgs);

        //    PointF mouseCoordinates = new PointF(mouseEventArgs.X, mouseEventArgs.Y);

        //    center = Helper.SubtractCoordinates(center, mouseCoordinates);//hope this works!

        //    RefreshPanel();
        //}

        private void Pnl_Map_MouseUp(object sender, MouseEventArgs e)
        {
            //pnl_Map.MouseHover -= Pnl_Map_MouseMove;
            pnl_Map.MouseUp -= Pnl_Map_MouseUp;

            endLocation = new PointF(e.X, e.Y);

            renderCenter = Helper.CombineCoordinates(renderCenter, Helper.SubtractCoordinates(endLocation, startLocation));//hope this works!

            //center = endLocation;

            RefreshPanel();

            //get current center
            //

        }

        #endregion

        public Map()
        {
            InitializeComponent();

            this.MouseWheel += new MouseEventHandler(pnl_Map_MouseWheel);
            this.MouseMove += new MouseEventHandler(pnl_Map_MouseWheel);

            Statics.Map = this;

            Load();
        }

        private void Load()
        {
            LoadSystems();
        }

        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        private void LoadSystems()
        {
            ComboBox_Systems.Items.Clear();
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.baseClass.StarSystemDataList.ToArray())).ToArray());

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Systems.SelectedIndex = 0;
            }

        }

        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSystem = Helper.GetSystemFromID((sender as ComboBox).SelectedItem.ToString());

            RefreshPanel();
        }

        public void RefreshPanel()
        {
            if (PanelDrawer == null) return;

            PanelDrawer.rendererValues.Circles = new List<Circles>();

            AddValuesToRenderer();

            pnl_Map.Refresh();
        }

        private void AddValuesToRenderer()
        {

            lbl_PanelInfo.Text = "Panel Values:\nHeight: " + pnl_Map.Height + "\nWidth: " + pnl_Map.Width + "\nZoom Value: " + zoomValue + "\nCenter: " + renderCenter.X + " , " + renderCenter.Y;

            lbl_PanelInfo.BackColor = Color.White;
            lbl_PanelInfo.ForeColor = Color.Black;

            List<Extend> orbitables = Helper.GetOrbitablesInSystem(selectedSystem.ID);

            List<Circles> circles = new List<Circles>();

            List<Lines> lines = new List<Lines>();

            if (orbitables == null) return;

            if (orbitables.Count == 0) return;

            //i need to make a grid
            //map is 26k x 26k
            //form is 1k x 1k
            //1 form pixel is 26 game pixel
            //a grid size is 1k in game
            //1k / 26 will give us one grid size in form
            //run that 26 times

            int z = 0;

            float lineThickness = 2f;

            for (float i = 0; z < 27; i += 1000f / 26f)
            {
                z++;
                lines.Add(
                    new Lines(
                            new PointF(i, 0),
                            new PointF(i, pnl_Map.Height),
                            lineThickness,
                            Finals.MAP_GRID_LINE_COLOR
                        )
                    );

                lines.Add(
                    new Lines(
                            new PointF(0, i),
                            new PointF(pnl_Map.Width, i),
                            lineThickness,
                            Finals.MAP_GRID_LINE_COLOR
                        )
                    );

            }



            PanelDrawer.rendererValues.Lines.Clear();

            PanelDrawer.rendererValues.Lines.AddRange(lines);

            foreach (Extend extend in orbitables)
            {

                //26 grids on x
                //26 grids on y
                //one grid should be 1k


                Extend adjustedExtend = Helper.SSCoordinatesToPanelCoordinates(extend, 26000 / pnl_Map.Height);


                bool filled = true;



                if (extend.WhatIsThis == Finals.RING_BAND || extend.WhatIsThis == Finals.ASTREOID_BELT)
                {
                    filled = false;
                }


                if (extend.orbitLocationMode == 0)//location is determined by coordinate
                {
                    PointF center = new PointF(
                    adjustedExtend.x + pnl_Map.Width / 2,
                    adjustedExtend.y + pnl_Map.Height / 2
                    );

                    Circles extendCircle = new Circles(
                        center,
                        (int)adjustedExtend.radius,
                        Finals.MAP_ORBITABLE_BORDER_COLOR,
                        (int)(Convert.ToByte(adjustedExtend.width != 0 && adjustedExtend.bandWidthInEngine == 0) * adjustedExtend.width +//if astreoid belts width is not 0 and ring belts width is 0 then multiply 1 by the width (true false gives true or false which can be 0 or 1 then we multiply it with the value we want, for more information search programming rule 34 branchless programming)
                        Convert.ToByte(adjustedExtend.width == 0 && adjustedExtend.bandWidthInEngine != 0) * adjustedExtend.bandWidthInEngine +//ring band width value
                        Convert.ToByte(adjustedExtend.width == 0 && adjustedExtend.bandWidthInEngine == 0) * 3) //default width which is 5
                        ,
                        Finals.MAP_ORBITABLE_FILL_COLOR,
                        filled
                        );

                    circles.Add(extendCircle);
                    continue;
                }
                else//its an orbit
                {
                    Extend focusExtend = Helper.GetOrbitableFromID(extend.focusID);

                    PointF focusPoint = Helper.GetLocationOfFocus(focusExtend);

                    focusPoint = Helper.SSPointToPanelPoint(focusPoint, 26000 / pnl_Map.Height);

                    #region ring for showing that this circle orbits another one

                    PointF centerForOrbitRing = new PointF(
                          focusPoint.X + pnl_Map.Width / 2,
                          focusPoint.Y + pnl_Map.Height / 2
                       );


                    Circles circleForOrbit = new Circles(
                        centerForOrbitRing,
                        (int)adjustedExtend.orbitRadius,
                        Finals.MAP_ORBITABLE_BORDER_COLOR,
                        1,
                        Finals.MAP_ORBITABLE_FILL_COLOR,
                        false
                        );

                    circles.Add(circleForOrbit);

                    #endregion

                    #region actual circle

                    PointF center = Helper.GetPointOnCircumference(
                       new PointF(
                           focusPoint.X + pnl_Map.Width / 2,
                           focusPoint.Y + pnl_Map.Height / 2
                        ),
                        extend.angle,
                        adjustedExtend.orbitRadius
                    );

                    Circles extendCircle = new Circles(
                                    center,
                                    (int)adjustedExtend.radius,
                                    Finals.MAP_ORBITABLE_BORDER_COLOR,
                                    (int)(Convert.ToByte(adjustedExtend.width != 0 && adjustedExtend.bandWidthInEngine == 0) * adjustedExtend.width +//if astreoid belts width is not 0 and ring belts width is 0 then multiply 1 by the width (true false gives true or false which can be 0 or 1 then we multiply it with the value we want, for more information search programming rule 34 branchless programming)
                                    Convert.ToByte(adjustedExtend.width == 0 && adjustedExtend.bandWidthInEngine != 0) * adjustedExtend.bandWidthInEngine +//ring band width value
                                    Convert.ToByte(adjustedExtend.width == 0 && adjustedExtend.bandWidthInEngine == 0) * 3) //default width which is 5
                                    ,
                                    Finals.MAP_ORBITABLE_FILL_COLOR,
                                    filled
                                    );

                    circles.Add(extendCircle);
                    #endregion





                    continue;
                }

            }

            PanelDrawer.rendererValues.Circles.Clear();

            PanelDrawer.rendererValues.Circles.AddRange(circles);

            PanelDrawer.BackgroundColor = Color.Black;

            PanelDrawer.rendererValues.zoomValue = zoomValue + 1;

            PanelDrawer.rendererValues.center = renderCenter;




        }

        private void pnlMap_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            Panel panel = sender as Panel;


            if (PanelDrawer == null)
            {
                PanelDrawer = new PanelRenderer(panel, e);

                PanelDrawer.rendererValues = new RendererBaseClass();
            }

            if (Statics.debugMode)
            {
                Circles testcircle = new Circles(
                        new Point(panel.Width / 2, panel.Height / 2),
                        50,
                        Color.Red,
                        5,
                        Color.Green,
                        true
                        );

                PanelDrawer.rendererValues.Circles.Add(testcircle);
            }


            //PanelDrawer.Render(sender, e);

        }

        private void TrackBar_Zoom_ValueChanged(object sender, EventArgs e)
        {
            zoomValue = (sender as TrackBar).Value / 100f;
            RefreshPanel();
        }


    }


}