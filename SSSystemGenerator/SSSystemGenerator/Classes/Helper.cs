using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Helper
    {

        public static List<String> IDList(List<Extend> list)
        {

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.ID);
            }

            return result;

        }

        public static List<String> IDNameList(List<Extend> list)
        {

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.ID + " - " + item.name);
            }

            return result;

        }

        //returns null if couldnt find any
        public static VeBlib_StarSystemData GetSystemFromGUID(String systemGUID)
        {

            foreach (VeBlib_StarSystemData foreSystem in Statics.baseClass.StarSystemDataList)
            {
                if (foreSystem.GUID == systemGUID)
                {
                    return foreSystem;
                }
            }

            return null;

        }

        //returns null if couldnt find any
        public static VeBlib_StarSystemData GetSystemFromID(String systemID)
        {
            if (systemID.Contains(" - "))
            {
                return GetSystemFromID(IDWithNameToID(systemID));
            }

            VeBlib_StarSystemData system = null;

            foreach (VeBlib_StarSystemData foreSystem in Statics.baseClass.StarSystemDataList)
            {
                if (foreSystem.ID == systemID)
                {
                    system = foreSystem;
                    break;
                }
            }

            return system;
        }

        //returns null if couldnt find any
        public static VeBlib_StarData GetStarOnSystem(String systemID, String starID)
        {
            if (systemID.Contains(" - ") || starID.Contains(" - "))
            {
                return GetStarOnSystem(IDWithNameToID(systemID), IDWithNameToID(starID));
            }

            VeBlib_StarSystemData system = GetSystemFromID(systemID);

            foreach (VeBlib_StarData star in system.starList)
            {
                if (star.ID == starID)
                {
                    return star;
                }
            }

            return null;
        }

        //return null if couldnt find anything
        public static VeBlib_StarData GetStarWithGUID(String GUID)
        {

            foreach (VeBlib_StarSystemData system in Statics.baseClass.StarSystemDataList)//scroll through system list
            {
                foreach (VeBlib_StarData star in system.starList)//scroll through star list
                {
                    if (star.GUID == GUID)//if guid is found return the star
                    {
                        return star;
                    }
                }
            }

            return null;//null if couldnt find anything

        }

        private static String IDWithNameToID(String IDPName)
        {
            //https://www.geeksforgeeks.org/string-split-method-in-c-sharp-with-examples/

            if (!IDPName.Contains(" - ")) return IDPName;



            char[] spearator = { ' ' };
            Int32 count = 2;

            string splittenName = IDPName.Split(spearator, count, StringSplitOptions.None)[0];

            return splittenName;
        }

        public static List<Extend> LitsUpcasting(Object[] listToUpcast)
        {

            List<Extend> upcastedList = new List<Extend>();

            foreach (object item in listToUpcast)
            {
                upcastedList.Add((Extend)item);
            }

            return upcastedList;

        }



        public static void throwCrash(string fileName, string functionName)
        {

            throw new Exception(
                "filename:" + fileName +
                "\nfunctionname:" + functionName +
                "\nping me on corvus or usc with the reproduction way and your system JSON");

        }
    }
}
