﻿using SSSystemGenerator.Classes.CSVClasses;
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

namespace SSSystemGenerator.Forms.SettingsForm
{
    public partial class CSVProperties : Form, IFormInterface
    {
        public void UpdateColors() { ColorManager.ChangeColorMode(this.Controls); }
        private List<IndustriesCSV> industries = new List<IndustriesCSV>();
        private List<MarketConditionsCSV> conditions = new List<MarketConditionsCSV>();
        private List<SubmarketsCSV> submarkets = new List<SubmarketsCSV>();
        private readonly List<PlanetGenData> planetGenDatas = new List<PlanetGenData>();

        public CSVProperties(List<IndustriesCSV> industries, List<MarketConditionsCSV> conditions, List<SubmarketsCSV> submarkets, List<PlanetGenData> planetGenDatas)
        {
            InitializeComponent();
            UpdateColors();
            this.industries = industries;
            this.conditions = conditions;
            this.submarkets = submarkets;
            this.planetGenDatas = planetGenDatas;

            lb_Industries.Items.Add("Industries");
            lb_Industries.Items.AddRange(IndustriesList());
            lb_Conditions.Items.Add("Conditions");
            lb_Conditions.Items.AddRange(ConditionsList());
            lb_Submarkets.Items.Add("Submarkets");
            lb_Submarkets.Items.AddRange(SubmarketsList());
            lb_PlanetTypes.Items.Add("Planet ids, types, categories");
            lb_PlanetTypes.Items.AddRange(PlanetTypeList());

            CSVProperties_ResizeEnd(null, null);
        }

        private string[] IndustriesList()
        {
            string[] result = new string[industries.Count];

            for (int i = 0; i < industries.Count; i++)
            {
                result[i] = industries[i].id + " - " + industries[i].name;
            }

            return result;
        }
        private string[] ConditionsList()
        {
            string[] result = new string[conditions.Count];

            for (int i = 0; i < conditions.Count; i++)
            {
                result[i] = conditions[i].id + " - " + conditions[i].name;
            }

            return result;
        }
        private string[] SubmarketsList()
        {
            string[] result = new string[submarkets.Count];

            for (int i = 0; i < submarkets.Count; i++)
            {
                result[i] = submarkets[i].id + " - " + submarkets[i].name;
            }

            return result;
        }
        private string[] PlanetTypeList()
        {
            string[] result = new string[planetGenDatas.Count];

            for (int i = 0; i < planetGenDatas.Count; i++)
            {
                result[i] = planetGenDatas[i].id + " - " + planetGenDatas[i].type + " - " + planetGenDatas[i].category;
            }

            return result;
        }

        private void CSVProperties_ResizeEnd(object sender, EventArgs e)
        {
            pnl_top.Size = new Size(this.Size.Width, this.Size.Height / 2);
            lb_Industries.Size = new Size(this.Size.Width / 3, lb_Industries.Height);
            lb_Conditions.Size = new Size(this.Size.Width / 3, lb_Conditions.Height);
            lb_Submarkets.Size = new Size(this.Size.Width / 3, lb_Submarkets.Height);
         
            pnl_bottom.Size = new Size(this.Size.Width, this.Size.Height / 2);
            lb_PlanetTypes.Size = new Size(this.Size.Width / 3, lb_PlanetTypes.Height);
        }

        private void CSVProperties_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private FormWindowState state = FormWindowState.Normal;
        private void CSVProperties_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || (state == FormWindowState.Maximized && this.WindowState == FormWindowState.Normal))
            {
                CSVProperties_ResizeEnd(sender, e);
            }
            state = this.WindowState;
        }


    }
}
