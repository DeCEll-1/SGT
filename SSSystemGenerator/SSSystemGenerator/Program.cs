﻿using SSSystemGenerator.Classes;
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

            fileHelper.setupFiles();//generate the data/strings/STGSystems.json

            Application.Run(new SGTBaseMDIContainer());
        }
    }
}
