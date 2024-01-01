using SSSystemGenerator.Classes;
using System;
using System.Collections.Generic;
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

            object s = Statics.EXEPath;
            s = Statics.JSONPath;
            s = Statics.ModFolderRoot;
            s = Statics.ModsFolderRoot;
            s = Statics.ModCampaignRoot;
            s = Statics.GameRoot;
            s = Statics.GameCore;
            s = Statics.GameCoreCampaignFolder;
            s = Statics.BaseClass;//for testing
            Statics.SGTBaseMDIContainer = new SGTBaseMDIContainer();
            Application.Run(Statics.SGTBaseMDIContainer);
        }
    }
}
