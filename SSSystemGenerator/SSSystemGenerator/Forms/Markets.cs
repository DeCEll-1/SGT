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

            Statics.CSVs.Industries.ForEach(s =>
            {
                try
                {
                    string path = Helper.GetCSVPath(s.owner, s.image);
                    // add the images of industries to the image list of the listview
                    il_images.Images.Add(path, new Bitmap(path));
                }
                catch (Exception)
                { // sometimes stuff doesnt exist and crashes
                }
            });

            // add mods to images
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

            // image selection function
            olv_ColumnImage.ImageGetter = delegate (object x)
            {
                IndustriesCSV s = (IndustriesCSV)x;

                return Helper.GetCSVPath(s.owner, s.image);
            };

            // checkbox controller
            olv_Industries.CheckStatePutter = delegate (Object rowObject, CheckState newValue)
            {
                // update the checkness of the checkbox
                olv_ColumnCheckBox.PutCheckState(rowObject, newValue);
                // update the grouping 
                if (!olv_Industries.Groups.Cast<ListViewGroup>().ToList().TrueForAll(k => k.Header != "True" && k.Header != "False"))
                {
                    olv_Industries.BuildGroups(olv_ColumnCheckBox, SortOrder.Descending);
                }
                // idk what this is for its suppose to update the checkbox but it didnt really worked and idc enough
                return newValue;
            };

            // change default sorter to alphabetical
            olv_Industries.BeforeCreatingGroups += delegate (object sender, CreateGroupsEventArgs e)
            {
                e.Parameters.ItemComparer = new AlphabeticalComparer();
            };

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

            // finish
            olv_Industries.SetObjects(Statics.CSVs.Industries);
        }

        private void tb_IndustriesFilter_TextChanged(object sender, EventArgs e)
        {
            // reaply filter
            olv_Industries.ModelFilter = new ModelFilter(delegate (object x)
            {
                IndustriesCSV s = x as IndustriesCSV;

                return Helper.SimilarContains(s.name, tb_IndustriesFilter.Text, 2);
            });
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

        private MarketData getData()
        {
            MarketData market = new MarketData();

            market.primaryEntity = Helper.IDWithNameToID(ComboBox_PrimaryEntity.SelectedItem.ToString());

            market.systemID = getSystemID();

            market.ID = tb_ID.Text;

            market.name = tb_Name.Text;

            market.WithJunkAndChatter = cb_MarketWithJunkAndChatter.Checked;

            market.PirateMode = cb_MarketPirateMode.Checked;

            market.size = (byte)nud_MarketSize.Value;

            market.factionID = tb_MarketFactionID.Text;

            return market;
        }

        private StarSystemData getSystem()
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
            MarketData marketToAdd = getData();

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
            MarketData updatedMarket = getData();

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

        private void update(MarketData marketToUpdateFormWith)
        {
            ComboBox_PrimaryEntity.SelectedItem = marketToUpdateFormWith.primaryEntity;

            tb_ID.Text = marketToUpdateFormWith.ID;

            tb_Name.Text = marketToUpdateFormWith.name;

            cb_MarketWithJunkAndChatter.Checked = marketToUpdateFormWith.WithJunkAndChatter;

            cb_MarketPirateMode.Checked = marketToUpdateFormWith.PirateMode;

            nud_MarketSize.Value = marketToUpdateFormWith.size;

            tb_MarketFactionID.Text = marketToUpdateFormWith.factionID;

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

            MarketData lastDeletedItem = deletedMarketsInThisSessionList.ElementAt(deletedMarketsInThisSessionList.Count() - 1);

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
            MarketData marketToDelete = Helper.GetMarketWithID(getID());

            deletedMarketsInThisSessionList.Add(marketToDelete);

            ItemEditingAdding.DeleteMarket(marketToDelete);

            Load();

        }
        private void tb_ID_TextChanged(object sender, EventArgs e) { Enable_AddingEditing_KeyPress(null, null); }



        #endregion


    }
}
