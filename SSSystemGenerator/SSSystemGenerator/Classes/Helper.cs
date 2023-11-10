using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Helper
    {

        public static List<String> SystemListToSystemIDList()
        {

            List<String> result = new List<String>();

            foreach (VeBlib_StarSystemData system in Statics.baseClass.StarSystemDataList)
            {
                result.Add(system.systemID);
            }

            return result;

        }


        //returns null if couldnt find any
        public static VeBlib_StarSystemData GetSystemFromID(String systemID)
        {
            VeBlib_StarSystemData system = null;

            foreach (VeBlib_StarSystemData foreSystem in Statics.baseClass.StarSystemDataList)
            {
                if (foreSystem.systemID == systemID)
                {
                    system = foreSystem;
                    break;
                }
            }

            return system;
        }

    }
}
