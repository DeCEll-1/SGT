using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.CSVClasses;
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
using System.Web;
using System.Windows.Forms;

namespace SSSystemGenerator.Forms
{
    public partial class Markets : Form, IFormInterface
    {

        public List<VeBlib_MarketData> deletedMarketsInThisSessionList { get; set; } = new List<VeBlib_MarketData>();

        public static VeBlib_MarketData marketAddablesHolder { get; set; } = new VeBlib_MarketData();

        public static VeBlib_MarketData currMarket { get; set; }

        public const string context = "Market";

        public Markets()
        {
            InitializeComponent();
            UpdateColors();

            ReloadCSV();

            Load();
        }

        public void UpdateColors() { Helper.ChangeColorMode(this.Controls); }


        #region customFunctions

        private void ReloadCSV() { updateSelectables(); }

        private string getID()
        {
            if (ComboBox_PrimaryEntity.SelectedItem != null)
            {
                return Helper.GetMarketWithPrimaryEntityID(ComboBox_PrimaryEntity.SelectedItem.ToString()).ID;
            }

            return "";
        }

        private void Load()
        {
            updateSelectables();

            LoadSystems();

            UpdatePrimaryEntityList();



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

        private void reset()
        {
            marketAddablesHolder = new VeBlib_MarketData();

            cb_MarketPirateMode.Checked = false;
            cb_MarketWithJunkAndChatter.Checked = false;

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_MarketFactionID.Text = "";
        }

        private VeBlib_MarketData getData()
        {
            VeBlib_MarketData market = new VeBlib_MarketData();

            market.primaryEntity = Helper.IDWithNameToID(ComboBox_PrimaryEntity.SelectedItem.ToString());

            market.industries.AddRange(marketAddablesHolder.industries.ToArray());//add industries

            market.submarkets.AddRange(marketAddablesHolder.submarkets.ToArray());//add submarkets

            market.marketConditions.AddRange(marketAddablesHolder.marketConditions.ToArray());//add conditions

            market.connectedEntities.AddRange(marketAddablesHolder.connectedEntities.ToArray());//add conditions

            market.systemID = getSystemID();

            market.ID = tb_ID.Text;

            market.name = tb_Name.Text;

            market.WithJunkAndChatter = cb_MarketWithJunkAndChatter.Checked;

            market.PirateMode = cb_MarketPirateMode.Checked;

            market.size = (byte)nud_MarketSize.Value;

            market.factionID = tb_MarketFactionID.Text;

            return market;
        }

        private VeBlib_StarSystemData getSystem()
        {
            if (ComboBox_Systems.SelectedItem != null) { return Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString()); }
            return null;
        }

        private string getSystemID()
        {
            if (ComboBox_Systems.SelectedItem != null) { return ComboBox_Systems.SelectedItem.ToString(); }
            return null;
        }

        private void AddMarket()
        {
            VeBlib_MarketData marketToAdd = getData();

            if (Helper.DoesIDExists(marketToAdd.ID))
            {
                MessageBox.Show(context + " ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            marketToAdd.systemGUID = getSystem().GUID;

            ItemEditingAdding.AddMarket(marketToAdd);

            currMarket = marketToAdd;

            Load();

            ComboBox_PrimaryEntity.SelectedItem = currMarket.primaryEntity + " - " + Helper.GetExtendFromID(currMarket.primaryEntity).name;
        }

        private void EditMarket()
        {
            VeBlib_MarketData updatedMarket = getData();

            if (Helper.DoesIDExists(updatedMarket.ID, currMarket.ID))
            {
                MessageBox.Show(context + " ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            updatedMarket.GUID = currMarket.GUID;

            updatedMarket.systemGUID = Helper.GetSystemFromID(updatedMarket.systemID).GUID;//put system guid, dont get the system from guid because it cant be changed anyways

            ItemEditingAdding.UpdateMarket(updatedMarket);

            currMarket = updatedMarket;

            Load();

            ComboBox_PrimaryEntity.SelectedItem = currMarket.primaryEntity + " - " + Helper.GetExtendFromID(currMarket.primaryEntity).name;
        }

        private void UpdatePrimaryEntityList()
        {

            if (getSystemID() == null || getSystemID() == "") { return; }

            ComboBox_PrimaryEntity.Items.Clear();

            ComboBox_PrimaryEntity.Items.AddRange(Helper.IDNameList(Helper.GetOrbitablesInSystem(getSystemID())).ToArray());
        }

        private void update(VeBlib_MarketData marketToUpdateFormWith)
        {
            ComboBox_PrimaryEntity.SelectedItem = marketToUpdateFormWith.primaryEntity;

            marketAddablesHolder.industries.Clear();
            marketAddablesHolder.industries.AddRange(marketToUpdateFormWith.industries.ToArray());

            marketAddablesHolder.submarkets.Clear();
            marketAddablesHolder.submarkets.AddRange(marketToUpdateFormWith.submarkets.ToArray());

            marketAddablesHolder.marketConditions.Clear();
            marketAddablesHolder.marketConditions.AddRange(marketToUpdateFormWith.marketConditions.ToArray());

            marketAddablesHolder.connectedEntities.Clear();
            marketAddablesHolder.connectedEntities.AddRange(marketToUpdateFormWith.connectedEntities.ToArray());

            tb_ID.Text = marketToUpdateFormWith.ID;

            tb_Name.Text = marketToUpdateFormWith.name;

            cb_MarketWithJunkAndChatter.Checked = marketToUpdateFormWith.WithJunkAndChatter;

            cb_MarketPirateMode.Checked = marketToUpdateFormWith.PirateMode;

            nud_MarketSize.Value = marketToUpdateFormWith.size;

            tb_MarketFactionID.Text = marketToUpdateFormWith.factionID;

        }

        #endregion

        #region formFunctions

        #region prev-next / csv

        public sbyte indexOfPrevNext { get; set; } = 0;
        public sbyte maxTabs { get; set; } = 3;

        private void btn_CSVRefresh_Click(object sender, EventArgs e) { ReloadCSV(); }

        private void updateSelectables()
        {
            if (indexOfPrevNext == 0)// industries
            {
                tb_Selectables.Text = "Industries";

                ComboBox_Addables.Items.Clear();

                ComboBox_Addables.Items.AddRange(
                    CSVHelper.İndustriesListToStringIDNameList(Helper.GetCSV().Industries, marketAddablesHolder)//get id + name list of industries
                    .ToArray()//change to array for combo box
                    );

            }
            else if (indexOfPrevNext == 1)// submarkets
            {
                tb_Selectables.Text = "Submarkets";

                ComboBox_Addables.Items.Clear();

                ComboBox_Addables.Items.AddRange(
                    CSVHelper.SubmarketsListToStringIDNaneList(Helper.GetCSV().Submarkets, marketAddablesHolder)//get id + name list of submarkets
                    .ToArray()//change to array for combo box
                    );

            }
            else if (indexOfPrevNext == 2) // conditions
            {

                tb_Selectables.Text = "Conditions";

                ComboBox_Addables.Items.Clear();

                ComboBox_Addables.Items.AddRange(
                    CSVHelper.MarketConditionsListToStringIDNameList(Helper.GetCSV().MarketConditions, marketAddablesHolder)//get id + name list of market conditions
                    .ToArray()//change to array for combo box
                    );

            }
            else if (indexOfPrevNext == 3) // conditions
            {

                tb_Selectables.Text = "ConnectedEntities";

                ComboBox_Addables.Items.Clear();

                if (getSystem() == null || Helper.GetOrbitablesInSystem(getSystem()).Count == 0)
                {
                    ComboBox_Addables.Items.Add("NO_SYSTEMS_SELECTED/SYSTEM_DOESNT_HAVE_ENTITIES");
                    ComboBox_Addables.SelectedIndex = 0;
                    return;
                }
                else
                {
                    ComboBox_Addables.Items.AddRange(Helper.GetOrbitablesInSystem(getSystem(), marketAddablesHolder).ToArray());
                }


            }
            else //indexOfPrevNext == 4 //is removed, kill this
            {
                tb_Selectables.Text = "Remove Market Content";//get everything in the market and then ??? // list them properly

                ComboBox_Addables.Items.Clear();

                ComboBox_Addables.Items.Add("*-Industries-*");

                ComboBox_Addables.Items.AddRange(marketAddablesHolder.industries.ToArray());

                ComboBox_Addables.Items.Add("*-Submarkets-*");

                ComboBox_Addables.Items.AddRange(marketAddablesHolder.submarkets.ToArray());

                ComboBox_Addables.Items.Add("*-Conditions-*");

                ComboBox_Addables.Items.AddRange(marketAddablesHolder.marketConditions.ToArray());

                ComboBox_Addables.Items.Add("*-ConnectedEntities-*");

                ComboBox_Addables.Items.AddRange(marketAddablesHolder.connectedEntities.ToArray());


            }

            ComboBox_Addables.Items.Insert(0, "");

            ComboBox_Addables.SelectedIndex = 0;


        }

        //addables button enabled disabled
        private void ComboBox_Addables_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox = (sender as ComboBox);

            if (comboBox.SelectedItem != null && comboBox.SelectedItem.ToString() == "")
            {
                btn_AddAddable.Enabled = false;
            }
            else
            {
                string selecting = tb_Selectables.Text;//can be: Industries , Submarkets , Conditions 

                string selectedItem = comboBox.SelectedItem.ToString();

                if (selecting == "Industries")//homie i aint using switch case again that hell man
                {
                    btn_AddAddable.Text = "Add Industry";
                    if (marketAddablesHolder.industries.Contains(Helper.IDWithNameToID(selectedItem)))
                    {//the id is already added
                        btn_AddAddable.Text = "Remove Industry";
                    }
                }
                else if (selecting == "Submarkets")
                {
                    btn_AddAddable.Text = "Add Submarket";
                    if (marketAddablesHolder.submarkets.Contains(Helper.IDWithNameToID(selectedItem)))
                    {//the id is already added
                        btn_AddAddable.Text = "Remove Submarket";
                    }
                }
                else if (selecting == "Conditions")
                {
                    btn_AddAddable.Text = "Add Condition";
                    if (marketAddablesHolder.marketConditions.Contains(Helper.IDWithNameToID(selectedItem)))
                    {//the id is already added
                        btn_AddAddable.Text = "Remove Condition";
                    }
                }
                else//ConnectedEntities
                {
                    btn_AddAddable.Text = "Add Connected Entity";
                    if (marketAddablesHolder.connectedEntities.Contains(Helper.IDWithNameToID(selectedItem)))
                    {//the id is already added
                        btn_AddAddable.Text = "Remove Connected Entity";
                    }
                }


                btn_AddAddable.Enabled = true;
            }

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            //scroll through 0-2, so 3 choices for industries submarkets conditions stuff to remove
            indexOfPrevNext -= 1;//reduce it
            if (indexOfPrevNext == -1)//if its -1 (was 0) then set it to
            {
                indexOfPrevNext = maxTabs;//3 aka connected entities
            }

            updateSelectables();

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            indexOfPrevNext += 1;
            if (indexOfPrevNext == maxTabs + 1)
            {
                indexOfPrevNext = 0;//aka industries
            }

            updateSelectables();

        }

        #endregion

        private void btn_AddAddable_Click(object sender, EventArgs e)
        {
            if (ComboBox_Addables.SelectedItem != null)
            {

                string selecting = tb_Selectables.Text;//can be: Industries , Submarkets , Conditions 

                string IDToAddRemove = ComboBox_Addables.SelectedItem.ToString();

                IDToAddRemove = Helper.IDWithNameToID(IDToAddRemove);

                switch (selecting)//i was should use if the performance doesnt matter this is a windows forms app for gods sakeAAAA
                {
                    case "Industries"://add industry

                        if (!marketAddablesHolder.industries.Contains(IDToAddRemove))
                        {
                            marketAddablesHolder.industries.Add(IDToAddRemove);
                        }
                        else//id is already added to the market
                        {
                            marketAddablesHolder.industries.Remove(IDToAddRemove);
                        }


                        break;
                    case "Submarkets"://add submarket

                        if (!marketAddablesHolder.submarkets.Contains(IDToAddRemove))
                        {
                            marketAddablesHolder.submarkets.Add(IDToAddRemove);
                        }
                        else
                        {
                            marketAddablesHolder.submarkets.Remove(IDToAddRemove);
                        }



                        break;
                    case "Conditions"://add condition

                        if (!marketAddablesHolder.marketConditions.Contains(IDToAddRemove))
                        {
                            marketAddablesHolder.marketConditions.Add(IDToAddRemove);
                        }
                        else
                        {
                            marketAddablesHolder.marketConditions.Remove(IDToAddRemove);//my brain is melting
                        }


                        break;

                    case "ConnectedEntities":

                        if (!marketAddablesHolder.connectedEntities.Contains(IDToAddRemove))
                        {
                            marketAddablesHolder.connectedEntities.Add(IDToAddRemove);
                        }
                        else
                        {
                            marketAddablesHolder.connectedEntities.Remove(IDToAddRemove);
                        }


                        break;
                    default:
                        break;
                }

                updateSelectables();//update the selectables to update the list

                ComboBox_Addables.SelectedItem.ToString();
            }
        }

        private void btn_AddMarket_Click(object sender, EventArgs e)
        {
            if (btn_Market.Text == "Add " + context) // add the market
            {
                AddMarket();
            }
            else//btn_Market.Text == "Update Market" // update
            {
                EditMarket();
            }
        }

        private void btn_SystemsRefresh_Click(object sender, EventArgs e) { LoadSystems(); }

        private void btn_PrimaryEntityReset_Click(object sender, EventArgs e) { UpdatePrimaryEntityList(); }

        private void ComboBox_Systems_SelectedIndexChanged(object sender, EventArgs e) { UpdatePrimaryEntityList(); Enable_AddingEditing_KeyPress(null, null); }

        private void ComboBox_PrimaryEntity_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBox_PrimaryEntity.SelectedItem != null && Helper.GetMarketWithPrimaryEntityID(ComboBox_PrimaryEntity.SelectedItem.ToString()) != null)//if the selected haves a market or not
            {//theres a market
                update(Helper.GetMarketWithPrimaryEntityID(ComboBox_PrimaryEntity.SelectedItem.ToString()));
                lbl_DoesItHaveMarket.Text = "Haves A Market";
                btn_Market.Text = "Update " + context;
                btn_Delete.Enabled = true;
            }
            else
            {
                lbl_DoesItHaveMarket.Text = "Does Not Have A Market";
                btn_Market.Text = "Add " + context;
                btn_Delete.Enabled = false;
            }

            Enable_AddingEditing_KeyPress(null, null);

        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedMarketsInThisSessionList.Count() == 0) { return; }

            VeBlib_MarketData lastDeletedItem = deletedMarketsInThisSessionList.ElementAt(deletedMarketsInThisSessionList.Count() - 1);

            if (Helper.DoesIDExists(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }

            update(lastDeletedItem);

            AddMarket();

            deletedMarketsInThisSessionList.RemoveAt(deletedMarketsInThisSessionList.Count() - 1);
        }

        private void Enable_AddingEditing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
               tb_ID.Text == "" ||
               tb_MarketFactionID.Text == "" ||
               ComboBox_PrimaryEntity.SelectedItem == null ||
               ComboBox_PrimaryEntity.SelectedItem.ToString() == "" ||
               ComboBox_Systems.SelectedItem == null ||
               ComboBox_Systems.SelectedItem.ToString() == ""
               )
            {
                btn_Market.Enabled = false;
            }
            else
            {
                btn_Market.Enabled = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            VeBlib_MarketData marketToDelete = Helper.GetMarketWithID(getID());

            deletedMarketsInThisSessionList.Add(marketToDelete);

            ItemEditingAdding.DeleteMarket(marketToDelete);

            Load();

        }

        private void tb_ID_TextChanged(object sender, EventArgs e) { Enable_AddingEditing_KeyPress(null, null); }

        #endregion

        #region comments
        //case "Remove Market Content"://to remove
        //                switch (Helper.WhatTypeIsThisIDIs(IDToAddRemove))//switches are weird mayn
        //                {
        //                    case Finals.INDUSTRIES://its an industry

        //                        marketAddablesHolder.industries.Remove(IDToAddRemove);

        //                        break;
        //                    case Finals.SUBMARKETS://its a submarket

        //                        marketAddablesHolder.submarkets.Remove(IDToAddRemove);

        //                        break;
        //                    case Finals.MARKET_CONDITIONS://its a condition

        //                        marketAddablesHolder.marketConditions.Remove(IDToAddRemove);

        //                        break;
        //                    case Finals.ORBITABLE://its a condition

        //                        marketAddablesHolder.connectedEntities.Remove(IDToAddRemove);

        //                        break;
        //                    default:
        //                        break;
        //                }
        //                break; 
        #endregion

    }
}
