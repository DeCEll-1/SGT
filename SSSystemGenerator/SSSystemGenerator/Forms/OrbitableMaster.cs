using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class OrbitableMaster : Form, IFormInterface
    { // holy SHİT THİS İS SO CLEAN AWWWW :3
        public string context { get; set; } = "";
        public OrbitableMaster()
        {
            InitializeComponent();
            UpdateColors();

            nud_MinSpin.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_MaxSpin.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_X.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_Y.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_Angle.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_OrbitRadius.ValueChanged += TextChangedBTNAddUpdateCheck;
            nud_OrbitDays.ValueChanged += TextChangedBTNAddUpdateCheck;
            tb_ID.TextChanged += TextChangedBTNAddUpdateCheck;
            tb_Name.TextChanged += TextChangedBTNAddUpdateCheck;
            tb_TypeID.TextChanged += TextChangedBTNAddUpdateCheck;
            ComboBox_FocusID.SelectedIndexChanged += TextChangedBTNAddUpdateCheck;

            Load();
        }

        #region orbit & extend stuff
        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        internal void updateExtends(Extend item)
        {
            cb_OrbitMode.SelectedItem = item.orbitLocationMode;

            foreach (var comboboxItem in ComboBox_FocusID.Items)//scroll through the list of items in the focusables
            {
                if (Helper.IDWithNameToID(comboboxItem.ToString()) == item.focusID)//if the focusables name is equal to the items focus
                {
                    ComboBox_FocusID.SelectedIndex = ComboBox_FocusID.Items.IndexOf(comboboxItem);//then make selected index be the comboboxItem which is what were looking for 
                    break;
                }
            }

            ComboBox_FocusID.SelectedText = item.focusID;

            nud_X.Value = (int)item.x;
            nud_Y.Value = (int)item.y;

            nud_Angle.Value = (int)item.angle;
            nud_OrbitRadius.Value = (int)item.orbitRadius;
            nud_OrbitDays.Value = (int)item.orbitDays;

            nud_MinSpin.Value = (int)item.minSpin;
            nud_MaxSpin.Value = (int)item.maxSpin;

            tb_ID.Text = item.ID;
            tb_Name.Text = item.name;
            tb_TypeID.Text = item.typeID;

            lbl_Order.Text = "Load Order: " + item.order;

            StringBuilder sb = new StringBuilder();

            foreach (string stuffOrbitingAround in item.stuffOrbitingAround)
            {
                sb.Append(stuffOrbitingAround + "\n");
            }

            lbl_StuffOrbitingAround.Text = "Stuff Orbiting Around :\n" + sb.ToString();
        }

        //reset extend elements on the form to default values
        internal void resetExtend()
        {
            cb_OrbitMode.SelectedItem = 0;

            ComboBox_FocusID.SelectedText = "New " + context;//change this in different forms

            resetOrbit();

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_TypeID.Text = "";
        }

        //resets orbit values to the defaults, resetExtend alredy uses this so dont need to run this too
        internal void resetOrbit()
        {
            lbl_x.Visible = false;
            lbl_y.Visible = false;
            lbl_Angle.Visible = false;
            lbl_OrbitRadius.Visible = false;
            lbl_OrbitDays.Visible = false;
            lbl_MinSpin.Visible = false;
            lbl_MaxSpin.Visible = false;

            lbl_Focus.Visible = false;

            btn_FocusRefresh.Visible = false;


            nud_X.Visible = false;

            nud_Y.Visible = false;

            nud_Angle.Visible = false;

            nud_OrbitRadius.Visible = false;

            nud_OrbitDays.Visible = false;

            nud_MinSpin.Visible = false;

            nud_MaxSpin.Visible = false;

            ComboBox_FocusID.Visible = false;

            cb_Spin.Visible = false;
            cb_PointingDown.Visible = false;

            loadOrbits();

            ComboBox_FocusID.SelectedIndex = 0;
        }

        //updates orbitables list
        internal void loadOrbits()
        {
            ComboBox_FocusID.Items.Clear();

            ComboBox_FocusID.Items.Add("");

            List<Extend> orbitables = Helper.GetOrbitablesInSystem(getSystem());

            if (orbitables == null) return;

            if (ComboBox_Selectables.SelectedItem != null)//İF SPAM AAAAAAAAAAAAAAAAAAAAAAAA
            {
                if (orbitables.Contains(Helper.GetExtendFromID(ComboBox_Selectables.SelectedItem.ToString())))
                {
                    orbitables.Remove(Helper.GetExtendFromID(ComboBox_Selectables.SelectedItem.ToString()));
                }
            }

            ComboBox_FocusID.Items.AddRange(Helper.IDNameList(orbitables).ToArray());
        }

        //adds extend values to the item, like id or type id or focus or bla bla
        internal void addExtendValues(Extend item, string type)
        {
            item.orbitLocationMode = Convert.ToInt32(cb_OrbitMode.SelectedItem);

            if (item.orbitLocationMode != 0) item.focusID = Helper.IDWithNameToID(ComboBox_FocusID.SelectedItem.ToString());
            //if focus id isnt set then dont add it for not crashing
            //if no focus itll use x or y or whatever

            item.x = (float)nud_X.Value;
            item.y = (float)nud_Y.Value;

            item.angle = (float)nud_Angle.Value;
            item.orbitRadius = (float)nud_OrbitRadius.Value;
            item.orbitDays = (float)nud_OrbitDays.Value;

            item.minSpin = (float)nud_MinSpin.Value;
            item.maxSpin = (float)nud_MaxSpin.Value;

            item.ID = tb_ID.Text;
            item.name = tb_Name.Text;
            item.typeID = tb_TypeID.Text;

            item.WhatIsThis = type;
        }
        #endregion

        #region functions
        internal string getID()
        {
            if (ComboBox_Selectables.SelectedItem != null)
            {
                return ComboBox_Selectables.SelectedItem.ToString();
            }

            return null;
        }

        internal StarSystemData getSystem()
        {

            if (ComboBox_Systems.SelectedItem == null) return null;

            StarSystemData system = Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString());

            return system;
        }

        internal void LoadSystems()
        {
            ComboBox_Systems.Items.Clear();
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.BaseClass.StarSystemDataList.ToArray())).ToArray());

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Systems.SelectedIndex = 0;
            }

        }

        internal virtual void reset() { resetExtend(); }
        internal virtual void SelectablesIndexChanged() { }
        internal virtual void update(Extend extend)
        {
            updateExtends(extend);
        }

        #endregion

        #region triggers

        internal virtual void Load()
        {
            LoadSystems();
            ComboBox_Selectables.Items.Clear();

            ComboBox_Selectables.Items.Add("New " + context);
            ComboBox_Selectables.SelectedItem = "New " + context;

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Selectables.Items.AddRange(
                    Helper.IDNameList(//turns systems into id + name list for the combo box
                        Helper.ListUpcasting(//turn star list to extend
                            Helper.GetSystemFromID(//get system with id (it automatically removes name)
                                ComboBox_Systems.SelectedItem.ToString()//selected star systems id + name
                                )
                            .starList.ToArray()))//get stars in the selected system
                    .ToArray());
            }

            cb_OrbitMode.Items.Clear();

            cb_OrbitMode.Items.AddRange(new string[]
            {
                "Fixed Location",
                "Circular Orbit"
            });

            cb_OrbitMode.SelectedIndex = 0;

            loadOrbits();


        }

        #region comboboxes

        internal void ComboBox_OrbitMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetOrbit();

            string orbitMode = cb_OrbitMode?.SelectedItem?.ToString();
            if (orbitMode == null || orbitMode == "") orbitMode = "Fixed Location";

            switch (orbitMode)//i dont have any idea on how switches work i work with ifs but why not go fancy when i got the chance
            {

                case "Fixed Location"://if orbit mode is 0 aka only coordinates

                    nud_X.Visible = true;
                    nud_Y.Visible = true;
                    lbl_x.Visible = true;
                    lbl_y.Visible = true;



                    break;//w3 schools says we need a break here but why? cant it just end when it hits the other piece?
                case "Circular Orbit":

                    ComboBox_FocusID.Visible = true;

                    nud_Angle.Visible = true;
                    nud_OrbitRadius.Visible = true;
                    nud_OrbitDays.Visible = true;
                    cb_Spin.Visible = true;
                    cb_PointingDown.Visible = true;

                    lbl_Angle.Visible = true;
                    lbl_OrbitRadius.Visible = true;
                    lbl_OrbitDays.Visible = true;
                    lbl_Focus.Visible = true;

                    btn_FocusRefresh.Visible = true;



                    break;

                default:
                    break;
            }

            TextChangedBTNAddUpdateCheck(sender, e);
        }

        //star selection
        private void ComboBox_Selectables_SelectedIndexChanged(object sender, EventArgs e)
        {
            reset();
            SelectablesIndexChanged();
            ComboBox_OrbitMode_SelectedIndexChanged(sender, e);
        }

        #endregion

        #region buttons

        //update orbit list on refresh key press
        internal void btn_FocusRefresh_Click(object sender, EventArgs e) { loadOrbits(); TextChangedBTNAddUpdateCheck(null, null); ComboBox_OrbitMode_SelectedIndexChanged(null, null); }

        //system list refresh
        internal void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        //adds / updates star
        internal virtual void btn_Add_Click(object sender, EventArgs e) { }
        internal virtual void btn_Clone_Click(object sender, EventArgs e)
        {
            tb_ID.Text += " / " + Guid.NewGuid().ToString().Substring(0, 4);
        }
        internal virtual void btn_Undo_Click(object sender, EventArgs e) { }
        internal virtual void btn_Delete_Click(object sender, EventArgs e) { }

        #endregion

        #region foolproofing 

        //checks for required stuff like ids or parent system
        internal virtual void TextChangedBTNAddUpdateCheck(object sender, EventArgs e)
        {
            if (
                tb_ID.Text == "" ||
                tb_TypeID.Text == "" ||
                ComboBox_Systems.SelectedItem == null ||
                ComboBox_Systems.SelectedItem.ToString() == ""
                )
            {
                btn_Add.Enabled = false;
            }
            else
            {
                btn_Add.Enabled = true;
            }
            if (
                ComboBox_FocusID.SelectedItem == null ||
                ComboBox_FocusID.SelectedItem.ToString() == ""
                )
            {
                btn_Add.Enabled = false;
            }
            else
            {
                btn_Add.Enabled = true;
            }
        }
        private void SpinMinMan(object sender, EventArgs e)
        {

            if (nud_MaxSpin.Value < nud_MinSpin.Value)
            {
                nud_MaxSpin.Value = nud_MinSpin.Value;
            }

        }
        private void cb_PointingDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_PointingDown.Checked)
            {
                cb_Spin.Checked = false;
            }
        }

        //system selection
        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e) { TextChangedBTNAddUpdateCheck(null, null); }

        #endregion

        #region visibilitys

        // spin visiblity change
        private void cb_Spin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Spin.Checked)
            {
                nud_MinSpin.Visible = true;
                nud_MaxSpin.Visible = true;

                lbl_MinSpin.Visible = true;
                lbl_MaxSpin.Visible = true;
            }
            else
            {
                nud_MinSpin.Visible = false;
                nud_MaxSpin.Visible = false;

                lbl_MinSpin.Visible = false;
                lbl_MaxSpin.Visible = false;
            }

            if (cb_Spin.Checked)
            {
                cb_PointingDown.Checked = false;
            }
        }

        #endregion

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }

        #endregion
    }
}
