using BrightIdeasSoftware;
using SSSystemGenerator.Classes;
using SSSystemGenerator.Classes.CSVClasses;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SSSystemGenerator.Forms
{
    public partial class Markets : Form, IFormInterface
    {

        public List<MarketData> deletedMarketsInThisSessionList { get; set; } = new List<MarketData>();
        public static MarketData currMarket { get; set; }

        public const string context = "Market";

        public Markets()
        {
            InitializeComponent();
            UpdateColors();

            Load();
        }

        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }


        #region customFunctions

        private string getID()
        {
            if (ComboBox_PrimaryEntity.SelectedItem != null)
            {
                return Helper.GetMarketWithPrimaryEntityID(ComboBox_PrimaryEntity.SelectedItem.ToString()).ID;
            }

            return "";
        }

        private new void Load()
        {
            LoadSystems();

            UpdatePrimaryEntityList();

            // add mods icons to icon list
            SettingsController.ModsToLoad.ForEach(mod =>
            {
                string iconPath = mod.FullName + @"\icon.png";
                if (File.Exists(iconPath))
                { // https://stackoverflow.com/a/26751218/21149029

                    il_Icons.Images.Add(mod.Name, new Bitmap(iconPath));
                    return;
                };

                // "iconPath"\s*:\s*"([^"]+)"
                Regex reg = new Regex(@"""iconPath""\s*:\s*""([^""]+)""");
                // https://chatgpt.com/share/67852cc4-2ce4-8006-aab8-a6bcc0b3c041

                string lunaSettingsPath = mod.FullName + @"\data\config\LunaSettingsConfig.json";
                if (File.Exists(lunaSettingsPath))
                {
                    MatchCollection match = null;
                    using (StreamReader sr = new StreamReader(lunaSettingsPath))
                    {
                        string text = sr.ReadToEnd();
                        match = reg.Matches(text);
                    }
                    if (match == null || match.Count < 1)
                        return;
                    string relativeIconLoc = match[0].Groups[1].Value;

                    iconPath = mod.FullName + @"\" + relativeIconLoc.Replace(@"/", @"\");

                    il_Icons.Images.Add(mod.Name, new Bitmap(iconPath));
                }
            });

            // games own logo
            il_Icons.Images.Add("starsector-core", Properties.Resources.s_icon64);

            IndustriesOLVSetup();

            ConditionsOLVSetup();

            SubmarketsOLVSetup();
        }

        private void IndustriesOLVSetup()
        {

            // add the images of industries to the image list of the listview
            Statics.CSVs.Industries.ForEach(s =>
            {
                try
                {
                    string path = Helper.GetCSVPath(s.owner, s.image);
                    il_IndustryImages.Images.Add(path, new Bitmap(path));
                }
                catch (Exception)
                { // sometimes stuff doesnt exist and crashes
                }
            });

            // image selection function
            olv_Industries_Image.ImageGetter = delegate (object x)
            {
                IndustriesCSV s = x as IndustriesCSV;

                return Helper.GetCSVPath(s.owner, s.image);
            };

            // checkbox controller
            olv_Industries.CheckStatePutter = delegate (Object rowObject, CheckState newValue)
            {
                // update the checkness of the checkbox
                olv_Industries_Enabled.PutCheckState(rowObject, newValue);
                // update the grouping 
                if (!olv_Industries.Groups.Cast<ListViewGroup>().ToList().TrueForAll(k => k.Header != "True" && k.Header != "False"))
                {
                    olv_Industries.BuildGroups(olv_Industries_Enabled, olv_Industries.LastSortOrder);
                }
                // idk what this is for its suppose to update the checkbox but it didnt really worked and idc enough
                return newValue;
            };

            // change default sorter to alphabetical
            olv_Industries.BeforeCreatingGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                e.Parameters.ItemComparer = new AlphabeticalComparer();
            };

            // dont display icons if the grouping is enabled or not
            olv_Industries.AboutToCreateGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                foreach (var item in e.Groups)
                {
                    if (item.Header != "True" && item.Header != "False")
                    {
                        item.TitleImage = item.Header;
                    }
                }
            };

            // reaply filter
            tb_IndustriesFilter.TextChanged += delegate (object sender, EventArgs e)
            {
                olv_Industries.ModelFilter = new ModelFilter(delegate (object x)
                {
                    IndustriesCSV s = x as IndustriesCSV;
                    return Helper.SimilarContains(s.name, tb_IndustriesFilter.Text, 2);
                });
            };

            // finish
            olv_Industries.SetObjects(Statics.CSVs.Industries);
        }

        private void ConditionsOLVSetup()
        {
            // add the images of conditions to the image list of the listview
            Statics.CSVs.MarketConditions.ForEach(s =>
            {
                try
                {
                    string path = Helper.GetCSVPath(s.owner, s.icon);
                    il_ConditionImages.Images.Add(path, new Bitmap(path));
                }
                catch (Exception)
                { // sometimes stuff doesnt exist and crashes
                }
            });

            // image selection function
            olv_Conditions_Image.ImageGetter = delegate (object x)
            {
                MarketConditionsCSV s = x as MarketConditionsCSV;

                return Helper.GetCSVPath(s.owner, s.icon);
            };

            // checkbox controller
            olv_Conditions.CheckStatePutter = delegate (Object rowObject, CheckState newValue)
            {
                // update the checkness of the checkbox
                olv_Conditions_Enabled.PutCheckState(rowObject, newValue);
                // update the grouping 
                if (!olv_Conditions.Groups.Cast<ListViewGroup>().ToList().TrueForAll(k => k.Header != "True" && k.Header != "False"))
                {
                    olv_Conditions.BuildGroups(olv_Conditions_Enabled, olv_Conditions.LastSortOrder);
                }
                // idk what this is for its suppose to update the checkbox but it didnt really worked and idc enough
                return newValue;
            };

            // change default sorter to alphabetical
            olv_Conditions.BeforeCreatingGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                e.Parameters.ItemComparer = new AlphabeticalComparer();
            };

            // dont display icons if the grouping is enabled or not
            olv_Conditions.AboutToCreateGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                foreach (var item in e.Groups)
                {
                    if (item.Header != "True" && item.Header != "False")
                    {
                        item.TitleImage = item.Header;
                    }
                }
            };

            // reaply filter
            tb_ConditionsFilter.TextChanged += delegate (object sender, EventArgs e)
            {
                olv_Conditions.ModelFilter = new ModelFilter(delegate (object x)
                {
                    MarketConditionsCSV s = x as MarketConditionsCSV;
                    return Helper.SimilarContains(s.name, tb_ConditionsFilter.Text, 2);
                });
            };

            // finish
            olv_Conditions.SetObjects(Statics.CSVs.MarketConditions);
        }

        private void SubmarketsOLVSetup()
        {
            // add the images to the image list of the listview
            Statics.CSVs.Submarkets.ForEach(s =>
            {
                try
                {
                    string path = Helper.GetCSVPath(s.owner, s.icon);
                    il_SubmarketImages.Images.Add(path, new Bitmap(path));
                }
                catch (Exception)
                { // sometimes stuff doesnt exist and crashes
                }
            });

            // image selection function
            olv_Submarkets_Image.ImageGetter = delegate (object x)
            {
                SubmarketsCSV s = x as SubmarketsCSV;

                return Helper.GetCSVPath(s.owner, s.icon);
            };

            // checkbox controller
            olv_Submarkets.CheckStatePutter = delegate (Object rowObject, CheckState newValue)
            {
                // update the checkness of the checkbox
                olv_Submarkets_Enabled.PutCheckState(rowObject, newValue);
                // update the grouping 
                if (!olv_Submarkets.Groups.Cast<ListViewGroup>().ToList().TrueForAll(k => k.Header != "True" && k.Header != "False"))
                {
                    olv_Submarkets.BuildGroups(olv_Submarkets_Enabled, olv_Submarkets.LastSortOrder);
                }
                // idk what this is for its suppose to update the checkbox but it didnt really worked and idc enough
                return newValue;
            };

            // change default sorter to alphabetical
            olv_Submarkets.BeforeCreatingGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                e.Parameters.ItemComparer = new AlphabeticalComparer();
            };

            // dont display icons if the grouping is enabled or not
            olv_Submarkets.AboutToCreateGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                foreach (var item in e.Groups)
                {
                    if (item.Header != "True" && item.Header != "False")
                    {
                        item.TitleImage = item.Header;
                    }
                }
            };

            // reaply filter
            tb_SubmarketsFilter.TextChanged += delegate (object sender, EventArgs e)
            {
                olv_Submarkets.ModelFilter = new ModelFilter(delegate (object x)
                {
                    SubmarketsCSV s = x as SubmarketsCSV;
                    return Helper.SimilarContains(s.name, tb_SubmarketsFilter.Text, 2);
                });
            };

            // finish
            olv_Submarkets.SetObjects(Statics.CSVs.Submarkets);
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

        private MarketData GetData()
        {
            MarketData market = new MarketData();

            market.primaryEntity = Helper.IDWithNameToID(ComboBox_PrimaryEntity.SelectedItem.ToString());

            market.systemID = GetSystemID();

            market.ID = tb_ID.Text;

            market.name = tb_Name.Text;

            market.WithJunkAndChatter = cb_MarketWithJunkAndChatter.Checked;

            market.PirateMode = cb_MarketPirateMode.Checked;

            market.size = (byte)nud_MarketSize.Value;

            market.factionID = tb_MarketFactionID.Text;

            market.industries.AddRange(
                Statics.CSVs.Industries
                .Where(industry => industry.enabled == true)
                .Select(s => s.id)
                .ToList()
            );

            market.marketConditions.AddRange(
                Statics.CSVs.MarketConditions
                .Where(condition => condition.enabled == true)
                .Select(s => s.id)
                .ToList()
            );

            market.submarkets.AddRange(
                Statics.CSVs.Submarkets
                .Where(submarket => submarket.enabled == true)
                .Select(s => s.id)
                .ToList()
            );

            market.WhatIsThis = Finals.MARKET;


            return market;
        }

        private StarSystemData GetSystem()
        {
            if (ComboBox_Systems.SelectedItem != null) { return Helper.GetSystemFromID(ComboBox_Systems.SelectedItem.ToString()); }
            return null;
        }

        private string GetSystemID()
        {
            if (ComboBox_Systems.SelectedItem != null) { return ComboBox_Systems.SelectedItem.ToString(); }
            return null;
        }

        private void AddMarket()
        {
            MarketData marketToAdd = GetData();

            if (Helper.DoesIDExists(marketToAdd.ID))
            {
                MessageBox.Show(context + " ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            marketToAdd.systemGUID = GetSystem().GUID;

            ItemEditingAdding.AddMarket(marketToAdd);

            currMarket = marketToAdd;

            Load();

            ComboBox_PrimaryEntity.SelectedItem = currMarket.primaryEntity + " - " + Helper.GetExtendFromID(currMarket.primaryEntity).name;
        }

        private void EditMarket()
        {
            MarketData updatedMarket = GetData();

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

            if (GetSystemID() == null || GetSystemID() == "") { return; }

            ComboBox_PrimaryEntity.Items.Clear();

            ComboBox_PrimaryEntity.Items.AddRange(Helper.IDNameList(Helper.GetOrbitablesInSystem(GetSystemID())).ToArray());
        }

        private void Update(MarketData marketToUpdateFormWith)
        {
            ComboBox_PrimaryEntity.SelectedItem = marketToUpdateFormWith.primaryEntity;

            tb_ID.Text = marketToUpdateFormWith.ID;

            tb_Name.Text = marketToUpdateFormWith.name;

            cb_MarketWithJunkAndChatter.Checked = marketToUpdateFormWith.WithJunkAndChatter;

            cb_MarketPirateMode.Checked = marketToUpdateFormWith.PirateMode;

            nud_MarketSize.Value = marketToUpdateFormWith.size;

            tb_MarketFactionID.Text = marketToUpdateFormWith.factionID;

            olv_Industries.UpdateObjects(Statics.CSVs.Industries);


            Statics.CSVs.Industries.ForEach(industry =>
            {
                if (marketToUpdateFormWith.industries.Contains(industry.id))
                {
                    industry.enabled = true;
                }
            });
            olv_Industries.SetObjects(Statics.CSVs.Industries);
            Statics.CSVs.MarketConditions.ForEach(marketCondition =>
            {
                if (marketToUpdateFormWith.marketConditions.Contains(marketCondition.id))
                {
                    marketCondition.enabled = true;
                }
            });
            olv_Conditions.SetObjects(Statics.CSVs.MarketConditions);
            Statics.CSVs.Submarkets.ForEach(submarket =>
            {
                if (marketToUpdateFormWith.submarkets.Contains(submarket.id))
                {
                    submarket.enabled = true;
                }
            });
            olv_Submarkets.SetObjects(Statics.CSVs.Submarkets);



            //// ok this is gonna be scuffed but i dont care
            //// so to put it shrimply when you filter the items you pmuch foreach them and idk how to foreach them properly so i just use the filter thingg to do that
            //olv_Industries.ModelFilter = new ModelFilter(delegate (object rowObject)
            //{
            //    IndustriesCSV industry = rowObject as IndustriesCSV;
            //    // update the checkness of the checkbox
            //    olv_Industries_Enabled.PutCheckState(rowObject, (industry.enabled == true) ? CheckState.Checked : CheckState.Unchecked);

            //    // since this is a filter we still need to filter it and just putting true/false would be ass
            //    return Helper.SimilarContains(industry.name, tb_IndustriesFilter.Text, 2);
            //});



        }

        private void Reset()
        {
            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_MarketFactionID.Text = "";
            cb_MarketPirateMode.Checked = false;
            cb_MarketWithJunkAndChatter.Checked = false;
            nud_MarketSize.Value = 0;
            Statics.CSVs.Industries.ForEach(s => s.enabled = false);
            Statics.CSVs.MarketConditions.ForEach(s => s.enabled = false);
            Statics.CSVs.Submarkets.ForEach(s => s.enabled = false);
        }

        #endregion

        #region formFunctions

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
                string selectedID = ComboBox_PrimaryEntity.SelectedItem.ToString();
                MarketData market = Helper.GetMarketWithPrimaryEntityID(selectedID);
                Update(market);

                currMarket = market;

                lbl_DoesItHaveMarket.Text = "Haves A Market";
                btn_Market.Text = "Update " + context;
                btn_Delete.Enabled = true;

            }
            else
            {
                lbl_DoesItHaveMarket.Text = "Does Not Have A Market";
                btn_Market.Text = "Add " + context;
                btn_Delete.Enabled = false;
                Reset();
            }

            Enable_AddingEditing_KeyPress(null, null);

        }
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            if (deletedMarketsInThisSessionList.Count() == 0) { return; }

            MarketData lastDeletedItem = deletedMarketsInThisSessionList.ElementAt(deletedMarketsInThisSessionList.Count() - 1);

            if (Helper.DoesIDExists(lastDeletedItem.ID))
            {

                lastDeletedItem.ID += "-SOMETHING_WITH_SAME_ID_EXISTS-" + Guid.NewGuid().ToString();

            }

            Update(lastDeletedItem);

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
            MarketData marketToDelete = Helper.GetMarketWithID(getID());

            deletedMarketsInThisSessionList.Add(marketToDelete);

            ItemEditingAdding.DeleteMarket(marketToDelete);

            Load();

        }
        private void tb_ID_TextChanged(object sender, EventArgs e) { Enable_AddingEditing_KeyPress(null, null); }



        #endregion


    }
}
