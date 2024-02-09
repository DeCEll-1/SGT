using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class RingBands : Form, IFormInterface
    {
        public List<VeBlib_RingBandData> deletedRingBandsInThisSession { get; set; } = new List<VeBlib_RingBandData>();
        private VeBlib_RingBandData currRingBand { get; set; } = new VeBlib_RingBandData();

        private Color currColor { get; set; } = Color.Red;

        private string context { get; set; } = "Ring Band";

        public RingBands()
        {
            InitializeComponent();
            UpdateColors();
            Load();
        }

        public void UpdateColors() { Helper.ChangeColorMode(this.Controls); UpdateColorPanel(); }

        #region orbit

        //update orbit list on refresh key press
        private void btn_FocusRefresh_Click(object sender, EventArgs e) { loadOrbits(); }

        //updates orbitables list
        private void loadOrbits()
        {
            ComboBox_FocusID.Items.Clear();

            VeBlib_StarSystemData system = getSystem();

            List<Extend> orbitables = Helper.GetOrbitablesInSystem(system);

            if (orbitables == null) return;

            if (ComboBox_RingBands.SelectedItem != null)//İF SPAM AAAAAAAAAAAAAAAAAAAAAAAA
            {//excludes the selected id from the orbiting list (it cant orbit around itself, cope more)
                if (orbitables.Contains(Helper.GetRingBandWithID(ComboBox_RingBands.SelectedItem.ToString())))
                {
                    orbitables.Remove(Helper.GetRingBandWithID(ComboBox_RingBands.SelectedItem.ToString()));
                }
            }

            ComboBox_FocusID.Items.AddRange(Helper.IDNameList(orbitables).ToArray());

            if (ComboBox_FocusID.Items.Count == 0) return;

            //ComboBox_FocusID.SelectedIndex = 0;

        }

        //adds extend values to the item, like id or type id or focus or bla bla
        private void addExtendValues(Extend item)
        {
            item.orbitRadius = item.radius = (float)nud_MiddleRadius.Value;//aka orbit radius
            item.orbitDays = (float)nud_OrbitDays.Value;

            item.focusID = Helper.IDWithNameToID(ComboBox_FocusID.SelectedItem.ToString());

            item.ID = tb_ID.Text;
            item.name = tb_Name.Text;

            item.WhatIsThis = Finals.RING_BAND;
        }

        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        private void updateExtends(Extend item)
        {
            //ComboBox_FocusID.SelectedText = item.focusID;

            nud_MiddleRadius.Value = (int)item.radius;
            nud_OrbitDays.Value = (int)item.orbitDays;

            tb_ID.Text = item.ID;
            tb_Name.Text = item.name;
        }

        //reset extend elements on the form to default values
        private void resetExtend()
        {
            //resetOrbit();

            nud_OrbitDays.Value = 0;
            nud_MiddleRadius.Value = 0;

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

        private void btn_FocusRefresh_Click_1(object sender, EventArgs e)
        {
            loadOrbits();

            if (ComboBox_FocusID.Items.Count == 0) return;

            ComboBox_FocusID.SelectedIndex = 0;
        }

        #endregion

        #region customFunctions

        private VeBlib_StarSystemData getSystem()
        {

            if (ComboBox_Systems.SelectedItem == null) return null;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString());

            return system;
        }

        private VeBlib_RingBandData getData()
        {
            VeBlib_RingBandData ringBand = new VeBlib_RingBandData();

            addExtendValues(ringBand);

            ringBand.systemID = ComboBox_Systems.SelectedItem.ToString();

            ringBand.bandIndex = (int)nud_BandIndex.Value;

            ringBand.middleRadius = (float)nud_MiddleRadius.Value;

            ringBand.terrainId = ComboBox_TerrainID.Text;

            #region textures

            ringBand.bandWidthInTexture = (float)nud_BandWidthInTexture.Value;//texture
            ringBand.bandWidthInEngine = (float)nud_BandWidthInEngine.Value;//engine

            ringBand.category = tb_TextureCategory.Text;
            ringBand.key = tb_TextureID.Text;

            #endregion

            UpdateColorPanel();

            ringBand.color = currColor;

            return ringBand;
        }

        private void reset()
        {
            resetExtend();

            //ComboBox_Systems.SelectedItem = "";
            ComboBox_TerrainID.Text = "";

            nud_BandIndex.Value = 0;

            nud_MiddleRadius.Value = 0;

            nud_BandWidthInTexture.Value = 256;
            nud_BandWidthInEngine.Value = 0;

            tb_TextureCategory.Text = "";
            tb_TextureID.Text = "";



            currColor = Color.Red;

            nud_Red.Value = 255;
            nud_Green.Value = 0;
            nud_Blue.Value = 0;
            nud_Alpha.Value = 255;

        }

        private void Load()
        {
            LoadSystems();
            ComboBox_RingBands.Items.Clear();

            ComboBox_RingBands.Items.Add("New " + context);
            ComboBox_RingBands.SelectedItem = "New " + context;

            if (ComboBox_Systems.Items.Count != 0)
            {
                UpdateRingBands();
            }

            loadOrbits();
        }

        private void UpdateRingBands()
        {
            //use the numbers for read order
            ComboBox_RingBands.Items.AddRange(
                Helper.IDNameList(//turns systems into id + name list for the combo box / 5
                    Helper.ListUpcasting(//turn planet list to extend list / 4
                        Helper.GetSystemFromID(//get system object with id (it automatically removes name from id + name) / 2
                            ComboBox_Systems.SelectedItem.ToString()//get selected systems id + name / 1
                            )
                        .ringBandDataList.ToArray()))//get ringBands in the selected system / 3 // change this thing when adding it to other things
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
               tb_TextureID.Text == "" ||
               tb_TextureCategory.Text == "" ||
               nud_OrbitDays.Value == 0 ||
               nud_MiddleRadius.Value == 0 ||
               nud_BandWidthInTexture.Value == 0 ||
               nud_BandWidthInEngine.Value == 0 ||
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

        private void AddRingBand()
        {
            VeBlib_RingBandData ringBand = getData();

            if (Helper.DoesIDExists(ringBand.ID))//if ringBand with same id exists
            {
                MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ringBand.systemGUID = getSystem().GUID;

            ItemEditingAdding.AddRingBand(ringBand);

            currRingBand = ringBand;

            ComboBox_FocusID_SelectedIndexChanged(null, null);

            ComboBox_RingBands.SelectedItem = ringBand.ID + " - " + ringBand.name;//select the added planet

        }

        private string getID()
        {
            if (ComboBox_RingBands.SelectedItem != null)
            {
                return Helper.IDWithNameToID(ComboBox_RingBands.SelectedItem.ToString());
            }

            return "";
        }

        private void update(VeBlib_RingBandData ringBand)
        {
            if (ringBand == null) return;

            updateExtends(ringBand);

            ComboBox_Systems.SelectedItem = ringBand.systemID;

            nud_BandIndex.Value = ringBand.bandIndex;

            nud_MiddleRadius.Value = (decimal)ringBand.middleRadius;

            #region textures

            nud_BandWidthInTexture.Value = (decimal)ringBand.bandWidthInTexture;
            nud_BandWidthInEngine.Value = (decimal)ringBand.bandWidthInEngine;

            tb_TextureCategory.Text = ringBand.category;
            tb_TextureID.Text = ringBand.key;

            #endregion

            currColor = ringBand.color;

            nud_Red.Value = ringBand.color.R;
            nud_Green.Value = ringBand.color.G;
            nud_Blue.Value = ringBand.color.B;
            nud_Alpha.Value = ringBand.color.A;

            currRingBand = ringBand;

        }

        #endregion

        #region colors

        private void UpdateColorPanel() { pnl_Color.BackColor = Color.FromArgb((int)nud_Alpha.Value, (int)nud_Red.Value, (int)nud_Green.Value, (int)nud_Blue.Value); currColor = pnl_Color.BackColor; }

        private void nud_ColorNUD_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (sender as NumericUpDown);


            char colorCode = nud.Name.ToString().ToCharArray()[4];

            //i aint usin switch here its hella confusing
            if (colorCode == 'R')//nud is red
            {
                TrackBar_Red.Value = (int)nud.Value;
            }
            else if (colorCode == 'G')//green
            {
                TrackBar_Green.Value = (int)nud.Value;
            }
            else if (colorCode == 'B')//nud is blue
            {
                TrackBar_Blue.Value = (int)nud.Value;
            }
            else//nud is alpha
            {
                TrackBar_Alpha.Value = (int)nud.Value;
            }

            UpdateColorPanel();

        }

        private void TrackBar_ColorTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trb = (sender as TrackBar);

            char colorCode = trb.Name.ToString().ToCharArray()[9];


            //i aint usin switch here its hella confusing
            if (colorCode == 'R')//nud is red
            {
                nud_Red.Value = (int)trb.Value;
            }
            else if (colorCode == 'G')//green
            {
                nud_Green.Value = (int)trb.Value;
            }
            else if (colorCode == 'B')//nud is blue
            {
                nud_Blue.Value = (int)trb.Value;
            }
            else//nud is alpha
            {
                nud_Alpha.Value = (int)trb.Value;
            }

            UpdateColorPanel();

        }

        #endregion


        #region formFunctions

        //system list refresh
        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        #region nullChecks

        //system selection
        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e)
        {
            nullCheck();
            //the orbit list doesnt get updated, fix it

            ComboBox_FocusID.Items.Clear();
            ComboBox_FocusID.Items.AddRange(Helper.IDList(Helper.ListUpcasting(Helper.GetOrbitablesInSystem(getSystem()).ToArray())).ToArray());

            //why the fuck do you not select the first item in initilisation but work properly othervise? the shit?
            if (ComboBox_FocusID.Items.Count != 0) ComboBox_FocusID.SelectedIndex = 0;

        }

        private void ComboBox_FocusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            nullCheck();
            //the ring list doesnt get updated, fix it

            ComboBox_RingBands.Items.Clear();

            ComboBox_RingBands.Items.Add("New " + context);

            ComboBox_RingBands.Items.AddRange(Helper.IDList(Helper.ListUpcasting(getSystem().ringBandDataList.FindAll(s => Helper.IDWithNameToID(s.focusID) == Helper.IDWithNameToID(ComboBox_FocusID.SelectedItem.ToString())).ToArray())).ToArray());


            ComboBox_RingBands.SelectedIndex = (ComboBox_RingBands.Items.Count == 1) ? 0 : 1;
        }

        private void TextChangedBTNAddUpdateCheck(object sender, EventArgs e) { nullCheck(); }

        private void TextChangedBTNAddUpdateCheck(object sender, KeyPressEventArgs e) { nullCheck(); }

        private void TextChangedBTNAddUpdateCheck(object sender, KeyEventArgs e) { nullCheck(); }

        #endregion

        private void btn_RingBand_Click(object sender, EventArgs e)
        {
            if (btn_RingBand.Text == "Add " + context)
            {
                AddRingBand();
            }
            else
            {
                VeBlib_RingBandData updatedRingBand = getData();//get planet 

                if (Helper.DoesIDExists(updatedRingBand.ID, currRingBand.ID))
                {
                    MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                updatedRingBand.GUID = currRingBand.GUID;//TODO check if you update curr planet on selected planet change

                updatedRingBand.systemGUID = Helper.GetSystemFromID(updatedRingBand.systemID).GUID;//put system guid, dont get the system from guid because it cant be changed anyways

                ItemEditingAdding.UpdateRingBand(updatedRingBand);//update the planet

                Load();

                ComboBox_RingBands.SelectedItem = updatedRingBand.ID + " - " + updatedRingBand.name;//select updated system

                currRingBand = updatedRingBand;//set current star to updated star

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            VeBlib_RingBandData ringBandToDelete = Helper.GetRingBandWithID(getID());

            deletedRingBandsInThisSession.Add(ringBandToDelete);

            ItemEditingAdding.DeleteRingBand(ringBandToDelete);

            Load();

            reset();

        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedRingBandsInThisSession.Count() == 0) { return; }

            VeBlib_RingBandData lastDeletedItem = deletedRingBandsInThisSession.ElementAt(deletedRingBandsInThisSession.Count() - 1);

            if (Helper.DoesIDExists(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }

            update(lastDeletedItem);

            AddRingBand();

            deletedRingBandsInThisSession.RemoveAt(deletedRingBandsInThisSession.Count() - 1);
        }

        private void ComboBox_RingBands_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBox_RingBands.SelectedItem.ToString() == "" && ComboBox_RingBands.Items.Count != 0) ComboBox_RingBands.SelectedIndex = 0;

            if (ComboBox_RingBands.SelectedItem.ToString() == "New " + context)
            {
                btn_RingBand.Text = "Add " + context;

                btn_Delete.Enabled = false;

                reset();
            }
            else if (ComboBox_RingBands.SelectedItem != null)
            {
                string selectedID = ComboBox_RingBands.SelectedItem.ToString();

                string systemID = ComboBox_Systems.SelectedItem.ToString();

                VeBlib_RingBandData ringBand = Helper.GetRingBandInSystem(systemID, selectedID);//get star in the system

                update(ringBand);// update the star with variables

                btn_RingBand.Text = "Update " + context;

                btn_Delete.Enabled = true;

            }
            else
            {
                btn_Delete.Enabled = false;
            }

            nullCheck();
        }


        #endregion


    }
}
