using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class ModsToLoadController : List<DirectoryInfo>
    {
        public new void Add(DirectoryInfo item)
        {
            base.Add(item);
            StringCollection collection = new StringCollection();
            this.ForEach(s => { 
                collection.Add(s.FullName);
            });
            Properties.Settings.Default.ModsToLoad = collection;
            Properties.Settings.Default.Save();
        }

        public new void RemoveAll(Predicate<DirectoryInfo> predicate)
        {
            base.RemoveAll(predicate);
            StringCollection collection = new StringCollection();
            this.ForEach(s => {
                collection.Add(s.FullName);
            });
            Properties.Settings.Default.ModsToLoad = collection;
            Properties.Settings.Default.Save();
        }
    }
}
