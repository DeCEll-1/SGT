using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Statics
    {

        public static String EXEPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        public static String JSONPath { get; set; } = EXEPath + "data\\strings\\STGSystems.json";

        public static BaseClass baseClass { get; set; } = new BaseClass();

    }
}
