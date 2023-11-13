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
    public partial class Planets : Form
    {

        public List<VeBlib_PlanetData> deletedPlanetssInThisSessionList { get; set; }
        public VeBlib_PlanetData currPlanet { get; set; } = null;

        public string context { get; set; } = "Planet";

        public Planets()
        {
            InitializeComponent();
        }

        #region focusStuff

        //orbit mode selection
        private void ComboBox_OrbitMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //update orbit list on refresh key press
        private void btn_FocusRefresh_Click(object sender, EventArgs e) { loadOrbits(); }

        //updates orbitables list
        private void loadOrbits()
        {
            ComboBox_FocusID.Items.Clear();

            ComboBox_FocusID.Items.Add("");

            List<Extend> orbitables = Helper.getOrbitablesInSystem(getSystem());

            if (orbitables == null) return;

            if (ComboBox_Planets.SelectedItem != null)//İF SPAM AAAAAAAAAAAAAAAAAAAAAAAA
            {
                if (orbitables.Contains(Helper.GetStarWithID(ComboBox_Planets.SelectedItem.ToString())))
                {
                    orbitables.Remove(Helper.GetStarWithID(ComboBox_Planets.SelectedItem.ToString()));
                }
            }

            ComboBox_FocusID.Items.AddRange(Helper.IDNameList(orbitables).ToArray());
        }

        //adds extend values to the item, like id or type id or focus or bla bla
        private void addExtendValues(Extend item)
        {
            item.orbitLocationMode = Convert.ToInt32(ComboBox_OrbitMode.SelectedItem);

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
        }

        //updates extend variables thats on the form, aka changes everything on the form thats related to the extend to the item that got sent here
        private void updateExtends(Extend item)
        {
            ComboBox_OrbitMode.SelectedItem = item.orbitLocationMode;

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
        }

        //reset extend elements on the form to default values
        private void resetExtend()
        {
            ComboBox_OrbitMode.SelectedItem = 0;

            ComboBox_FocusID.SelectedText = "New " + context;//change this in different forms

            resetOrbit();

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_TypeID.Text = "";
        }

        //resets orbit values to the defaults, resetExtend alredy uses this so dont need to run this too
        private void resetOrbit()
        {
            nud_X.Value = -1;
            nud_X.Enabled = false;

            nud_Y.Value = -1;
            nud_Y.Enabled = false;

            nud_Angle.Value = -1;
            nud_Angle.Enabled = false;

            nud_OrbitRadius.Value = -1;
            nud_OrbitRadius.Enabled = false;

            nud_OrbitDays.Value = -1;
            nud_OrbitDays.Enabled = false;

            nud_MinSpin.Value = -1;
            nud_MinSpin.Enabled = false;

            nud_MaxSpin.Value = -1;
            nud_MaxSpin.Enabled = false;

            ComboBox_FocusID.Enabled = false;

            loadOrbits();

            ComboBox_FocusID.SelectedIndex = 0;


        }

        #endregion

        #region customFunctions

        //system list refresh
        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        private void Load()
        {
            LoadSystems();
            ComboBox_Planets.Items.Clear();

            ComboBox_Planets.Items.Add("New " + context);
            ComboBox_Planets.SelectedItem = "New " + context;

            if (ComboBox_System.Items.Count != 0)
            {

                //use the numbers for read order

                ComboBox_Planets.Items.AddRange(
                    Helper.IDNameList(//turns systems into id + name list for the combo box / 5
                        Helper.ListUpcasting(//turn planet list to extend list / 4
                            Helper.GetSystemFromID(//get system object with id (it automatically removes name from id + name) / 2
                                ComboBox_System.SelectedItem.ToString()//get selected systems id + name / 1
                                )
                            .planetList.ToArray()))//get planets in the selected system / 3
                    .ToArray());//to array because add range adds arrays and not list, just a minor inconvenience
            }

            ComboBox_OrbitMode.Items.Clear();

            ComboBox_OrbitMode.Items.AddRange(new object[] { 0, 1, 2, 3 });

            ComboBox_OrbitMode.SelectedItem = 0;

            loadOrbits();


        }

        private void LoadSystems()
        {
            ComboBox_Planets.Items.Clear();
            ComboBox_Planets.Items.AddRange(Helper.IDNameList(Helper.ListUpcasting(Statics.baseClass.StarSystemDataList.ToArray())).ToArray());

            if (ComboBox_Planets.Items.Count != 0)
            {
                ComboBox_Planets.SelectedIndex = 0;
            }

        }

        private void update(VeBlib_StarData star)
        {
            updateExtends(star);

            nud_Radius.Value = (decimal)star.radius;

        }

        private void reset()
        {
            resetExtend();

            nud_Radius.Value = 0;
        }

        private VeBlib_StarSystemData getSystem()
        {

            if (ComboBox_Planets.SelectedItem == null) return null;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(ComboBox_Planets.SelectedItem.ToString());

            return system;
        }

        private VeBlib_PlanetData getData()
        {
            VeBlib_PlanetData gettenStar = new VeBlib_PlanetData();

            addExtendValues(gettenStar);

            gettenStar.systemID = ComboBox_Planets.SelectedItem.ToString();

            gettenStar.radius = (float)nud_Radius.Value;

            return gettenStar;
        }

        #endregion

        #region formStuff


        private void btn_Planet_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
