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

        // D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\data\strings\SGTSystems.json
        public static DirectoryInfo JsonMetadataPath { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\SGTSystems.json");

        // D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\data\strings\systems
        public static DirectoryInfo SystemsFolder { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\systems");

        // D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT
        public static DirectoryInfo ModFolderRoot { get; set; } = EXEPath.Parent;

        // D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\SSSystemGenerator\SSSystemGenerator
        public static DirectoryInfo SSSystemGeneratorRootFolder { get; set; } = new DirectoryInfo(EXEPath.Parent + "\\SSSystemGenerator\\SSSystemGenerator");

        public static DirectoryInfo ModsFolderRoot { get; set; } = EXEPath.Parent.Parent;

        // D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\data\campaign
        public static DirectoryInfo ModCampaignRoot { get; set; } = new DirectoryInfo(ModFolderRoot.FullName + "\\data\\campaign");

        // D:\Game Files\Fractal Softworks\0.97a-RC11
        public static DirectoryInfo GameRoot { get; set; } = ModsFolderRoot.Parent;

        // D:\Game Files\Fractal Softworks\0.97a-RC11\starsector-core
        public static DirectoryInfo GameCore { get; set; } = new DirectoryInfo(GameRoot.FullName + "\\starsector-core");

        // D:\Game Files\Fractal Softworks\0.97a-RC11\starsector-core\data\campaign
        public static DirectoryInfo GameCoreCampaignFolder { get; set; } = new DirectoryInfo(GameCore.FullName + "\\data\\campaign");

        public static DirectoryInfo SettingsFile { get; set; } = new DirectoryInfo(Environment.SpecialFolder.MyDocuments.ToString() + "\\SGT\\Settings.json");

    }
}
