using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class SettingsController
    {
        public static ColorMode ColorMode
        {
            get { return (ColorMode)Properties.Settings.Default.ColorMode; }
            set { Properties.Settings.Default.ColorMode = (int)value; }
        }

        public static Boolean DebugMode
        {
            get
            {
                return Properties.Settings.Default.DebugMode;
            }
            set
            {
                Properties.Settings.Default.DebugMode = value;
            }
        }

        public static ModsToLoadController ModsToLoad
        {
            get
            {
                StringCollection collection = Properties.Settings.Default.ModsToLoad;
                ModsToLoadController list = new ModsToLoadController();
                if (collection == null)
                    return new ModsToLoadController();
                foreach (string path in collection)
                {
                    list.Add(new DirectoryInfo(path));
                }
                return list;
            }
            set
            {
                StringCollection collection = new StringCollection();
                value.ForEach(s =>
                {
                    collection.Add(s.FullName);
                });
                Properties.Settings.Default.ModsToLoad = collection;
                Properties.Settings.Default.Save();
            }
        }
    }
    public enum ColorMode
    {
        LIGHT,
        DARK
    }
}
