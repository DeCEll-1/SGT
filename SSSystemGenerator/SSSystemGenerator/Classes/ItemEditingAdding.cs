﻿using SSSystemGenerator.Classes.SystemFiles;
using SSSystemGenerator.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class ItemEditingAdding
    {

        #region misc

        private static void RemoveEmpthyCharacters(Extend extend)
        {
            if (extend.ID.Contains(" "))
            {
                extend.ID = extend.ID.Replace(" ", "");
            }
        }

        private static void MapRefresh()
        {
            if (Statics.Map != null)
            {
                Statics.Map.RefreshPanel();
            }
        }

        #region order

        public static void UpdateLoadOrder()//since i use IDs of stuff for orbits i need to add them in order, this will do it, hopefully
        {
            ResetOrder();

            RefreshAllExtendsOrbitingList();

            foreach (VeBlib_StarSystemData system in Statics.BaseClass.StarSystemDataList)
            {

                //get in system
                //find the core orbit
                //set its load order to 0
                //repeat
                //if you get the same thing skip it and increase load order by 1

                OrderInSystemExtends(system);

            }
        }

        public static void ResetOrder()
        {

            foreach (Extend extend in Helper.GetAllOrbitables())
            {
                extend.order = -1;
            }

        }

        public static void OrderInSystemExtends(VeBlib_StarSystemData system)
        {
            int order = 0;
            foreach (Extend extend in Helper.GetOrbitablesInSystem(system))
            {
                //gets the orbiting thing
                if (string.IsNullOrEmpty(extend.focusID))//this doesnt have a focus, aka a root
                {
                    extend.order = order;//if its a root changes its load order
                    order++;//increases the order
                    order = OrderExtendOrbits(extend, order);//sends root to order its orbiting stuff
                }
            }
        }

        public static int OrderExtendOrbits(Extend extend, int order)
        {
            foreach (string orbitingExtendID in extend.stuffOrbitingAround)//go through whats orbiting around the root
            {

                Extend orbitingExtend = Helper.GetExtendFromID(orbitingExtendID);

                if (orbitingExtend == null) continue;

                if (orbitingExtend.order != -1) continue;

                if (
                    (string.IsNullOrEmpty(orbitingExtend.focusID) || orbitingExtend.focusID == extend.ID) &&//is root / orbiting root
                    orbitingExtend.stuffOrbitingAround.Count != 0//haves stuff orbiting it
                    )//haves an orbit
                {
                    orbitingExtend.order = order;//change the load order of the orbiting thing
                    order++;//increase the order
                    order = OrderExtendOrbits(orbitingExtend, order);//repeat this thing because it haves orbiting bodies

                }
                else if (
                    orbitingExtend.stuffOrbitingAround.Count == 0//the last body thats orbiting something
                    )
                {
                    orbitingExtend.order = order;
                    order++;
                }
            }
            return order;//return the order
        }

        public static void AddExtendToOrbitingList(Extend extend)//you put the thing here and if it orbits anything the thing its orbiting will have this things id in a list, for loading order
        {
            if (string.IsNullOrEmpty(extend.focusID)) return;//doesnt have a focus, load firstly

            Extend focus = Helper.GetExtendFromID(extend.focusID);//get the orbiting body

            if (!focus.stuffOrbitingAround.Contains(extend.ID))//if it doesnt already exist in it
            {
                focus.stuffOrbitingAround.Add(extend.ID);//add this to orbiting body
            }


        }

        public static void RefreshAllExtendsOrbitingList()
        {

            foreach (Extend extend in Helper.GetAllOrbitables())
            {
                AddExtendToOrbitingList(extend);
            }


        }

        #endregion

        private static void UpdateStuffOrbitingAround(List<Extend> listToFindStuffOrbitingAroundIn, Extend oldExtend, Extend newExtend)
        {
            foreach (Extend planetData in listToFindStuffOrbitingAroundIn)
            {

                if (planetData.stuffOrbitingAround.Contains(oldExtend.ID))
                {
                    planetData.stuffOrbitingAround.Remove(oldExtend.ID);

                    planetData.stuffOrbitingAround.Add(newExtend.ID);

                }

            }
        }

        #endregion

        #region system
        public static void AddSystem(VeBlib_StarSystemData systemToAdd)//add the system
        {
            RemoveEmpthyCharacters(systemToAdd);

            systemToAdd.GUID = Guid.NewGuid().ToString();//add the guid for later editing

            Statics.BaseClass.StarSystemDataList.Add(systemToAdd);
        }


        public static void UpdateSystem(VeBlib_StarSystemData newSystem)//update the system
        {

            RemoveEmpthyCharacters(newSystem);

            VeBlib_StarSystemData systemToRemove = Helper.GetSystemFromGUID(newSystem.GUID);//get the system thatll get removed by using the new systems guid

            if (systemToRemove == null)
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateSystem");

            }



            Statics.BaseClass.StarSystemDataList.Remove(systemToRemove);//remove system

            Statics.BaseClass.StarSystemDataList.Add(newSystem);//add system

        }
        #endregion

        #region star
        public static void AddStar(VeBlib_StarData star)//add star
        {
            RemoveEmpthyCharacters(star);

            star.GUID = Guid.NewGuid().ToString();//add the guid for later editing

            //add the star to the system 
            string systemID = star.systemID;//get system id

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);//get system from id

            if (system == null)//if couldnt find system then crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "AddStar");
            }

            system.starList.Add(star);//add star to system

            UpdateLoadOrder();

            MapRefresh();
        }

        public static void UpdateStar(VeBlib_StarData newStar)
        {
            RemoveEmpthyCharacters(newStar);

            VeBlib_StarData oldStar = Helper.GetStarWithGUID(newStar.GUID);//get old star with stars guid

            if (oldStar == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateStar");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newStar.systemID);//get the star system 


            system.starList.Remove(oldStar);//remove the old star

            system.starList.Add(newStar);//add the new star

            UpdateLoadOrder();

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
            RemoveEmpthyCharacters(planet);

            planet.GUID = Guid.NewGuid().ToString();//guid for later editing

            string systemID = planet.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.planetList.Add(planet);

            UpdateLoadOrder();


            MapRefresh();
        }

        public static void UpdatePlanet(VeBlib_PlanetData newPlanet)
        {
            RemoveEmpthyCharacters(newPlanet);

            VeBlib_PlanetData oldPlanet = Helper.GetPlanetWithGUID(newPlanet.GUID);

            if (oldPlanet == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdatePlanet");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newPlanet.systemID);//get the system

            UpdateStuffOrbitingAround(Helper.ListUpcasting(system.planetList.ToArray()), oldPlanet, newPlanet);

            system.planetList.Remove(oldPlanet);

            system.planetList.Add(newPlanet);

            UpdateLoadOrder();

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
            RemoveEmpthyCharacters(market);

            market.GUID = Guid.NewGuid().ToString();

            string systemID = market.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.marketList.Add(market);

        }

        public static void UpdateMarket(VeBlib_MarketData marketToUpdate)
        {
            RemoveEmpthyCharacters(marketToUpdate);

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
            RemoveEmpthyCharacters(customEntity);

            customEntity.GUID = Guid.NewGuid().ToString();

            string systemID = customEntity.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);


            system.sectorEntityTokenList.Add(customEntity);

            UpdateLoadOrder();

            MapRefresh();
        }

        public static void UpdateCustomEntity(VeBlib_SectorEntittyTokenData newEntity)
        {
            RemoveEmpthyCharacters(newEntity);

            VeBlib_SectorEntittyTokenData oldEntity = Helper.GetCustomEntityWithGUID(newEntity.GUID);

            if (oldEntity == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateCustomEntity");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newEntity.systemID);



            system.sectorEntityTokenList.Remove(oldEntity);

            system.sectorEntityTokenList.Add(newEntity);

            UpdateLoadOrder();

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
            RemoveEmpthyCharacters(ringBandToAdd);

            ringBandToAdd.GUID = Guid.NewGuid().ToString();

            ringBandToAdd.x = Helper.GetExtendFromID(ringBandToAdd.focusID).x;
            ringBandToAdd.y = Helper.GetExtendFromID(ringBandToAdd.focusID).y;

            string systemID = ringBandToAdd.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.ringBandDataList.Add(ringBandToAdd);

            UpdateLoadOrder();

            MapRefresh();
        }

        public static void UpdateRingBand(VeBlib_RingBandData newRingBand)
        {
            RemoveEmpthyCharacters(newRingBand);

            VeBlib_RingBandData oldRingBand = Helper.GetRingBandWithGUID(newRingBand.GUID);//get old star with stars guid

            if (oldRingBand == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateStar");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newRingBand.systemID);//get the star system 

            //newRingBand.x = Helper.GetExtendFromID(newRingBand.focusID).x;
            //newRingBand.y = Helper.GetExtendFromID(newRingBand.focusID).y;

            newRingBand.x = Helper.GetLocationOfFocus(Helper.GetExtendFromID(newRingBand.focusID)).X;
            newRingBand.y = Helper.GetLocationOfFocus(Helper.GetExtendFromID(newRingBand.focusID)).Y;

            system.ringBandDataList.Remove(oldRingBand);//remove the old star

            system.ringBandDataList.Add(newRingBand);//add the new star

            UpdateLoadOrder();

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
            RemoveEmpthyCharacters(astreoidBeltToAdd);

            astreoidBeltToAdd.GUID = Guid.NewGuid().ToString();

            astreoidBeltToAdd.x = Helper.GetExtendFromID(astreoidBeltToAdd.focusID).x;
            astreoidBeltToAdd.y = Helper.GetExtendFromID(astreoidBeltToAdd.focusID).y;

            string systemID = astreoidBeltToAdd.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.astreoidBeltDataList.Add(astreoidBeltToAdd);

            UpdateLoadOrder();

            MapRefresh();
        }

        public static void UpdateAstreoidBelt(VeBlib_AstreoidBeltData newAstreoidBelt)
        {
            RemoveEmpthyCharacters(newAstreoidBelt);

            VeBlib_AstreoidBeltData oldAstreoidBelt = Helper.GetAstreoidBeltWithGUID(newAstreoidBelt.GUID);//get old star with stars guid

            if (oldAstreoidBelt == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.ThrowCrash("ItemEditingAdding.cs", "UpdateAstreoidBelt");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newAstreoidBelt.systemID);//get the star system 

            newAstreoidBelt.x = Helper.GetLocationOfFocus(Helper.GetExtendFromID(newAstreoidBelt.focusID)).X;
            newAstreoidBelt.y = Helper.GetLocationOfFocus(Helper.GetExtendFromID(newAstreoidBelt.focusID)).Y;

            system.astreoidBeltDataList.Remove(oldAstreoidBelt);//remove the old star

            system.astreoidBeltDataList.Add(newAstreoidBelt);//add the new star

            UpdateLoadOrder();

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
