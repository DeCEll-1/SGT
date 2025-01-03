using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            fileHelper.SetupFiles();
            object s = Paths.EXEPath;
            s = Paths.JsonMetadataPath;
            s = Paths.SGTFolderRoot;
            s = Paths.ModsFolderRoot;
            s = Paths.ModCampaignRoot;
            s = Paths.GameRoot;
            s = Paths.GameCore;
            s = Paths.GameCoreCampaignFolder;
            s = Statics.BaseClass;//for testing
            Statics.SGTBaseMDIContainer = new SGTBaseMDIContainer();
            Application.Run(Statics.SGTBaseMDIContainer);
        }
    }
}
