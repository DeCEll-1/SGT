using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.CSVClasses
{
    public class IndustriesCSV
    {

        public string id { get; set; }

        public string name { get; set; }

        [Name("cost mult")]
        public string costMult { get; set; }

        [Name("build time")]
        public string buildTime { get; set; }

        public string income { get; set; }

        public string upkeep { get; set; }

        public string downgrade { get; set; }

        public string upgrade { get; set; }

        public string tags { get; set; }

        public string data { get; set; }

        public string image { get; set; }

        public string plugin { get; set; }

        public string desc { get; set; }

        public string order { get; set; }

        public string disruptDanger { get; set; }



    }
}
