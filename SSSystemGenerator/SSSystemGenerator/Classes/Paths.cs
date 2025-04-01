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
        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\SGTExe
        /// </summary>
        //public static DirectoryInfo EXEPath { get; set; } = new DirectoryInfo("D:\\Game Files\\Fractal Softworks\\0.97a-RC11\\mods\\SGT\\SGTExe");
        public static DirectoryInfo EXEPath { get; set; } = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\data\strings\SGTSystems.json
        /// </summary>
        public static DirectoryInfo JsonMetadataPath { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\SGTSystems.json");

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\data\strings\systems
        /// </summary>
        public static DirectoryInfo SystemsFolder { get; set; } = new DirectoryInfo(EXEPath.Parent.FullName + "\\data\\strings\\systems");

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT
        /// </summary>
        public static DirectoryInfo SGTFolderRoot { get; set; } = EXEPath.Parent;

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\SSSystemGenerator\SSSystemGenerator
        /// </summary>
        public static DirectoryInfo SSSystemGeneratorRootFolder { get; set; } = new DirectoryInfo(EXEPath.Parent + "\\SSSystemGenerator\\SSSystemGenerator");

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods
        /// </summary>
        public static DirectoryInfo ModsFolderRoot { get; set; } = EXEPath.Parent.Parent;

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\mods\SGT\data\campaign
        /// </summary>
        public static DirectoryInfo ModCampaignRoot { get; set; } = new DirectoryInfo(SGTFolderRoot.FullName + "\\data\\campaign");

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11
        /// </summary>
        public static DirectoryInfo GameRoot { get; set; } = ModsFolderRoot.Parent;

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\starsector-core
        /// </summary>
        public static DirectoryInfo GameCore { get; set; } = new DirectoryInfo(GameRoot.FullName + "\\starsector-core");

        /// <summary>
        /// D:\Game Files\Fractal Softworks\0.97a-RC11\starsector-core\data\campaign
        /// </summary>
        public static DirectoryInfo GameCoreCampaignFolder { get; set; } = new DirectoryInfo(GameCore.FullName + "\\data\\campaign");

       // public static DirectoryInfo SettingsFile { get; set; } = new DirectoryInfo(Environment.SpecialFolder.MyDocuments.ToString() + "\\SGT\\Settings.json");

    }
}
