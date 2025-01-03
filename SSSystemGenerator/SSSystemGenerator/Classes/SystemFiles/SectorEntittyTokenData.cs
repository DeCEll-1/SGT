﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class SectorEntittyTokenData : Extend
    {

        public SectorEntittyTokenData()
        {
            this.ID = "";
            this.name = "";
            this.customEntittyType = "";
            this.factionID = "";
        }

        public SectorEntittyTokenData(String ID, String name, String customEntittyType, String factionID, float x, float y)
        {
            this.ID = ID;
            this.name = name;
            this.customEntittyType = customEntittyType;
            this.factionID = factionID;
            this.x = x;
            this.y = y;
            this.orbitLocationMode = 0;
        }

        public SectorEntittyTokenData(String ID, String name, String customEntittyType, String factionID, String focusID, float angle, float orbitRadius, float orbitDays, bool setCircularOrbitPointingDown)
        {
            this.ID = ID;
            this.name = name;
            this.customEntittyType = customEntittyType;
            this.factionID = factionID;
            this.focusID = focusID;
            this.angle = angle;
            this.orbitRadius = orbitRadius;
            this.orbitDays = orbitDays;
            if (setCircularOrbitPointingDown) this.orbitLocationMode = 2;
            else this.orbitLocationMode = 1;
        }

        public SectorEntittyTokenData(String ID, String name, String customEntittyType, String factionID, String focusID, float angle, float orbitRadius, float orbitDays, float minSpin, float maxSpin)
        {
            this.ID = ID;
            this.name = name;
            this.customEntittyType = customEntittyType;
            this.factionID = factionID;
            this.focusID = focusID;
            this.angle = angle;
            this.orbitRadius = orbitRadius;
            this.orbitDays = orbitDays;
            this.minSpin = minSpin;
            this.maxSpin = maxSpin;
            this.orbitLocationMode = 3;
        }

        public String customEntittyType;//neccessary
        public String factionID;//neccessary

    }
}
