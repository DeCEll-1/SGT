using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Classes
{
    public class ColorManager
    {
        public static void ChangeColorMode(Control.ControlCollection container)
        {
            UpdateComponentColors(container.Owner);

            foreach (Control component in container)
            {
                //if (!component.Enabled) continue;

                DrawBorderToComplonent(component);

                //HoverColorEventSetup(component);

                UpdateComponentColors(component);

                if (component is MenuStrip)
                {
                    ChangeColorMode((component as MenuStrip).Items);
                }

                if (component.Controls.Count != 0)
                {
                    ChangeColorMode(component.Controls);

                    continue;
                }
            }
        }
        private static void UpdateComponentColors(Control component)
        {
            ////https://stackoverflow.com/a/19315175 // remove it before adding so you dont add it multiple times
            //component.EnabledChanged -= EnabledColorUpdateEvent;
            //component.EnabledChanged += EnabledColorUpdateEvent;//except it doesnt work

            if (component is Button && !component.Enabled)
            {
                if (Settings.ColorMode == ColorMode.DARK)//Dark mode
                {
                    return;
                }

            }

            //if (!component.Enabled)
            //{//https://stackoverflow.com/a/46100278
            //    wasDisabled = true;
            //    component.Enabled = true;
            //}

            if (
                component.Name.Contains("Refresh") || component.Name.Contains("Undo")
                )
            {
                component.BackgroundImage = RefreshButton();
            }
            if (component.Name.Contains("Clone"))
            {
                component.BackgroundImage = CloneButton();
            }
            if (component.Name.Contains("ImagePick"))
            {
                component.BackgroundImage = ImageSelect();
            }

            //component.EnabledChanged -= EnabledColorUpdateEvent;
            //component.EnabledChanged += EnabledColorUpdateEvent;

            //if (!component.Enabled) return;


            foreach (var borderlessControl in borderlessControls)
            {
                if (component.GetType() == borderlessControl.GetType() || component.GetType().GetInterface("IFormInterface") != null)
                {
                    component.BackColor = FormBackground();
                    component.ForeColor = FormText();

                    //if (wasDisabled) component.Enabled = false;
                    return;
                }
            }

            component.BackColor = Background();
            component.ForeColor = Text();

            //if (wasDisabled) component.Enabled = false;

        }
        private static void EnabledColorUpdateEvent(object sender, System.EventArgs eventArgs)
        {
            Control senderControl = (Control)sender;
            UpdateComponentColors(senderControl);

            DrawBorderToComplonent(senderControl);
        }

        #region Border
        private static void DrawBorderToComplonent(Control component)
        {
            component.Paint += Component_Paint;

            component.Refresh();

            component.Paint -= Component_Paint;
        }
        private static void Component_Paint(object sender, PaintEventArgs e)
        {//https://stackoverflow.com/a/59478243

            foreach (var borderlessControl in borderlessControls)
            {
                if (sender.GetType() == borderlessControl.GetType())
                {
                    return;
                }
            }

            int borderWidth = 6;
            ButtonBorderStyle borderStyle = ButtonBorderStyle.Solid;
            if (Settings.ColorMode == ColorMode.LIGHT)//light mode
            {
                e.Graphics.Clear(Colors.LIGHT_MODE_BG);
                var borderColor = Colors.LIGHT_MODE_BORDER;
                //https://stackoverflow.com/questions/2200974/controlpaint-drawborder-but-thicker

                ControlPaint.DrawBorder(
                                    e.Graphics,
                                    e.ClipRectangle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle
                                    );
            }
            else//dark mode
            {
                e.Graphics.Clear(Colors.DARK_MODE_BG);
                var borderColor = Colors.DARK_MODE_BORDER;



                ControlPaint.DrawBorder(
                                    e.Graphics,
                                    e.ClipRectangle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle
                                    );
            }

        }
        #endregion
        #region ToolStrip
        private static void ChangeColorMode(ToolStripItemCollection TSICollection)
        {
            foreach (ToolStripItem TSI in TSICollection)
            {
                UpdateToolStripColors(TSI);
                if (TSI is ToolStripMenuItem)
                {
                    //HoverColorEventSetup(TSI);
                    ChangeColorMode((TSI as ToolStripMenuItem).DropDownItems);
                }
            }
        }
        private static void UpdateToolStripColors(ToolStripItem toolStripItem)
        {
            if (!toolStripItem.Enabled) return;
            toolStripItem.BackColor = FormBackground();
            toolStripItem.ForeColor = FormText();
        }
        #endregion
        #region returnColors
        public static Color Text()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_FG;
            else
                return Colors.DARK_MODE_FG;
        }
        public static Color Background()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_BG;
            else
                return Colors.DARK_MODE_BG;
        }
        public static Color FormText()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                                                      //{ return Colors.LIGHT_MODE_FORM_FG; }
                return Form.DefaultForeColor;
            else
                return Colors.DARK_MODE_FORM_FG;
        }
        public static Color FormBackground()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                                                      //{ return Colors.LIGHT_MODE_FORM_BG; }
                return Form.DefaultBackColor;
            else
                return Colors.DARK_MODE_FORM_BG;
        }
        public static Color Border()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_BORDER;
            else
                return Colors.DARK_MODE_BORDER;
        }
        public static Bitmap RefreshButton()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_REFRESH_IMAGE;
            else
                return Colors.DARK_MODE_REFRESH_IMAGE;
        }
        public static Bitmap CloneButton()//make those generalised
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_CLONE_IMAGE;
            else
                return Colors.DARK_MODE_CLONE_IMAGE;
        }
        public static Bitmap ImageSelect()//make those generalised
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_IMAGE_SELECTION;
            else
                return Colors.DARK_MODE_IMAGE_SELECTION;
        }

        public static Bitmap CloseButton()//make those generalised
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_IMAGE_CLOSE;
            else
                return Colors.DARK_MODE_IMAGE_CLOSE;
        }

        public static Bitmap LastSizeButton()//make those generalised
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_IMAGE_RESIZE;
            else
                return Colors.DARK_MODE_IMAGE_RESIZE;
        }

        public static Bitmap MinimizeButton()//make those generalised
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
                return Colors.LIGHT_MODE_IMAGE_MINIMIZE;
            else
                return Colors.DARK_MODE_IMAGE_MINIMIZE;
        }

        [Obsolete]
        public static Color Hover()
        {
            if (Settings.ColorMode == ColorMode.LIGHT)//lightMode
            { return Colors.LIGHT_MODE_HOVER_COLOR; }
            else
            { return Colors.DARK_MODE_HOVER_COLOR; }
        }

        #endregion
        #region borderlessControls // also stuff that takes form background

        private static List<Control> borderlessControls = new List<Control>()
        {
            new Label(),
            new Button(),
            new GroupBox(),
            new Panel(),
            new Form(),
        };

        #endregion


    }
}
