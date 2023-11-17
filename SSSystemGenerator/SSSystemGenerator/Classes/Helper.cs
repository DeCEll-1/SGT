using SSSystemGenerator.Classes.CSVClasses;
using SSSystemGenerator.Classes.SystemFiles;
using SSSystemGenerator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Helper
    {

        #region extend list to string list for combo boxes and such

        ///<summary>
        ///same as IDNameList but without ids
        ///</summary>
        public static List<String> NameList(List<Extend> list)
        {

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.name);
            }

            return result;

        }

        ///<summary>
        ///same as IDNameList but without names
        ///</summary>
        public static List<String> IDList(List<Extend> list)
        {

            List<String> result = new List<String>();

            foreach (Extend item in list)
            {
                result.Add(item.ID);
            }

            return result;

        }

        ///<summary>
        ///turns extend items to a list of id + names, for lists
        ///</summary>
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

        public static Boolean DoesIDExists(string IDToCheck)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())
            {

                if (IDToCheck == system.ID)
                {
                    return true;
                }

                foreach (var item in system.starList)
                {
                    if (IDToCheck == item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.planetList)
                {
                    if (IDToCheck == item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.astreoidBeltDataList)
                {
                    if (IDToCheck == item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.ringBandDataList)
                {
                    if (IDToCheck == item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.sectorEntityTokenList)
                {
                    if (IDToCheck == item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.marketList)
                {
                    if (IDToCheck == item.ID)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        /// <summary>
        /// excludes the second id, for updates and stuff
        /// </summary>
        /// <param name="IDToCheck"></param>
        /// <param name="IDToExclude"></param>
        /// <returns></returns>
        public static Boolean DoesIDExists(string IDToCheck, string IDToExclude)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())
            {

                if (IDToCheck == system.ID && IDToExclude != system.ID)
                {
                    return true;
                }

                foreach (var item in system.starList)
                {
                    if (IDToCheck == item.ID && IDToExclude != item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.planetList)
                {
                    if (IDToCheck == item.ID && IDToExclude != item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.astreoidBeltDataList)
                {
                    if (IDToCheck == item.ID && IDToExclude != item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.ringBandDataList)
                {
                    if (IDToCheck == item.ID && IDToExclude != item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.sectorEntityTokenList)
                {
                    if (IDToCheck == item.ID && IDToExclude != item.ID)
                    {
                        return true;
                    }
                }

                foreach (var item in system.marketList)
                {
                    if (IDToCheck == item.ID && IDToExclude != item.ID)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        /// <summary>
        /// gets all orbitables
        /// </summary>
        /// <returns></returns>
        public static List<Extend> GetAllOrbitables()
        {

            List<Extend> extendList = new List<Extend>();

            foreach (VeBlib_StarSystemData system in GetAllSystems())
            {

                extendList.AddRange(GetOrbitablesInSystem(system.ID).ToArray());

            }

            return extendList;

        }

        /// <summary>
        /// gets Extend from id
        /// </summary>
        /// <param name="extendID"></param>
        /// <returns></returns>
        public static Extend GetExtendFromID(string extendID)
        {

            foreach (Extend item in GetAllOrbitables())
            {

                if (item.ID == extendID)
                {
                    return item;
                }

            }

            return null;

        }

        #endregion

        #region systems

        ///<summary>
        ///gets all systems
        ///</summary>
        public static List<VeBlib_StarSystemData> GetAllSystems()
        {
            return Statics.baseClass.StarSystemDataList;
        }

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
        public static VeBlib_StarSystemData GetSystemFromGUID(String systemGUID)
        {

            foreach (VeBlib_StarSystemData foreSystem in GetAllSystems())
            {
                if (foreSystem.GUID == systemGUID)
                {
                    return foreSystem;
                }
            }

            return null;

        }

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
        public static VeBlib_StarSystemData GetSystemFromID(String systemID)
        {

            if (systemID == null) { return null; }

            if (systemID.Contains(" - "))
            {
                return GetSystemFromID(IDWithNameToID(systemID));
            }

            foreach (VeBlib_StarSystemData foreSystem in GetAllSystems())
            {
                if (foreSystem.ID == systemID)
                {
                    return foreSystem;
                }
            }

            return null;
        }

        ///<summary>
        ///gets orbitables on the system and exclude connected entities on the market
        ///</summary>
        public static List<Extend> GetOrbitablesInSystem(VeBlib_StarSystemData system, VeBlib_MarketData market)
        {
            return GetOrbitablesInSystem(system.ID, market);
        }

        ///<summary>
        ///gets orbitables on the system
        ///</summary>
        public static List<Extend> GetOrbitablesInSystem(VeBlib_StarSystemData system)
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

            foreach (var item in system.sectorEntityTokenList)
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

            return list;

        }

        ///<summary>
        ///gets orbitables on the system
        ///</summary>
        public static List<Extend> GetOrbitablesInSystem(string systemID)
        {

            if (systemID == null) { return null; }

            VeBlib_StarSystemData system = GetSystemFromID(systemID);

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

        ///<summary>
        ///gets orbitables on the system and exclude connected entities on the market
        ///</summary>
        public static List<Extend> GetOrbitablesInSystem(string systemID, VeBlib_MarketData market)
        {
            VeBlib_StarSystemData system = GetSystemFromID(systemID);

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

            List<Extend> stuffToRemove = new List<Extend>();

            foreach (Extend item in list)
            {
                if (market.connectedEntities.Contains(item.ID))
                {
                    stuffToRemove.Add(item);
                }
            }

            foreach (Extend item in stuffToRemove)
            {
                list.Remove(item);
            }

            return list;

        }

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
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


        #endregion

        #region stars

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_StarData GetStarWithGUID(String GUID)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
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

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_StarData GetStarWithID(String ID)
        {

            if (ID.Contains(" - "))
            {
                return GetStarWithID(IDWithNameToID(ID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_StarData star in system.starList)//scroll through star list
                {
                    if (star.ID == ID)//if guid is found return the star
                    {
                        return star;
                    }
                }
            }

            return null;//null if couldnt find anything

        }

        public static Boolean DoesStarIDExist(string IDToCheck)
        {
            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_StarData star in system.starList)//scroll through star list
                {
                    if (star.ID == IDToCheck)//if ID is found
                    {
                        return true;//star exists
                    }
                }
            }

            return false;//couldnt find anything
        }

        ///<summary>
        ///it excludes the second starID, for update checks
        ///</summary>
        public static Boolean DoesStarIDExist(string IDToCheck, string starIDToExclude)
        {
            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_StarData star in system.starList)//scroll through star list
                {
                    if (star.ID == IDToCheck)//if ID is found
                    {

                        if (star.ID == starIDToExclude)//theyre the same so skip it
                        {
                            continue;
                        }

                        return true;//star exists
                    }
                }
            }

            return false;//couldnt find anything
        }

        #endregion

        #region planets

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
        public static VeBlib_PlanetData GetPlanetOnSystem(String systemID, String planetID)
        {
            if (systemID.Contains(" - ") || planetID.Contains(" - "))
            {
                return GetPlanetOnSystem(IDWithNameToID(systemID), IDWithNameToID(planetID));
            }

            VeBlib_StarSystemData system = GetSystemFromID(systemID);

            foreach (VeBlib_PlanetData planet in system.planetList)
            {
                if (planet.ID == planetID)
                {
                    return planet;
                }
            }

            return null;
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_PlanetData GetPlanetWithGUID(string GUID)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_PlanetData planet in system.planetList)//scroll through planet list
                {
                    if (planet.GUID == GUID)//if guid is found return the planet
                    {
                        return planet;
                    }
                }
            }

            return null;//null if couldnt find anything

        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_PlanetData GetPlanetWithID(string ID)
        {

            if (ID.Contains(" - "))
            {
                return GetPlanetWithID(IDWithNameToID(ID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_PlanetData planet in system.planetList)//scroll through planet list
                {
                    if (planet.ID == ID)//if id is found return the planet
                    {
                        return planet;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        #endregion

        #region Markets

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_MarketData GetMarketWithGUID(String GUID)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_MarketData market in system.marketList)//scroll through planet list
                {
                    if (market.GUID == GUID)//if guid is found return the planet
                    {
                        return market;
                    }
                }
            }

            return null;//null if couldnt find anything

        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_MarketData GetMarketWithID(string ID)
        {

            if (ID.Contains(" - "))
            {
                return GetMarketWithID(IDWithNameToID(ID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_MarketData market in system.marketList)//scroll through market list
                {
                    if (market.ID == ID)//if id is found return the planet
                    {
                        return market;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_MarketData GetMarketWithPrimaryEntityID(string ID)
        {

            if (ID.Contains(" - "))
            {
                return GetMarketWithPrimaryEntityID(IDWithNameToID(ID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_MarketData market in system.marketList)//scroll through market list
                {
                    if (market.primaryEntity == ID)//if id is found return the market
                    {
                        return market;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        #endregion


        #region misc

        public static CSVs GetCSV()
        {
            return Statics.csvs;
        }

        public static void UpdateCSV()
        {
            Statics.csvs = CSVHelper.GetAllCSVs();
        }

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

        public static void ThrowCrash(string fileName, string functionName)
        {

            throw new Exception(
                "filename:" + fileName +
                "\nfunctionname:" + functionName +
                "\nping me on corvus or usc with the reproduction way and your system JSON");

        }

        public static string WhatTypeIsThisIDIs(string unknownID)
        {
            CSVs csv = GetCSV();


            foreach (Extend extends in GetAllOrbitables())
            {
                if (extends.ID == unknownID)
                {
                    return Finals.ORBITABLE;
                }
            }

            foreach (IndustriesCSV industries in csv.Industries)
            {
                if (industries.id == unknownID)
                {
                    return Finals.INDUSTRIES;
                }
            }

            foreach (SubmarketsCSV submarkets in csv.Submarkets)
            {
                if (submarkets.id == unknownID)
                {
                    return Finals.SUBMARKETS;
                }
            }

            foreach (MarketConditions condition in csv.MarketConditions)
            {
                if (condition.id == unknownID)
                {
                    return Finals.MARKET_CONDITIONS;
                }
            }

            return Finals.NOT_FOUND_STRING;

        }

        #endregion
    }
}
