using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.CSVClasses
{
    public class CSVs
    {

        public List<IndustriesCSV> Industries { get; set; } = new List<IndustriesCSV>();

        public List<SubmarketsCSV> Submarkets { get; set; } = new List<SubmarketsCSV> { };

        public List<MarketConditionsCSV> MarketConditions { get; set; } = new List<MarketConditionsCSV> { };

    }
}
