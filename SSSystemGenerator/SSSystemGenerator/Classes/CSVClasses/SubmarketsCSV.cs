using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.CSVClasses
{
    public class SubmarketsCSV
    {
        [CsvHelper.Configuration.Attributes.Ignore]
        public string owner { get; set; }
        [CsvHelper.Configuration.Attributes.Ignore]
        public bool enabled { get; set; } // for list view
        public string id { get; set; }

        public string name { get; set; }

        public string faction { get; set; }

        public string desc { get; set; }

        public string script { get; set; }

        public string icon { get; set; }

        public string order { get; set; }

    }
}
