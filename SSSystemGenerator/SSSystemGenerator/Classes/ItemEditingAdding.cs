using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class ItemEditingAdding
    {

        private static void MapRefresh() { Statics.Map.RefreshPanel(); }

        #region system
        public static void AddSystem(VeBlib_StarSystemData systemToAdd)//add the system
        {

            systemToAdd.GUID = Guid.NewGuid().ToString();//add the guid for later editing

            Statics.baseClass.StarSystemDataList.Add(systemToAdd);
        }


        public static void UpdateSystem(VeBlib_StarSystemData newSystem)//update the system
        {

            VeBlib_StarSystemData systemToRemove = Helper.GetSystemFromGUID(newSystem.GUID);//get the system thatll get removed by using the new systems guid

            if (systemToRemove == null)
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateSystem");

            }



            Statics.baseClass.StarSystemDataList.Remove(systemToRemove);//remove system

            Statics.baseClass.StarSystemDataList.Add(newSystem);//add system

        }
        #endregion

        #region star
        public static void AddStar(VeBlib_StarData star)//add star
        {
            star.GUID = Guid.NewGuid().ToString();//add the guid for later editing

            //add the star to the system 
            string systemID = star.systemID;//get system id

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);//get system from id

            if (system == null)//if couldnt find system then crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "AddStar");
            }

            system.starList.Add(star);//add star to system

            MapRefresh();
        }

        public static void UpdateStar(VeBlib_StarData newStar)
        {
            //we have our star
            //that cant have its system changed


            VeBlib_StarData oldStar = Helper.GetStarWithGUID(newStar.GUID);//get old star with stars guid

            if (oldStar == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateStar");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newStar.systemID);//get the star system 


            system.starList.Remove(oldStar);//remove the old star

            system.starList.Add(newStar);//add the new star

            MapRefresh();
        }

        /// <summary>
        /// removes star from its system
        /// </summary>
        /// <param name="starToDelete"></param>
        public static void DeleteStar(VeBlib_StarData starToDelete)
        {
            Helper.GetSystemFromGUID(starToDelete.systemGUID).starList.Remove(starToDelete);

            MapRefresh();
        }

        #endregion

        #region planet

        public static void AddPlanet(VeBlib_PlanetData planet)
        {

            planet.GUID = Guid.NewGuid().ToString();//guid for later editing

            string systemID = planet.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.planetList.Add(planet);

            MapRefresh();
        }

        public static void UpdatePlanet(VeBlib_PlanetData newPlanet)
        {
            VeBlib_PlanetData oldPlanet = Helper.GetPlanetWithGUID(newPlanet.GUID);

            if (oldPlanet == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdatePlanet");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newPlanet.systemID);//get the system

            system.planetList.Remove(oldPlanet);

            system.planetList.Add(newPlanet);

            MapRefresh();
        }

        public static void DeletePlanet(VeBlib_PlanetData planetToDelete)
        {
            Helper.GetSystemFromGUID(planetToDelete.systemGUID).planetList.Remove(planetToDelete);

            MapRefresh();
        }

        #endregion

        #region market

        public static void AddMarket(VeBlib_MarketData market)
        {
            market.GUID = Guid.NewGuid().ToString();

            string systemID = market.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.marketList.Add(market);

        }

        public static void UpdateMarket(VeBlib_MarketData marketToUpdate)
        {
            VeBlib_MarketData oldMarket = Helper.GetMarketWithGUID(marketToUpdate.GUID);

            if (oldMarket == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateMarket");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(marketToUpdate.systemID);

            system.marketList.Remove(oldMarket);

            system.marketList.Add(marketToUpdate);
        }

        public static void DeleteMarket(VeBlib_MarketData marketToDelete)
        {
            Helper.GetSystemFromGUID(marketToDelete.systemGUID).marketList.Remove(marketToDelete);
        }

        #endregion

        #region customEntity

        public static void AddCustomEntity(VeBlib_SectorEntittyTokenData customEntity)
        {
            customEntity.GUID = Guid.NewGuid().ToString();

            string systemID = customEntity.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.sectorEntityTokenList.Add(customEntity);

            MapRefresh();
        }

        public static void UpdateCustomEntity(VeBlib_SectorEntittyTokenData customEntityToUpdate)
        {
            VeBlib_SectorEntittyTokenData oldEntity = Helper.GetCustomEntityWithGUID(customEntityToUpdate.GUID);

            if (oldEntity == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateCustomEntity");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(customEntityToUpdate.systemID);

            system.sectorEntityTokenList.Remove(oldEntity);

            system.sectorEntityTokenList.Add(customEntityToUpdate);

            MapRefresh();
        }

        public static void DeleteCustomEntity(VeBlib_SectorEntittyTokenData customEntityToDelete)
        {
            Helper.GetSystemFromGUID(customEntityToDelete.systemGUID).sectorEntityTokenList.Remove(customEntityToDelete);

            MapRefresh();
        }

        #endregion

        #region ringBand

        public static void AddRingBand(VeBlib_RingBandData ringBandToAdd)
        {
            ringBandToAdd.GUID = Guid.NewGuid().ToString();

            ringBandToAdd.x = Helper.GetExtendFromID(ringBandToAdd.focusID).x;
            ringBandToAdd.y = Helper.GetExtendFromID(ringBandToAdd.focusID).y;

            string systemID = ringBandToAdd.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.ringBandDataList.Add(ringBandToAdd);

            MapRefresh();
        }

        public static void UpdateRingBand(VeBlib_RingBandData newRingBand)
        {
            VeBlib_RingBandData oldRingBand = Helper.GetRingBandWithGUID(newRingBand.GUID);//get old star with stars guid

            if (oldRingBand == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateStar");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newRingBand.systemID);//get the star system 

            newRingBand.x = Helper.GetExtendFromID(newRingBand.focusID).x;
            newRingBand.y = Helper.GetExtendFromID(newRingBand.focusID).y;

            system.ringBandDataList.Remove(oldRingBand);//remove the old star

            system.ringBandDataList.Add(newRingBand);//add the new star

            MapRefresh();
        }

        public static void DeleteRingBand(VeBlib_RingBandData ringBandTodlete)
        {
            Helper.GetSystemFromGUID(ringBandTodlete.systemGUID).ringBandDataList.Remove(ringBandTodlete);

            MapRefresh();
        }

        #endregion

        #region astreoidBelt

        public static void AddAstreoidBelt(VeBlib_AstreoidBeltData astreoidBeltToAdd)
        {
            astreoidBeltToAdd.GUID = Guid.NewGuid().ToString();

            astreoidBeltToAdd.x = Helper.GetExtendFromID(astreoidBeltToAdd.focusID).x;
            astreoidBeltToAdd.y = Helper.GetExtendFromID(astreoidBeltToAdd.focusID).y;

            string systemID = astreoidBeltToAdd.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.astreoidBeltDataList.Add(astreoidBeltToAdd);

            MapRefresh();
        }

        public static void UpdateAstreoidBelt(VeBlib_AstreoidBeltData newAstreoidBelt)
        {
            VeBlib_AstreoidBeltData oldAstreoidBelt = Helper.GetAstreoidBeltWithGUID(newAstreoidBelt.GUID);//get old star with stars guid

            if (oldAstreoidBelt == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateAstreoidBelt");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newAstreoidBelt.systemID);//get the star system 

            newAstreoidBelt.x = Helper.GetExtendFromID(newAstreoidBelt.focusID).x;
            newAstreoidBelt.y = Helper.GetExtendFromID(newAstreoidBelt.focusID).y;

            system.astreoidBeltDataList.Remove(oldAstreoidBelt);//remove the old star

            system.astreoidBeltDataList.Add(newAstreoidBelt);//add the new star

            MapRefresh();
        }

        public static void DeleteAstreoidBelt(VeBlib_AstreoidBeltData astreoidBeltToDelete)
        {
            Helper.GetSystemFromGUID(astreoidBeltToDelete.systemGUID).astreoidBeltDataList.Remove(astreoidBeltToDelete);

            MapRefresh();
        }

        #endregion

    }
}
