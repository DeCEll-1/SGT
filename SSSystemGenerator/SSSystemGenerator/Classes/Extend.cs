﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class Extend
    {


        public int order { get; set; } = -1;


        public String GUID { get; set; }

        public String ID { get; set; }
        public String name { get; set; }

        public float radius { get; set; }

        #region stolen from classes for map purposes
        public float bandWidthInEngine = 0; //ring band

        public float width = 0;//astreoid belt
        #endregion


        public string systemID { get; set; }
        public string systemGUID { get; set; }

        public float x { get; set; }
        public float y { get; set; }

        public String focusID { get; set; }//"" for center
        public List<string> stuffOrbitingAround { get; set; } = new List<string>();
        public String typeID { get; set; }

        public String WhatIsThis { get; set; }

        public float angle { get; set; }
        public float orbitRadius { get; set; }
        public float orbitDays { get; set; }
        public float minSpin { get; set; }
        public float maxSpin { get; set; }
        public int orbitLocationMode { get; set; }
        //0 = setFixedLocation; only needs x and y other than neccessary stuff.
        //1 = setCircularOrbit; needs focusID;angle;orbitRadius;orbitDays;
        //2 = setCircularOrbitPointingDown; same as 1
        //3 = setCircularOrbitWithSpin; same as 1/2 just with minSpin  maxSpin additions

    }
}
