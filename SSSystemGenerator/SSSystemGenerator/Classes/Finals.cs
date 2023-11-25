using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Finals
    {

        public const string INDUSTRIES_FILE_NAME = "industries.csv";

        public const string SUBMARKETS_FILE_NAME = "submarkets.csv";

        public const string MARKET_CONDITIONS_FILE_NAME = "market_conditions.csv";

        public const string INDUSTRIES = "INDUSTRIES";
        public const string SUBMARKETS = "SUBMARKETS";
        public const string MARKET_CONDITIONS = "MARKET_CONDITIONS";
        public const string ORBITABLE = "ORBITABLE";

        public const string NOT_FOUND_STRING = "NOT_FOUND_STRING";

        public const string SYSTEM = "SYSTEM";

        public const string STAR = "STAR";

        public const string PLANET = "PLANET";

        public const string CUSTOM_ENTITY = "CUSTOM_ENTITY";

        public const string ASTREOID_BELT = "ASTREOID_BELT";

        public const string RING_BAND = "RING_BAND";

        public static Color MAP_ORBITABLE_BORDER_COLOR = Color.FromArgb(255, 71, 150, 73);//idk why this cant be const

        public static Color MAP_ORBITABLE_FILL_COLOR = Color.FromArgb(255, 71, 100, 73);

        public static Color MAP_GRID_LINE_COLOR = Color.FromArgb(255, 78, 78, 78);



    }
}
