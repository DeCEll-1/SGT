using System.Drawing;

namespace SSSystemGenerator.Render
{
    public class Lines
    {

        public Lines()
        {
        }

        public Lines(PointF from, PointF to, float Thickness, Color Color)
        {
            this.from = from;
            this.to = to;
            this.Thickness = Thickness;
            this.Color = Color;
        }

        public PointF from { get; }
        public PointF to { get; }
        public float Thickness { get; }
        public Color Color { get; }
    }
}