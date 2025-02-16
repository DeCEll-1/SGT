package DeCell.SGT.SystemGeneration.systemFiles;

import DeCell.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.PlanetAPI;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.util.HashMap;

public class StarData extends SGTExtend {

    //region overloads
    public StarData() {
        this.ID = "";
        this.typeID = "";
        this.focusID = "";
        this.radius = 0;
        this.coronaSize = 0;

    }

    public StarData(String ID, String typeID, String focusID, float radius, float coronaSize) {
        this.ID = ID;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;

    }

    public StarData(String ID, String typeID, String focusID, float radius, float coronaSize, float windBurnLevel, float flareProbability, float crLossMult) {
        this.ID = ID;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;
        this.windBurnLevel = windBurnLevel;
        this.flareProbability = flareProbability;
        this.crLossMult = crLossMult;
    }

    public StarData(String ID, String name, String typeID, String focusID, float radius, float coronaSize) {
        this.ID = ID;
        this.name = name;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;

    }

    public StarData(String ID, String name, String typeID, String focusID, float radius, float coronaSize, float windBurnLevel, float flareProbability, float crLossMult) {
        this.ID = ID;
        this.name = name;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;
        this.windBurnLevel = windBurnLevel;
        this.flareProbability = flareProbability;
        this.crLossMult = crLossMult;
    }


    public float coronaSize;//size of the covid-1984
    public float windBurnLevel = -1;//idk mayn star things
    public float flareProbability = -1;//idk mayn star things
    public float crLossMult = -1;//how much crd does the thing loss when inside teh corona, probably (give it negative numbers or fake n gay)

    @Override
    public void CreateObject(StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i) {
//çalış

        VeBlib_Logger.log(this.getClass(), "get star data from hashmap");
        StarData starData = (StarData) data.orderHashMap.get(i);

        PlanetAPI star = null;

        if (starData.windBurnLevel == -1) {
            VeBlib_Logger.log(this.getClass(),
                    "generate star with: id, type, radius, corona size\n"
                            + starData.ID + "\n"
                            + starData.typeID + "\n"
                            + starData.radius + "\n"
                            + coronaSize
            );
            star = system.initStar(
                    starData.ID,
                    starData.typeID,
                    starData.radius,
                    starData.coronaSize
            );
        } else {
            VeBlib_Logger.log(this.getClass(),
                    "generate star with: id, type, radius, corona size, wind burn level, flare proboability, cr loss mult\n " +
                            starData.ID + "\n" +
                            starData.typeID + "\n" +
                            starData.radius + "\n" +
                            starData.coronaSize + "\n" +
                            starData.windBurnLevel + "\n" +
                            starData.flareProbability + "\n" +
                            starData.crLossMult
            );
            star = system.initStar(
                    starData.ID,
                    starData.typeID,
                    starData.radius,
                    starData.coronaSize,
                    starData.windBurnLevel,
                    starData.flareProbability,
                    starData.crLossMult
            );

        }

        if (starData.orbitLocationMode == 0) {
            VeBlib_Logger.log(this.getClass(),
                    "locmod setloc: x, y\n" +
                            starData.x + "\n" +
                            starData.y
            );
            star.setLocation(starData.x, starData.y);

        } else if (starData.orbitLocationMode == 1) {
            VeBlib_Logger.log(this.getClass(),
                    "locmod set orbit: focus, angle, orbitradius, orbitdays\n" +
                            SectorEntittyTokenHashMap.get(starData.focusID).getId() + "\n" +
                            starData.angle + "\n" +
                            starData.orbitRadius + "\n" +
                            starData.orbitDays
            );
            star.setCircularOrbit(SectorEntittyTokenHashMap.get(starData.focusID), starData.angle, starData.orbitRadius, starData.orbitDays);
        } else if (starData.orbitLocationMode == 2) {
            VeBlib_Logger.log(this.getClass(),
                    "locmod set orbit looking down: focus, angle, orbitradius, orbitdays\n" +
                            SectorEntittyTokenHashMap.get(starData.focusID).getId() + "\n" +
                            starData.angle + "\n" +
                            starData.orbitRadius + "\n" +
                            starData.orbitDays
            );
            star.setCircularOrbitPointingDown(SectorEntittyTokenHashMap.get(starData.focusID), starData.angle, starData.orbitRadius, starData.orbitDays);
        } else {//orbitLocationMode = 3
            VeBlib_Logger.log(this.getClass(),
                    "locmod set orbit looking down w/ spin: focus, angle, orbitradius, orbitdays, minspin, maxspin\n" +
                            SectorEntittyTokenHashMap.get(starData.focusID) .getId()+ "\n" +
                            starData.angle + "\n" +
                            starData.orbitRadius + "\n" +
                            starData.orbitDays + "\n" +
                            starData.minSpin + "\n" +
                            starData.maxSpin
            );
            star.setCircularOrbitWithSpin(SectorEntittyTokenHashMap.get(starData.focusID), starData.angle, starData.orbitRadius, starData.orbitDays, starData.minSpin, starData.maxSpin);
        }

        VeBlib_Logger.log(this.getClass(), "set star name " + starData.name);
        star.setName(starData.name);

        VeBlib_Logger.log(this.getClass(), "put star in map");
        SectorEntittyTokenHashMap.put(starData.ID, star);

        if (i == 0) {
            VeBlib_Logger.log(this.getClass(), "set primary star to " + star.getId());
            system.setStar(star);
        }
    }

}
