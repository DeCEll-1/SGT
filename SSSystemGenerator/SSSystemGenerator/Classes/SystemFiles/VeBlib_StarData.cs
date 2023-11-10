using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class VeBlib_StarData : Extend
    {

        public VeBlib_StarData(String ID, String typeID, String focusID, float radius, float coronaSize)
        {
            this.ID = ID;
            this.typeID = typeID;
            this.focusID = focusID;
            this.radius = radius;
            this.coronaSize = coronaSize;

        }

        public VeBlib_StarData(String ID, String typeID, String focusID, float radius, float coronaSize, float windBurnLevel, float flareProbability, float crLossMult)
        {
            this.ID = ID;
            this.typeID = typeID;
            this.focusID = focusID;
            this.radius = radius;
            this.coronaSize = coronaSize;
            this.windBurnLevel = windBurnLevel;
            this.flareProbability = flareProbability;
            this.crLossMult = crLossMult;
        }

        public String ID;//unique id
        public float radius;//radius of the star
        public float coronaSize;//size of the covid-1984
        public float windBurnLevel = -1;//idk mayn star things
        public float flareProbability = -1;//idk mayn star things
        public float crLossMult = -1;//how much crd does the thing loss when inside teh corona, probably (give it negative numbers or fake n gay)



    }
}
