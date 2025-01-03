using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Settings
    {

        //true is for light false is for dark
        public static Boolean ColorMode { get; set; } = true;//TODO: add settings for this

        public static Boolean DebugMode { get; set; } = false;//TODO: add settings for this

        public static List<DirectoryInfo> ModsToLoad { get; set; } = new List<DirectoryInfo>();//TODO: add settings and save this thing

    }
}
