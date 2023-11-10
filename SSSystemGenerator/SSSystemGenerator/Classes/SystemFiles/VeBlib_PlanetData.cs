using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class VeBlib_PlanetData : Extend
    {

        public VeBlib_PlanetData(String Id, String OrbitFocus, String Name, String TypeId, float angle, float Radius, float orbitRadius, float orbitDays)
        {
            this.Id = Id;
            this.focusID = OrbitFocus;
            this.Name = Name;
            this.typeID = TypeId;
            this.angle = angle;
            this.Radius = Radius;
            this.orbitRadius = orbitRadius;
            this.orbitDays = orbitDays;

        }

        public String Id;
        public String Name;
        public float Radius;

    }
}
