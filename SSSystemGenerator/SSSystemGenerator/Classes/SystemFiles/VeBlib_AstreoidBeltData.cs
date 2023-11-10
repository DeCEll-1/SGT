using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class VeBlib_AstreoidBeltData : Extend
    {
        public VeBlib_AstreoidBeltData(String ID, String focus, int numAsteroids, float orbitRadius, float width, float minOrbitDays, float maxOrbitDays, String terrainId, String optionalName)
        {
            this.ID = ID;
            this.focusID = focus;
            this.numAsteroids = numAsteroids;
            this.orbitRadius = orbitRadius;
            this.width = width;
            this.minOrbitDays = minOrbitDays;
            this.maxOrbitDays = maxOrbitDays;
            this.terrainId = terrainId;
            this.optionalName = optionalName;

        }

        public String ID;//this is for identifieing the belt, maybe it will be used, might crash if you dont give it an id, you can do java.util.UUID.randomUUID(); which will give a random string (just do toString), there can be duplicate ones but its pratically ibloppable so dont worry
        //İTS USED İN ORBİTS HOW THE HELL SOMETHİNG CAN ORBİT AROUND SOMETHİNG AAAAAAAAAAAAAAAAAAAAA
        public int numAsteroids;//number of asteroid entities
        public float width;//width of band
        public float minOrbitDays;//minimum and maximum visual orbit speeds of asteroids
        public float maxOrbitDays;
        public String terrainId;//ID of the terrain type that appears in the section above the abilities bar//Terrain.PULSAR_BEAM;//this
        public String optionalName;//display name

    }
}
