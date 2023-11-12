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

            VeBlib_StarSystemData starSystem = Helper.GetSystemFromID(newStar.systemID);//get the star system 


            starSystem.starList.Remove(oldStar);//remove the old star

            starSystem.starList.Add(newStar);//add the new star

        }
        #endregion

    }
}
