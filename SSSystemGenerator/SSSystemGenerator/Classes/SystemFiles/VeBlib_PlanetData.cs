using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class VeBlib_PlanetData : Extend
    {

        public VeBlib_PlanetData()
        {

        }

        public VeBlib_PlanetData(String ID, String OrbitFocus, String name, String TypeId, float angle, float radius, float orbitRadius, float orbitDays)
        {
            this.ID = ID;
            this.focusID = OrbitFocus;
            this.name = name;
            this.typeID = TypeId;
            this.angle = angle;
            this.radius = radius;
            this.orbitRadius = orbitRadius;
            this.orbitDays = orbitDays;

        }


    }
}
