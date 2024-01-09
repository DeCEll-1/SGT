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
    public partial class AstreoidBelts : Form, IFormInterface
    {
        public List<VeBlib_AstreoidBeltData> deletedAstreoidBeltsThisSession { get; set; } = new List<VeBlib_AstreoidBeltData>();

        private VeBlib_AstreoidBeltData currAstreoid;

        public string context { get; set; } = "Astreoid Belt";

        public AstreoidBelts()
        {
            InitializeComponent();
            UpdateColors();
            Load();
        }

        public void UpdateColors() { Helper.ChangeColorMode(this.Controls); }

        #region customFunctions

        private VeBlib_StarSystemData getSystem()
        {

            if (ComboBox_Systems.SelectedItem == null) return null;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString());

            return system;
        }

        private VeBlib_AstreoidBeltData getData()
        {
            VeBlib_AstreoidBeltData astreoidBelt = new VeBlib_AstreoidBeltData();

            addExtendValues(astreoidBelt);

            astreoidBelt.systemID = ComboBox_Systems.SelectedItem.ToString();

            astreoidBelt.terrainId = ComboBox_TerrainID.Text;

            astreoidBelt.orbitRadius = astreoidBelt.radius = (float)nud_OrbitRadius.Value;

            astreoidBelt.minOrbitDays = (float)nud_MinOrbitDays.Value;
            astreoidBelt.maxOrbitDays = (float)nud_MaxOrbitDays.Value;

            astreoidBelt.numAsteroids = (int)nud_AstreoidCount.Value;
            astreoidBelt.width = (float)nud_Width.Value;

            return astreoidBelt;
        }

        private void reset()
        {
            resetExtend();

            ComboBox_Systems.SelectedItem = "";
            ComboBox_TerrainID.Text = "";

            nud_OrbitRadius.Value = 0;
            nud_MinOrbitDays.Value = 0;
            nud_MaxOrbitDays.Value = 0;

            nud_AstreoidCount.Value = 0;
            nud_Width.Value = 0;

        }

        private void Load()
        {
            LoadSystems();
            ComboBox_AstreoidBelts.Items.Clear();

            ComboBox_AstreoidBelts.Items.Add("New " + context);
            ComboBox_AstreoidBelts.SelectedItem = "New " + context;

            if (ComboBox_Systems.Items.Count != 0)
            {
                UpdateAstreoidBeltsList();
            }

            loadOrbits();
        }

        private void UpdateAstreoidBeltsList()
        {
            //use the numbers for read order
            ComboBox_AstreoidBelts.Items.AddRange(
                Helper.IDNameList(//turns systems into id + name list for the combo box / 5
                    Helper.ListUpcasting(//turn planet list to extend list / 4
                        Helper.GetSystemFromID(//get system object with id (it automatically removes name from id + name) / 2
                            ComboBox_Systems.SelectedItem.ToString()//get selected systems id + name / 1
                            )
                        .astreoidBeltDataList.ToArray()))//get ringBands in the selected system / 3 // change this thing when adding it to other things
                .ToArray());//to array because add range adds arrays and not list, just a minor inconvenience
        }

        private void LoadSystems()
        {
            ComboBox_Systems.Items.Clear();
            ComboBox_Systems.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.BaseClass.StarSystemDataList.ToArray())).ToArray());

            if (ComboBox_Systems.Items.Count != 0)
            {
                ComboBox_Systems.SelectedIndex = 0;
            }

        }

        private void nullCheck()
        {
            if (
               tb_ID.Text == "" ||
               nud_AstreoidCount.Value == 0 ||
               nud_Width.Value == 0 ||
               nud_MinOrbitDays.Value == 0 ||
               nud_MaxOrbitDays.Value == 0 ||
               ComboBox_FocusID.SelectedItem == null ||
               ComboBox_FocusID.SelectedItem.ToString() == "" ||
               ComboBox_Systems.SelectedItem == null ||
               ComboBox_Systems.SelectedItem.ToString() == ""
               )
            {
                btn_RingBand.Enabled = false;
            }
            else
            {
                btn_RingBand.Enabled = true;
            }
        }

        private void AddAstreoidBelt()
        {
            VeBlib_AstreoidBeltData astreoidBelt = getData();

            if (Helper.DoesIDExists(astreoidBelt.ID))//if ringBand with same id exists
            {
                MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            astreoidBelt.systemGUID = getSystem().GUID;

            ItemEditingAdding.AddAstreoidBelt(astreoidBelt);

            currAstreoid = astreoidBelt;

            Load();

            ComboBox_AstreoidBelts.SelectedItem = astreoidBelt.ID + " - " + astreoidBelt.name;//select the added ring

        }

        private string getID()
        {
            if (ComboBox_AstreoidBelts.SelectedItem != null)
            {
                return Helper.IDWithNameToID(ComboBox_AstreoidBelts.SelectedItem.ToString());
            }

            return "";
        }

        private void update(VeBlib_AstreoidBeltData astreoidRing)
        {
            updateExtends(astreoidRing);

            ComboBox_Systems.SelectedItem = astreoidRing.systemID;

            nud_OrbitRadius.Value = (decimal)astreoidRing.orbitRadius;
            nud_MinOrbitDays.Value = (decimal)astreoidRing.minOrbitDays;
            nud_MaxOrbitDays.Value = (decimal)astreoidRing.maxOrbitDays;

            nud_AstreoidCount.Value = astreoidRing.numAsteroids;
            nud_Width.Value = (decimal)astreoidRing.width;


        }

        private void UpdateAstreoidRing()
        {
            VeBlib_AstreoidBeltData updatedAstreoidData = getData();//get planet 

            if (Helper.DoesIDExists(updatedAstreoidData.ID, currAstreoid.ID))
            {
                MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            updatedAstreoidData.GUID = currAstreoid.GUID;//TODO check if you update curr planet on selected planet change

            updatedAstreoidData.systemGUID = Helper.GetSystemFromID(updatedAstreoidData.systemID).GUID;//put system guid, dont get the system from guid because it cant be changed anyways

            ItemEditingAdding.UpdateAstreoidBelt(updatedAstreoidData);//update the planet

            Load();

            ComboBox_AstreoidBelts.SelectedItem = updatedAstreoidData.ID + " - " + updatedAstreoidData.name;//select updated system

            currAstreoid = updatedAstreoidData;//set current star to updated star
        }

        #endregion

        #region orbit

        //update orbit list on refresh key press
        private void btn_FocusRefresh_Click(object sender, EventArgs e)
        {
            loadOrbits();

            if (ComboBox_FocusID.Items.Count == 0) return;

            ComboBox_FocusID.SelectedIndex = 0;
        }

        //updates orbitables list
        private void loadOrbits()
        {
            ComboBox_FocusID.Items.Clear();

            VeBlib_StarSystemData system = getSystem();

            List<Extend> orbitables = Helper.GetOrbitablesInSystem(system);

            if (orbitables == null) return;

            if (ComboBox_AstreoidBelts.SelectedItem != null)//İF SPAM AAAAAAAAAAAAAAAAAAAAAAAA
            {//excludes the selected id from the orbiting list (it cant orbit around itself, cope more)
                if (orbitables.Contains(Helper.GetAstreoidBeltWithID(ComboBox_AstreoidBelts.SelectedItem.ToString())))
                {
                    orbitables.Remove(Helper.GetAstreoidBeltWithID(ComboBox_AstreoidBelts.SelectedItem.ToString()));
                }
            }

            ComboBox_FocusID.Items.AddRange(Helper.IDNameList(orbitables).ToArray());

            if (ComboBox_FocusID.Items.Count == 0) return;

            ComboBox_FocusID.SelectedIndex = 0;

        }

        //adds extend values to the item, like id or type id or focus or bla bla
        private void addExtendValues(Extend item)
        {
            item.ID = tb_ID.Text;
            item.name = tb_Name.Text;

            item.WhatIsThis = Finals.ASTREOID_BELT;
        }

        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        private void updateExtends(Extend item)
        {
            ComboBox_FocusID.SelectedText = item.focusID;

            tb_ID.Text = item.ID;
            tb_Name.Text = item.name;
        }

        //reset extend elements on the form to default values
        private void resetExtend()
        {
            resetOrbit();

            nud_AstreoidCount.Value = 0;
            nud_Width.Value = 0;

            tb_ID.Text = "";
            tb_Name.Text = "";
        }

        //resets orbit values to the defaults, resetExtend alredy uses this so dont need to run this too
        private void resetOrbit()
        {
            loadOrbits();

            if (ComboBox_FocusID.Items.Count == 0) return;

            ComboBox_FocusID.SelectedIndex = 0;

        }


        #endregion

        #region formFunctions

        //system list refresh
        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        #region nullChecks

        //system selection
        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e) { nullCheck(); }

        private void TextChangedBTNAddUpdateCheck(object sender, EventArgs e) { nullCheck(); }

        private void TextChangedBTNAddUpdateCheck(object sender, KeyPressEventArgs e) { nullCheck(); }

        private void TextChangedBTNAddUpdateCheck(object sender, KeyEventArgs e) { nullCheck(); }

        #endregion

        private void btn_AstreoidBelt_Click(object sender, EventArgs e)
        {
            if (btn_RingBand.Text == "Add " + context)
            {
                AddAstreoidBelt();
            }
            else
            {
                UpdateAstreoidRing();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            VeBlib_AstreoidBeltData ringBandToDelete = Helper.GetAstreoidBeltWithID(getID());

            deletedAstreoidBeltsThisSession.Add(ringBandToDelete);

            ItemEditingAdding.DeleteAstreoidBelt(ringBandToDelete);

            Load();

            reset();

        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedAstreoidBeltsThisSession.Count() == 0) { return; }

            VeBlib_AstreoidBeltData lastDeletedItem = deletedAstreoidBeltsThisSession.ElementAt(deletedAstreoidBeltsThisSession.Count() - 1);

            if (Helper.DoesIDExists(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }

            update(lastDeletedItem);

            AddAstreoidBelt();

            deletedAstreoidBeltsThisSession.RemoveAt(deletedAstreoidBeltsThisSession.Count() - 1);
        }

        private void ComboBox_RingBands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_AstreoidBelts.SelectedItem.ToString() == "New " + context)
            {
                btn_RingBand.Text = "Add " + context;

                btn_Delete.Enabled = false;

                reset();
            }
            else if (ComboBox_AstreoidBelts.SelectedItem != null)
            {
                string selectedID = ComboBox_AstreoidBelts.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                VeBlib_AstreoidBeltData ringBand = Helper.GetAstreoidBeltInSystem(systemID, selectedID);//get star in the system

                update(ringBand);// update the star with variables

                btn_RingBand.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }
        }

        #endregion

    }
}
