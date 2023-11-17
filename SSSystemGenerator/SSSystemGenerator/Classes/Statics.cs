using SSSystemGenerator.Classes.CSVClasses;
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

        public static DirectoryInfo EXEPath { get; set; } = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);//mod/SGTExe//exe

        public static DirectoryInfo JSONPath { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\STGSystems.json");

        public static DirectoryInfo ModFolderRoot { get; set; } = EXEPath.Parent;

        public static DirectoryInfo ModsFolderRoot { get; set; } = EXEPath.Parent.Parent;

        public static DirectoryInfo ModCampaignRoot { get; set; } = new DirectoryInfo(ModFolderRoot.FullName + "\\data\\campaign");

        public static DirectoryInfo GameRoot { get; set; } = ModsFolderRoot.Parent;

        public static DirectoryInfo GameCore { get; set; } = new DirectoryInfo(GameRoot.FullName + "\\starsector-core");

        public static DirectoryInfo GameCoreCampaignFolder { get; set; } = new DirectoryInfo(GameCore.FullName + "\\data\\campaign");

        public static List<DirectoryInfo> ModsToRead { get; set; } = new List<DirectoryInfo>();//TODO: add settings and save this thing

        public static BaseClass baseClass { get; set; } = new BaseClass();

        public static CSVs csvs { get; set; } = CSVHelper.GetAllCSVs();

    }
}
