using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.CSVClasses
{
    public class PlanetGenData
    {
        [CsvHelper.Configuration.Attributes.Ignore]
        public string owner { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string category { get; set; }
        public string frequency { get; set; }
        public string habOffsetMin { get; set; }
        public string habOffsetMax { get; set; }
        public string habOffsetYOUNG { get; set; }
        public string habOffsetAVERAGE { get; set; }
        public string habOffsetOLD { get; set; }
        public string tags { get; set; }
        public string probOrbits { get; set; }
        public string minOrbits { get; set; }
        public string maxOrbits { get; set; }
        public string minRadius { get; set; }
        public string maxRadius { get; set; }
        public string minColor { get; set; }
        public string maxColor { get; set; }
        public string YOUNG { get; set; }
        public string AVERAGE { get; set; }
        public string OLD { get; set; }
        public string star_orange_giant { get; set; }
        public string star_red_giant { get; set; }
        public string star_red_supergiant { get; set; }
        public string star_red_dwarf { get; set; }
        public string star_orange { get; set; }
        public string star_yellow { get; set; }
        public string star_browndwarf { get; set; }
        public string star_white { get; set; }
        public string star_blue_giant { get; set; }
        public string star_blue_supergiant { get; set; }
        public string star_neutron { get; set; }
        public string black_hole { get; set; }
        public string binary { get; set; }
        public string trinary { get; set; }
        public string cat_giant { get; set; }
        public string cat_frozen { get; set; }
        public string cat_cryovolcanic { get; set; }
        public string cat_hab1 { get; set; }
        public string cat_hab2 { get; set; }
        public string cat_hab3 { get; set; }
        public string cat_hab4 { get; set; }
        public string cat_hab5 { get; set; }
        public string cat_barren { get; set; }
        public string cat_toxic { get; set; }
        public string lagrange { get; set; }
        public string in_asteroids { get; set; }
        public string is_moon { get; set; }

    }
}
