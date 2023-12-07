using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    //g.RenderingOrigin = new Point(-500, -500);
                }
                catch (Exception ex)
                {
                    return;
                }

                Matrix transform = new Matrix();

                try
                {

                    if (rendererValues.zooming && false)
                    {

                        //float zoom = 2f;

                        ////https://stackoverflow.com/questions/27871711/zoom-in-on-a-fixed-point-using-matrices
                        //// first we reverse translate the point
                        //// we need an array!
                        //PointF[] tv = new PointF[] { rendererValues.mouseEventArgs.Location };
                        //viewMatrixRev.TransformPoints(tv);
                        //// after the reversal we can use the coordinates
                        //float xPos = tv[0].X;
                        //float yPos = tv[0].Y;

                        //// revers translation for the point
                        //Matrix scaleMatrixRev = new Matrix(1f / zoom, 0, 0, 1f / zoom, 0, 0);
                        //// the other transformations
                        //Matrix scaleMatrix = new Matrix(zoom, 0, 0, zoom, 0, 0);
                        //Matrix translateOrigin = new Matrix(1, 0, 0, 1, xPos, yPos);
                        //Matrix translateBack = new Matrix(1, 0, 0, 1, -xPos, -yPos);

                        //// we need two different orders, not sure yet why(?)
                        //MatrixOrder moP = MatrixOrder.Prepend;
                        //MatrixOrder moA = MatrixOrder.Append;

                        //// graphics transfomation
                        //viewMatrix.Multiply(translateOrigin, moP);
                        //viewMatrix.Multiply(scaleMatrix, moP);
                        //viewMatrix.Multiply(translateBack, moP);

                        //// store the next point reversal:
                        //viewMatrixRev.Multiply(translateBack, moA);
                        //viewMatrixRev.Multiply(scaleMatrixRev, moA);
                        //viewMatrixRev.Multiply(translateOrigin, moA);

                        //g.Transform = viewMatrix;

                        //https://i.stack.imgur.com/EQp7o.png // i do nut know

                        //Matrix transform = new Matrix();

                        //transform.Translate(-(Width / 2f), -(Height / 2f));//origin is not at the middle of the panel, so set the origion to the middle of the panel

                        //transform.Translate();



                        //Matrix transform = new Matrix();

                        ////if (false)
                        //{//https://stackoverflow.com/questions/44566229/how-to-zoom-at-a-point-in-picturebox-in-c
                        //    Point location = rendererValues.mouseEventArgs.Location;


                        transform.Translate(rendererValues.mouseEventArgs.Location.X, rendererValues.mouseEventArgs.Location.Y, MatrixOrder.Append);

                        transform.Scale(rendererValues.zoomValue, rendererValues.zoomValue, MatrixOrder.Append);

                        transform.Translate(-rendererValues.mouseEventArgs.Location.X, -rendererValues.mouseEventArgs.Location.Y, MatrixOrder.Append);

                        g.Transform = transform.Clone();

                        rendererValues.center.X = g.Transform.OffsetX;
                        rendererValues.center.Y = g.Transform.OffsetY;

                        rendererValues.zooming = false;

                        Helper.GetMap().renderCenter = rendererValues.center;


                    }
                    else
                    {
                        transform.Translate(rendererValues.center.X, rendererValues.center.Y);

                        transform.Scale(rendererValues.zoomValue, rendererValues.zoomValue);
                        //oh wow when its 0 it gives argument exception beacuse its dumb enough to not check if it can / things by 0 wonderfull
                        //or something like that

                        g.Transform = transform.Clone();

                    }

                    //g.Transform = transform;



                }
                catch (Exception ex)
                {
                }

                //Panel.Scale(new SizeF(rendererValues.zoomValue, rendererValues.zoomValue));

                g.Clear(BackgroundColor);

                foreach (Lines line in rendererValues.Lines)
                {
                    Pen pen = new Pen(line.Color, line.Thickness);


                    g.DrawLine(pen, line.from, line.to);

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
