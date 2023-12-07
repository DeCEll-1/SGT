using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyLoad();


        }

        private void MyLoad()
        {
            lbl_EXEPath.Text = "EXEPath: " + Statics.EXEPath;
            lbl_JSONPath.Text = "JSONPath: " + Statics.JSONPath;

            fileHelper.SetupFiles();


        }

        private void tb_Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyChar == '\u0017')
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void KeyCheckColor(object sender, KeyPressEventArgs e)
        {

            try
            {


                if (Convert.ToInt32((sender as TextBox).Text + e.KeyChar.ToString()) > 255)
                {
                    e.Handled = true;

                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar == '.'))
                    {
                        e.Handled = true;

                    }
                    pnl_Color.BackColor = Color.FromArgb(Convert.ToInt32(tb_A.Text),//updates the panel
                                                        Convert.ToInt32(tb_R.Text),
                                                        Convert.ToInt32(tb_G.Text),
                                                        Convert.ToInt32(tb_B.Text));
                }



            }
            catch { }
        }
    }
}
