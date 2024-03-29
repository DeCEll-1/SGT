﻿using SSSystemGenerator.Classes.CSVClasses;
using SSSystemGenerator.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Statics
    {

        #region Paths
        public static DirectoryInfo EXEPath { get; set; } = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);//mod/SGTExe//exe

        public static DirectoryInfo JSONPath { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\SGTSystems.json");

        public static DirectoryInfo ModFolderRoot { get; set; } = EXEPath.Parent;

        public static DirectoryInfo SSSystemGeneratorRootFolder { get; set; } = new DirectoryInfo(EXEPath.Parent + "\\SSSystemGenerator\\SSSystemGenerator");

        public static DirectoryInfo ModsFolderRoot { get; set; } = EXEPath.Parent.Parent;

        public static DirectoryInfo ModCampaignRoot { get; set; } = new DirectoryInfo(ModFolderRoot.FullName + "\\data\\campaign");

        public static DirectoryInfo GameRoot { get; set; } = ModsFolderRoot.Parent;

        public static DirectoryInfo GameCore { get; set; } = new DirectoryInfo(GameRoot.FullName + "\\starsector-core");

        public static DirectoryInfo GameCoreCampaignFolder { get; set; } = new DirectoryInfo(GameCore.FullName + "\\data\\campaign");

        public static DirectoryInfo SettingsFile { get; set; } = new DirectoryInfo(Environment.SpecialFolder.MyDocuments.ToString() + "\\SGT\\Settings.json");

        #endregion

        public const string Version = "0" + "." + "0" + "." + "2";

        public static List<DirectoryInfo> ModsToRead { get; set; } = new List<DirectoryInfo>();//TODO: add settings and save this thing

        public static BaseClass BaseClass { get; set; } = new BaseClass();

        public static CSVs CSVs { get; set; } = CSVHelper.GetAllCSVs();



        public static Map Map { get; set; } = null;
        public static SGTBaseMDIContainer SGTBaseMDIContainer { get; set; } = null;

        public static bool CloseTheForm = false;//for saving

    }
}
