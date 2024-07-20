using SSSystemGenerator.Classes.CSVClasses;
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


        public const string Version = "0" + "." + "0" + "." + "2";

        public static List<DirectoryInfo> ModsToRead { get; set; } = new List<DirectoryInfo>();//TODO: add settings and save this thing

        public static BaseClass BaseClass { get; set; } = new BaseClass();

        public static CSVs CSVs { get; set; } = CSVHelper.GetAllCSVs();



        public static Map Map { get; set; } = null;
        public static SGTBaseMDIContainer SGTBaseMDIContainer { get; set; } = null;

        public static bool CloseTheForm = false;//for saving

    }
}
