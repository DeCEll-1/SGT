using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Render
{
    public class PanelRenderer
    {

        #region variables

        private Panel Panel { get; set; }

        private int Height { get; set; }

        private int Width { get; set; }

        private Point Center { get; set; }

        #region locations

        private Point topLeft { get; set; }
        private Point topRight { get; set; }
        private Point bottomLeft { get; set; }
        private Point bottomRight { get; set; }

        #endregion

        public Color BackgroundColor { get; set; } = Color.White;

        private PaintEventArgs PaintEventArgs { get; set; }

        public RendererBaseClass rendererValues { get; set; } = new RendererBaseClass();

        #endregion

        public PanelRenderer(Panel panel, PaintEventArgs paintEventArgs)
        {
            panel.Paint += new PaintEventHandler(Render);

            this.Panel = panel;
            this.Height = panel.Height;
            this.Width = panel.Width;

            this.Center = new Point(Width / 2, Height / 2);

            this.PaintEventArgs = paintEventArgs;


            topLeft = new Point(0, Height);
            topRight = new Point(Width, Height);
            bottomLeft = new Point(0, 0);
            bottomRight = new Point(Width, 0);


        }

        public void Render() { Render(Panel, PaintEventArgs); }


        public void Render(object sender, PaintEventArgs e)
        {

            using (Graphics g = e.Graphics)
            {
                try
                {
                    g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    //g values crashes with System.ArgumentException for god knows why
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                }
                catch (Exception ex)
                {
                    return;
                }

                Panel.BackColor = BackgroundColor;


                foreach (Lines line in rendererValues.Lines)
                {
                    Pen pen = new Pen(line.Color, line.Thickness);


                    g.DrawLine(pen,line.from,line.to);

                }

                foreach (Circles circle in rendererValues.Circles)
                {
                    Pen pen = new Pen(circle.BorderColor, circle.BorderThickness);

                    SolidBrush brush = new SolidBrush(
                        circle.InteriorColor
                        );

                    //https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectanglef.-ctor?view=net-8.0
                    RectangleF circleRect = new RectangleF(
                        circle.topLeft.X,                       //The x-coordinate of the upper-left corner of the rectangle.
                        circle.topLeft.Y,                       //The y-coordinate of the upper-left corner of the rectangle.
                        Convert.ToInt32(circle.Radius * 2),     //The width of the rectangle.
                        Convert.ToInt32(circle.Radius * 2)      //The height of the rectangle.
                        );

                    if (circle.Filled)
                    {
                        g.FillEllipse(brush, circleRect);//draw a filled circle
                    }

                    g.DrawEllipse(pen, circleRect);//draw the outline regardless if its filled or not

                    if (Statics.debugMode)
                    {
                        pen.Color = Color.Green;

                        g.DrawRectangles(pen, new RectangleF[] { circleRect });
                    }


                }

            }

        }

        public Point GetCenter()
        {
            return Center;
        }

        public int GetHeight() { return Height; }

        public int GetWidth() { return Width; }

    }
}
