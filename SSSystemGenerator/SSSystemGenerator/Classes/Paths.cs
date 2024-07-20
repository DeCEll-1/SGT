using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Paths
    {
        public static DirectoryInfo EXEPath { get; set; } = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);//mod/SGTExe//exe

        public static DirectoryInfo JsonMetadataPath { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\SGTSystems.json");

        public static DirectoryInfo SystemsFolder { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\systems");

        public static DirectoryInfo ModFolderRoot { get; set; } = EXEPath.Parent;

        public static DirectoryInfo SSSystemGeneratorRootFolder { get; set; } = new DirectoryInfo(EXEPath.Parent + "\\SSSystemGenerator\\SSSystemGenerator");

        public static DirectoryInfo ModsFolderRoot { get; set; } = EXEPath.Parent.Parent;

        public static DirectoryInfo ModCampaignRoot { get; set; } = new DirectoryInfo(ModFolderRoot.FullName + "\\data\\campaign");

        public static DirectoryInfo GameRoot { get; set; } = ModsFolderRoot.Parent;

        public static DirectoryInfo GameCore { get; set; } = new DirectoryInfo(GameRoot.FullName + "\\starsector-core");

        public static DirectoryInfo GameCoreCampaignFolder { get; set; } = new DirectoryInfo(GameCore.FullName + "\\data\\campaign");

        public static DirectoryInfo SettingsFile { get; set; } = new DirectoryInfo(Environment.SpecialFolder.MyDocuments.ToString() + "\\SGT\\Settings.json");

    }
}
