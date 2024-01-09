using SSSystemGenerator.Classes.CSVClasses;
using SSSystemGenerator.Classes.SystemFiles;
using SSSystemGenerator.Forms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (extendID == null) return new Extend();

            if (extendID.Contains(" - "))
            {
                return GetExtendFromID(IDWithNameToID(extendID));
            }

            foreach (Extend item in GetAllOrbitables())
            {

                if (item.ID == extendID)
                {
                    return item;
                }

            }

            return null;

        }

        /// <summary>
        /// gets orbitable from id
        /// </summary>
        /// <param name="extendID"></param>
        /// <returns></returns>
        public static Extend GetOrbitableFromID(string orbitableID)
        {
            return GetExtendFromID(orbitableID);
        }

        public static Extend SSCoordinatesToPanelCoordinates(Extend extend, int resizeValue)
        {
            Extend adjustedExtend = new Extend();



            adjustedExtend.x = extend.x / resizeValue;
            adjustedExtend.y = extend.y / resizeValue;
            adjustedExtend.radius = extend.radius / resizeValue;
            adjustedExtend.width = extend.width / resizeValue;
            adjustedExtend.orbitRadius = extend.orbitRadius / resizeValue;
            adjustedExtend.bandWidthInEngine = extend.bandWidthInEngine / 10;

            return adjustedExtend;


        }

        public static PointF SSPointToPanelPoint(PointF coordinate, int resizeValue)
        {
            return new PointF(coordinate.X / resizeValue, coordinate.Y / resizeValue);
        }

        public static PointF GetLocationOfFocus(Extend extend)
        {
            //problem: the focus doesnt have location values
            //return: the location values of the focus
            //how to find them:
            /*
             * 1: get the focus of the focus
             * 2: get the point on circumfrence
             * 2.1: 
             * 3: return that
             */

            if (extend == null) return new PointF(0, 0);

            if (String.IsNullOrEmpty(extend.focusID) )
            {
                return new PointF(extend.x, extend.y);
            }

            Extend focusOfExtend = Helper.GetExtendFromID(extend.focusID);



            PointF theLocationOfTheFocus = new PointF();

            if (focusOfExtend.focusID != null)
            {
                PointF s = Helper.GetLocationOfFocus(focusOfExtend);
                //so this does work for orbits of orbits of orbits but idk why, if you know math - unlike me - please let me know how this works
                return Helper.GetPointOnCircumference(
                       new PointF(
                           s.X,
                           s.Y
                        ),
                        extend.angle,
                        extend.orbitRadius
                    );
            }

            theLocationOfTheFocus = Helper.GetPointOnCircumference(
                       new PointF(
                           focusOfExtend.x,
                           focusOfExtend.y
                        ),
                        extend.angle,
                        extend.orbitRadius
                    );

            return theLocationOfTheFocus;
            //idk math
        }

        #endregion

        #region systems

        ///<summary>
        ///gets all systems
        ///</summary>
        public static List<VeBlib_StarSystemData> GetAllSystems()
        {
            return Statics.BaseClass.StarSystemDataList;
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

        #region CustomEntity

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
        public static VeBlib_SectorEntittyTokenData GetCustomEntityInSystem(String systemID, String customEntityID)
        {
            if (systemID.Contains(" - ") || customEntityID.Contains(" - "))
            {
                return GetCustomEntityInSystem(IDWithNameToID(systemID), IDWithNameToID(customEntityID));
            }

            VeBlib_StarSystemData system = GetSystemFromID(systemID);

            foreach (VeBlib_SectorEntittyTokenData customEntity in system.sectorEntityTokenList)
            {
                if (customEntity.ID == customEntityID)
                {
                    return customEntity;
                }
            }

            return null;
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_SectorEntittyTokenData GetCustomEntityWithGUID(String GUID)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_SectorEntittyTokenData customEntity in system.sectorEntityTokenList)//scroll through planet list
                {
                    if (customEntity.GUID == GUID)//if guid is found return the planet
                    {
                        return customEntity;
                    }
                }
            }

            return null;//null if couldnt find anything

        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_SectorEntittyTokenData GetEntityFromID(string ID)
        {

            if (ID.Contains(" - "))
            {
                return GetEntityFromID(IDWithNameToID(ID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_SectorEntittyTokenData customEntity in system.sectorEntityTokenList)//scroll through planet list
                {
                    if (customEntity.ID == ID)//if id is found return the planet
                    {
                        return customEntity;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        #endregion

        #region ringBelts

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
        public static VeBlib_RingBandData GetRingBandInSystem(String systemID, String ringBandID)
        {
            if (systemID.Contains(" - ") || ringBandID.Contains(" - "))
            {
                return GetRingBandInSystem(IDWithNameToID(systemID), IDWithNameToID(ringBandID));
            }

            VeBlib_StarSystemData system = GetSystemFromID(systemID);

            foreach (VeBlib_RingBandData ringBand in system.ringBandDataList)
            {
                if (ringBand.ID == ringBandID)
                {
                    return ringBand;
                }
            }

            return null;
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_RingBandData GetRingBandWithID(string GUID)
        {

            if (GUID.Contains(" - "))
            {
                return GetRingBandWithID(IDWithNameToID(GUID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_RingBandData ringBand in system.ringBandDataList)//scroll through planet list
                {
                    if (ringBand.ID == GUID)//if id is found return the planet
                    {
                        return ringBand;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_RingBandData GetRingBandWithGUID(string GUID)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_RingBandData ringBand in system.ringBandDataList)//scroll through planet list
                {
                    if (ringBand.GUID == GUID)//if guid is found return the planet
                    {
                        return ringBand;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        #endregion

        #region astreoidBelts

        ///<summary>
        ///returns null if couldnt find any
        ///</summary>
        public static VeBlib_AstreoidBeltData GetAstreoidBeltInSystem(String systemID, String astreoidBeltID)
        {
            if (systemID.Contains(" - ") || astreoidBeltID.Contains(" - "))
            {
                return GetAstreoidBeltInSystem(IDWithNameToID(systemID), IDWithNameToID(astreoidBeltID));
            }

            VeBlib_StarSystemData system = GetSystemFromID(systemID);

            foreach (VeBlib_AstreoidBeltData astreoidBelt in system.astreoidBeltDataList)
            {
                if (astreoidBelt.ID == astreoidBeltID)
                {
                    return astreoidBelt;
                }
            }

            return null;
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_AstreoidBeltData GetAstreoidBeltWithID(string GUID)
        {

            if (GUID.Contains(" - "))
            {
                return GetAstreoidBeltWithID(IDWithNameToID(GUID));
            }

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_AstreoidBeltData astreoidBelt in system.astreoidBeltDataList)//scroll through planet list
                {
                    if (astreoidBelt.ID == GUID)//if id is found return the planet
                    {
                        return astreoidBelt;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        ///<summary>
        ///return null if couldnt find anything
        ///</summary>
        public static VeBlib_AstreoidBeltData GetAstreoidBeltWithGUID(string GUID)
        {

            foreach (VeBlib_StarSystemData system in GetAllSystems())//scroll through system list
            {
                foreach (VeBlib_AstreoidBeltData astreoidBelt in system.astreoidBeltDataList)//scroll through planet list
                {
                    if (astreoidBelt.GUID == GUID)//if guid is found return the planet
                    {
                        return astreoidBelt;
                    }
                }
            }

            return null;//null if couldnt find anything
        }

        #endregion

        #region misc

        public static bool IsSaving()
        {
            return JsonHelper.saving;
        }

        public static CSVs GetCSV()
        {
            return Statics.CSVs;
        }

        public static void UpdateCSV()
        {
            Statics.CSVs = CSVHelper.GetAllCSVs();
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

        public static PointF GetPointOnCircumference(PointF center, float angle, float distance)
        {
            //https://stackoverflow.com/questions/14096138/find-the-point-on-a-circle-with-given-center-point-radius-and-degree

            //problem: 
            /*
             90 = 270
             45 = 305
             etc
             */
            //solution:
            //multiply angle with -1

            angle *= -1;

            float x_oncircle = (float)(center.X + distance * Math.Cos(angle * (Math.PI / 180f)));
            float y_oncircle = (float)(center.Y + distance * Math.Sin(angle * (Math.PI / 180f)));

            return new PointF(x_oncircle, y_oncircle);
        }

        public static PointF SubtractCoordinates(PointF toSubtractFrom, PointF subtract)
        {
            toSubtractFrom.X -= subtract.X;
            toSubtractFrom.Y -= subtract.Y;

            return toSubtractFrom;
        }

        public static PointF CombineCoordinates(PointF toAddTo, PointF subtract)
        {
            toAddTo.X += subtract.X;
            toAddTo.Y += subtract.Y;

            return toAddTo;
        }

        public static Map GetMap() { return Statics.Map; }
        public static SGTBaseMDIContainer GetMDIContainer() { return Statics.SGTBaseMDIContainer; }

        //TODO: get this on a seperate file
        #region Colors 

        public static void ChangeColorMode(Control.ControlCollection container)
        {


            UpdateComponentColors(container.Owner);

            foreach (Control component in container)
            {

                //if (!component.Enabled) continue;



                DrawBorderToComplonent(component);

                //HoverColorEventSetup(component);

                UpdateComponentColors(component);

                if (component is MenuStrip)
                {
                    ChangeColorMode((component as MenuStrip).Items);
                }

                if (component.Controls.Count != 0)
                {
                    ChangeColorMode(component.Controls);

                    continue;
                }


            }



        }

        private static void UpdateComponentColors(Control component)
        {
            ////https://stackoverflow.com/a/19315175 // remove it before adding so you dont add it multiple times
            //component.EnabledChanged -= EnabledColorUpdateEvent;
            //component.EnabledChanged += EnabledColorUpdateEvent;//except it doesnt work

            bool wasDisabled = false;

            if (component is Button && !component.Enabled)
            {
                if (!Settings.ColorMode)//Dark mode
                {
                    return;
                }

            }

            //if (!component.Enabled)
            //{//https://stackoverflow.com/a/46100278
            //    wasDisabled = true;
            //    component.Enabled = true;
            //}

            if (component.Name.Contains("Refresh") || component.Name.Contains("Undo"))
            {
                component.BackgroundImage = RefreshButton();
            }
            if (component.Name.Contains("Clone"))
            {
                component.BackgroundImage = CloneButton();
            }

            //component.EnabledChanged -= EnabledColorUpdateEvent;
            //component.EnabledChanged += EnabledColorUpdateEvent;

            //if (!component.Enabled) return;



            foreach (var borderlessControl in borderlessControls)
            {
                if (component.GetType() == borderlessControl.GetType() || component.GetType().GetInterface("IFormInterface") != null)
                {
                    component.BackColor = FormBackground();
                    component.ForeColor = FormText();

                    //if (wasDisabled) component.Enabled = false;
                    return;
                }
            }

            component.BackColor = Background();
            component.ForeColor = Text();

            //if (wasDisabled) component.Enabled = false;

        }

        private static void EnabledColorUpdateEvent(object sender, System.EventArgs eventArgs)
        {
            Control senderControl = (Control)sender;
            UpdateComponentColors(senderControl);

            DrawBorderToComplonent(senderControl);
        }

        #region Border

        private static void DrawBorderToComplonent(Control component)
        {

            component.Paint += Component_Paint;

            component.Refresh();

            component.Paint -= Component_Paint;

        }

        private static void Component_Paint(object sender, PaintEventArgs e)
        {//https://stackoverflow.com/a/59478243

            foreach (var borderlessControl in borderlessControls)
            {
                if (sender.GetType() == borderlessControl.GetType())
                {
                    return;
                }
            }

            int borderWidth = 6;
            ButtonBorderStyle borderStyle = ButtonBorderStyle.Solid;
            if (Settings.ColorMode)//light mode
            {
                e.Graphics.Clear(Colors.LIGHT_MODE_BG);
                var borderColor = Colors.LIGHT_MODE_BORDER;
                //https://stackoverflow.com/questions/2200974/controlpaint-drawborder-but-thicker

                ControlPaint.DrawBorder(
                                    e.Graphics,
                                    e.ClipRectangle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle
                                    );
            }
            else//dark mode
            {
                e.Graphics.Clear(Colors.DARK_MODE_BG);
                var borderColor = Colors.DARK_MODE_BORDER;



                ControlPaint.DrawBorder(
                                    e.Graphics,
                                    e.ClipRectangle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle,
                                    borderColor,
                                    borderWidth,
                                    borderStyle
                                    );
            }

        }

        #endregion

        #region ToolStrip

        private static void ChangeColorMode(ToolStripItemCollection TSICollection)
        {
            foreach (ToolStripItem TSI in TSICollection)
            {

                UpdateToolStripColors(TSI);

                if (TSI is ToolStripMenuItem)
                {
                    //HoverColorEventSetup(TSI);
                    ChangeColorMode((TSI as ToolStripMenuItem).DropDownItems);

                }

            }
        }

        private static void UpdateToolStripColors(ToolStripItem toolStripItem)
        {
            if (!toolStripItem.Enabled) return;

            toolStripItem.BackColor = FormBackground();
            toolStripItem.ForeColor = FormText();

        }

        #endregion

        #region Hover // obsolete, doesnt work/makes everything shet itself

        [ObsoleteAttribute]
        private static void HoverColorEventSetup(Control component)
        {//https://stackoverflow.com/questions/37777688/c-sharp-how-to-change-menustrip-hover-color
         //draw stuff when mouse entered and reset when leaved

            component.MouseEnter -= Hover_MouseEnter_Control;
            component.MouseEnter += Hover_MouseEnter_Control;//enter

            component.MouseLeave -= Hover_MouseLeave_Control;
            component.MouseLeave += Hover_MouseLeave_Control;//leave

            component.Paint -= Hover_Paint_Control;
            component.Paint += Hover_Paint_Control;//paint
        }

        [ObsoleteAttribute]
        private static void HoverColorEventSetup(ToolStripItem TSI)
        {//https://stackoverflow.com/questions/37777688/c-sharp-how-to-change-menustrip-hover-color
            //draw stuff when mouse entered and reset when leaved

            TSI.MouseEnter -= Hover_MouseEnter_TSI;
            TSI.MouseEnter += Hover_MouseEnter_TSI;//enter

            TSI.MouseLeave -= Hover_MouseLeave_TSI;
            TSI.MouseLeave += Hover_MouseLeave_TSI;//leave

            TSI.Paint -= Hover_Paint_Control;
            TSI.Paint += Hover_Paint_Control;//paint
        }

        [ObsoleteAttribute]
        private static void Hover_MouseEnter_Control(object sender, EventArgs e) { (sender as Control).Refresh(); }

        [ObsoleteAttribute]
        private static void Hover_MouseLeave_Control(object sender, EventArgs e) { (sender as Control).Refresh(); }

        [ObsoleteAttribute]
        private static void Hover_MouseEnter_TSI(object sender, EventArgs e) { (sender as ToolStripItem).Invalidate(); }

        [ObsoleteAttribute]
        private static void Hover_MouseLeave_TSI(object sender, EventArgs e) { (sender as ToolStripItem).Invalidate(); }

        [ObsoleteAttribute]
        private static void Hover_Paint_Control(object sender, PaintEventArgs e)
        {
            if (sender == null || (sender as Control) == null) return;

            using (sender as Control)
            {
                e.Graphics.FillRectangle(new SolidBrush((sender as Control).BackColor), (sender as Control).Bounds);
            }
        }

        [ObsoleteAttribute]
        private static void Hover_PaintTSI(object sender, PaintEventArgs e)
        {
            if (sender == null || (sender as Control) == null) return;

            using (sender as Control)
            {
                e.Graphics.FillRectangle(new SolidBrush((sender as Control).BackColor), (sender as Control).Bounds);
            }
        }

        #endregion

        #region returnColors

        public static Color Text()
        {
            if (Settings.ColorMode)//lightMode
            { return Colors.LIGHT_MODE_FG; }
            else
            { return Colors.DARK_MODE_FG; }
        }

        public static Color Background()
        {
            if (Settings.ColorMode)//lightMode
            { return Colors.LIGHT_MODE_BG; }
            else
            { return Colors.DARK_MODE_BG; }
        }

        public static Color FormText()
        {
            if (Settings.ColorMode)//lightMode
            //{ return Colors.LIGHT_MODE_FORM_FG; }
            { return Form.DefaultForeColor; }
            else
            { return Colors.DARK_MODE_FORM_FG; }
        }

        public static Color FormBackground()
        {
            if (Settings.ColorMode)//lightMode
            //{ return Colors.LIGHT_MODE_FORM_BG; }
            { return Form.DefaultBackColor; }
            else
            { return Colors.DARK_MODE_FORM_BG; }
        }

        public static Color Border()
        {
            if (Settings.ColorMode)//lightMode
            { return Colors.LIGHT_MODE_BORDER; }
            else
            { return Colors.DARK_MODE_BORDER; }
        }

        public static Bitmap RefreshButton()
        {
            if (Settings.ColorMode)//lightMode
            { return Colors.LIGHT_MODE_REFRESH_IMAGE; }
            else
            { return Colors.DARK_MODE_REFRESH_IMAGE; }
        }

        public static Bitmap CloneButton()//make those generalised
        {
            if (Settings.ColorMode)//lightMode
            { return Colors.LIGHT_MODE_CLONE_IMAGE; }
            else
            { return Colors.DARK_MODE_CLONE_IMAGE; }
        }

        public static Color Hover()
        {
            if (Settings.ColorMode)//lightMode
            { return Colors.LIGHT_MODE_HOVER_COLOR; }
            else
            { return Colors.DARK_MODE_HOVER_COLOR; }
        }

        #endregion

        #region ComboBox // not used because the coloring works on flat and this makes it look like flat anyways

        [ObsoleteAttribute]
        private static void ChangeColorOfDropBoxes(Component component)
        {
            if (component is ComboBox)
            {
                (component as ComboBox).DrawItem += ComboBox_DrawItem;
                (component as ComboBox).Refresh();
                (component as ComboBox).DrawItem -= ComboBox_DrawItem;
            }
        }

        [ObsoleteAttribute]
        private static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {//https://stackoverflow.com/a/60421006/21149029

            ComboBox comboBox = (sender as ComboBox);

            int index = e.Index >= 0 ? e.Index : -1;
            Brush brush = ((e.State & DrawItemState.Selected) > 0) ? SystemBrushes.HighlightText : new SolidBrush(comboBox.ForeColor);
            e.DrawBackground();
            if (index != -1)
            {
                e.Graphics.DrawString(comboBox.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        #endregion

        #region borderlessControls // also stuff that takes form background

        private static List<Control> borderlessControls = new List<Control>()
        {
            new Label(),
            new Button(),
            new GroupBox(),
            new Panel(),
            new Form(),
        };

        #endregion

        #endregion

        #endregion

        #region obsolete



        #endregion
    }
}
