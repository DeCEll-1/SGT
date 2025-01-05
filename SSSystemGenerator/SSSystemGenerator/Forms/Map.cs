using SSSystemGenerator.Classes;
using SSSystemGenerator.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class Map : Form, IFormInterface
    {

        #region Image

        // DONE: fix this so it only outputs 0, 0 > 1024, 1024
        public Bitmap ReturnPanelImage()
        {
            pnl_Map.Width = 1024; pnl_Map.Height = 1024;
            Bitmap image = new Bitmap(1024, 1024);
            pnl_Map.DrawToBitmap(image, new Rectangle(0, 0, 1024, 1024));
            return image;
        }

        #endregion

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

        public StarSystemData selectedSystem { get; set; } = new StarSystemData();

        public PanelRenderer PanelDrawer { get; set; } = null;

        #region mouse


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

        #region zoom

        private void pnl_Map_MouseWheel(object sender, MouseEventArgs e)
        {//https://stackoverflow.com/questions/45325726/move-shapes-on-a-panel-by-mouse
            //zoomValue = e.Delta > 0 ? zoomValue == 0 ? zoomValue = 1 : zoomValue * zoomValue : -(float)Math.Sqrt(zoomValue);
            zoomValue += e.Delta > 0 ? 0.3f : -0.3f;

            try
            {
                //TrackBar_Zoom.Value = (int)(zoomValue * 100f);
            }//"value must be in min-max uwu :3"
            catch (Exception )
            {
            }

            if (zoomValue <= -1f || zoomValue > float.MaxValue)
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

        #region zoomButtons

        private void btn_ResetMapVisuals_Click(object sender, EventArgs e)
        {
            zoomValue = 0f;

            renderCenter = new PointF(0f, 0f);

            RefreshPanel();
        }

        private void btn_Zoom_Click(object sender, EventArgs e)
        {
            zoomValue += 0.3f;

            RefreshPanel();
        }

        private void btn_DeZoom_Click(object sender, EventArgs e)
        {
            zoomValue -= 0.3f;

            RefreshPanel();
        }

        #endregion

        #endregion

        #endregion

        public Map()
        {
            InitializeComponent();
            UpdateColors();

            this.MouseWheel += new MouseEventHandler(pnl_Map_MouseWheel);

            Statics.Map = this;

            Load();

            SuspendLayout();
            ResumeLayout();

            RefreshPanel();

        }

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        private new void Load()
        {
            LoadSystems();
        }

        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        private void LoadSystems()
        {
            ComboBox_Systems.Items.Clear();
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.BaseClass.StarSystemDataList.ToArray())).ToArray());

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

            if (PanelDrawer == null)
            {
                //https://stackoverflow.com/a/60247726
                PanelDrawer = new PanelRenderer(pnl_Map, new PaintEventArgs(pnl_Map.CreateGraphics(), pnl_Map.DisplayRectangle));

                PanelDrawer.rendererValues = new RendererBaseClass();
            }

            PanelDrawer.rendererValues.Circles = new List<Circles>(); // https://stackoverflow.com/a/60247726

            AddValuesToRenderer();

            pnl_Map.Refresh();
        }

        private void AddValuesToRenderer()
        {
            try
            {
                lbl_PanelInfo.Text =
                    "Panel Values:\nHeight: " + pnl_Map.Height +
                    "\nWidth: " + pnl_Map.Width +
                    "\nZoom Value: " + (zoomValue > 0 && zoomValue.ToString().Length > 5 ? zoomValue.ToString().Substring(0, 4) : zoomValue.ToString()) +
                    "\nCenter: " + renderCenter.X + " , " + renderCenter.Y;
            }
            catch (Exception)
            {//getting parameter name lenght System.ArgumentOutOfRangeException from zoom value

            }


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
                            new PointF(i, 1000f),
                            lineThickness,
                            Finals.MAP_GRID_LINE_COLOR
                        )
                    );

                lines.Add(
                    new Lines(
                            new PointF(0, i),
                            new PointF(1000f, i),
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

                Extend adjustedExtend = Helper.SSCoordinatesToPanelCoordinates(extend, 26000 / 1000);

                bool filled = true;

                if (extend.WhatIsThis == Finals.RING_BAND || extend.WhatIsThis == Finals.ASTREOID_BELT)
                {
                    filled = false;
                }

                if (extend.orbitLocationMode == 0)//location is determined by coordinate
                {
                    PointF center = new PointF(
                    adjustedExtend.x + 1000f / 2,
                    adjustedExtend.y + 1000f / 2
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

                    focusPoint = Helper.SSPointToPanelPoint(focusPoint, 26000 / 1000);

                    #region ring for showing that this circle orbits another one

                    PointF centerForOrbitRing = new PointF(
                          focusPoint.X + 1000f / 2,
                          focusPoint.Y + 1000f / 2
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
                           focusPoint.X + 1000f / 2,
                           focusPoint.Y + 1000f / 2
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

            if (SettingsController.DebugMode)
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {//https://stackoverflow.com/a/31464086

            float moveAmount = -100f;//im suppose to change the -s under but thats too much work so ill just - the move amount
            //TODO: dont be lazy

            switch (keyData)
            {
                case Keys.D0://0 key on line
                case Keys.NumPad0://0 key on numpad
                    btn_ResetMapVisuals_Click(null, null);//reset zooms
                    break;
                case Keys.Oemplus://+ key on line 
                case Keys.Add://+ key on numpad
                    btn_Zoom_Click(null, null);//zoom in
                    break;
                case Keys.OemMinus://- key on line
                case Keys.Subtract://- key on numpad
                    btn_DeZoom_Click(null, null);//zoom out
                    break;
                #region move

                case Keys.NumPad1://go down left by 100 (not sqrted)
                    Move(-moveAmount, moveAmount);
                    break;
                case Keys.NumPad2://go down
                case Keys.Down:
                    Move(0f, moveAmount);
                    break;
                case Keys.NumPad3://go down right
                    Move(moveAmount, moveAmount);
                    break;

                case Keys.NumPad4://go left
                case Keys.Left:
                    Move(-moveAmount, 0);
                    break;
                //no 5, cope 
                case Keys.NumPad6://go right 
                case Keys.Right://go right 
                    Move(moveAmount, 0f);
                    break;

                case Keys.NumPad7://go down left by 100 (not sqrted)
                    Move(-moveAmount, -moveAmount);
                    break;
                case Keys.NumPad8://go down
                case Keys.Up:
                    Move(0f, -moveAmount);
                    break;
                case Keys.NumPad9://go down right
                    Move(moveAmount, -moveAmount);
                    break;

                #endregion

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            return true;
        }

        private new void Move(float x, float y)
        {
            renderCenter = Helper.CombineCoordinates(renderCenter, new PointF(x, y));

            RefreshPanel();
        }

        #region FormSize
        private void btn_FormSizeDecrease_Click(object sender, EventArgs e)
        {
            this.Width += this.Width > 100 ? -100 : 0;
            this.Height += this.Height > 100 ? -100 : 0;
        }

        private void btn_FormSizeIncrease_Click(object sender, EventArgs e)
        {
            this.Width += 100;
            this.Height += 100;
        }
        #endregion
    }


}