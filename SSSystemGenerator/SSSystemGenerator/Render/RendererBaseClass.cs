using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Render
{
    public class RendererBaseClass
    {
        public RendererBaseClass() { }

        public List<Circles> Circles = new List<Circles>();

        public List<Lines> Lines = new List<Lines> { };

        public float zoomValue = 1f;

        public PointF center = new PointF(0, 0);

        public bool zooming { get; set; }

        public MouseEventArgs mouseEventArgs { get; set; }

    }
}
