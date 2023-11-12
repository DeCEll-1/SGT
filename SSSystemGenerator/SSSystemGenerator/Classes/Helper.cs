﻿using SSSystemGenerator.Classes.SystemFiles;
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

        #region extend list to string list for combo boxes and such

        //same as IDNameList but without ids
        public static List<String> NameList(List<Extend> list)
        {

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.name);
            }

            return result;

        }

        //same as IDNameList but without names
        public static List<String> IDList(List<Extend> list)
        {

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.ID);
            }

            return result;

        }

        //turns extend items to a list of id + names, for lists
        public static List<String> IDNameList(List<Extend> list)
        {

            if (list == null) return null;

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.ID + " - " + item.name);
            }

            return result;

        }

        #endregion

        #region systems

        //gets all systems
        public static List<VeBlib_StarSystemData> GetAllSystems()
        {
            return Statics.baseClass.StarSystemDataList;
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

        //gets orbitables on the system
        public static List<Extend> getOrbitablesInSystem(VeBlib_StarSystemData system)
        {
            if (system == null) return null;

            List<Extend> list = new List<Extend>();

            foreach (var item in system.starList)
            {
                list.Add(item);
            }

            foreach (var item in system.planetList)
            {
                list.Add(item);
            }

            foreach (var item in system.astreoidBeltDataList)
            {
                list.Add(item);
            }

            foreach (var item in system.ringBandDataList)
            {
                list.Add(item);
            }

            foreach (var item in system.sectorEntityTokenList)
            {
                list.Add(item);
            }

            return list;

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

        //returns true if system exists
        public static Boolean DoesSystemIDExists(string ID)
        {
            foreach (var system in GetAllSystems())
            {
                if (system.ID == ID)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region stars

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

        public static Boolean DoesStarIDExist(string ID)
        {
            foreach (VeBlib_StarSystemData system in Statics.baseClass.StarSystemDataList)//scroll through system list
            {
                foreach (VeBlib_StarData star in system.starList)//scroll through star list
                {
                    if (star.ID == ID)//if ID is found
                    {
                        return true;//star exists
                    }
                }
            }

            return false;//couldnt find anything
        }

        #endregion

        #region misc

        public static String IDWithNameToID(String IDPName)
        {
            //https://www.geeksforgeeks.org/string-split-method-in-c-sharp-with-examples/

            if (!IDPName.Contains(" - ")) return IDPName;


            char[] spearator = { ' ' };
            Int32 count = 2;

            string splittenName = IDPName.Split(spearator, count, StringSplitOptions.None)[0];

            return splittenName;
        }

        public static List<Extend> ListUpcasting(Object[] listToUpcast)
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

        #endregion
    }
}
