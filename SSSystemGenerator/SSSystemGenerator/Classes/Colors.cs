using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Colors
    {

        public static Color DARK_MODE_FORM_BG = Color.FromArgb(255, 43, 42, 51);
        public static Color DARK_MODE_FORM_FG = Color.FromArgb(255, 251, 251, 254);

        public static Color DARK_MODE_BG = Color.FromArgb(255, 28, 27, 34);
        public static Color DARK_MODE_FG = Color.FromArgb(255, 251, 251, 254);
        public static Color DARK_MODE_BORDER = Color.FromArgb(255, 43, 42, 51);

        public static Bitmap DARK_MODE_REFRESH_IMAGE_PATH = Properties.Resources.UndoDarkMode;


        [ObsoleteAttribute]
        public static Color DARK_MODE_HOVER_COLOR = Color.FromArgb(255, 75, 75, 84);//from firefox dark mode ui



        public static Color LIGHT_MODE_FORM_BG = SystemColors.Control;
        public static Color LIGHT_MODE_FORM_FG = SystemColors.ControlText;

        public static Color LIGHT_MODE_BG = SystemColors.Window;
        public static Color LIGHT_MODE_FG = SystemColors.WindowText;
        public static Color LIGHT_MODE_BORDER = SystemColors.ActiveBorder;

        public static Bitmap LIGHT_MODE_REFRESH_IMAGE_PATH = Properties.Resources.UndoLightMode;


        [ObsoleteAttribute]
        public static Color LIGHT_MODE_HOVER_COLOR = Color.FromArgb(255, 255, 255, 255);

    }
}
