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
                Helper.throwCrash("ItemEditingAdding.cs", "UpdateSystem");

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
                Helper.throwCrash("ItemEditingAdding.cs", "AddStar");
            }

            system.starList.Add(star);//add star to system

        }

        public static void UpdateStar(VeBlib_StarData newStar)
        {
            //we have our star
            //that cant have its system changed


            VeBlib_StarData oldStar = Helper.GetStarWithGUID(newStar.GUID);//get old star with stars guid

            if (oldStar == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.throwCrash("ItemEditingAdding.cs", "UpdateStar");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newStar.systemID);//get the star system 


            system.starList.Remove(oldStar);//remove the old star

            system.starList.Add(newStar);//add the new star

        }

        /// <summary>
        /// removes star from its system
        /// </summary>
        /// <param name="starToDelete"></param>
        public static void DeleteStar(VeBlib_StarData starToDelete)
        {

            Helper.GetSystemFromGUID(starToDelete.systemGUID).starList.Remove(starToDelete);

        }

        #endregion

        #region planet

        public static void AddPlanet(VeBlib_PlanetData planet)
        {

            planet.GUID = Guid.NewGuid().ToString();//guid for later editing

            string systemID = planet.systemID;

            VeBlib_StarSystemData system = Helper.GetSystemFromID(systemID);

            system.planetList.Add(planet);


        }

        public static void UpdatePlanet(VeBlib_PlanetData newPlanet)
        {
            VeBlib_PlanetData oldPlanet = Helper.GetPlanetWithGUID(newPlanet.GUID);

            if (oldPlanet == null)//if couldnt find old star the crash, i cant be fucked to make this work when its null i am already having smoothbrain
            {
                Helper.throwCrash("ItemEditingAdding.cs", "UpdatePlanet");
            }

            VeBlib_StarSystemData system = Helper.GetSystemFromID(newPlanet.systemID);//get the system

            system.planetList.Remove(oldPlanet);

            system.planetList.Add(newPlanet);
        }

        public static void DeletePlanet(VeBlib_PlanetData planetToDelete)
        {
            Helper.GetSystemFromGUID(planetToDelete.systemGUID).planetList.Remove(planetToDelete);

        }

        #endregion

    }
}
