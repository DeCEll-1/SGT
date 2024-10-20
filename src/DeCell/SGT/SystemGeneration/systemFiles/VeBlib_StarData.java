package DeCell.SGT.SystemGeneration.systemFiles;

import DeCell.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.PlanetAPI;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.util.HashMap;

public class VeBlib_StarData extends VeBlib_SGTExtend {

    //region overloads
    public VeBlib_StarData()
    {
        this.ID = "";
        this.typeID = "";
        this.focusID = "";
        this.radius = 0;
        this.coronaSize = 0;

    }

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

    public VeBlib_StarData(String ID, String name, String typeID, String focusID, float radius, float coronaSize)
    {
        this.ID = ID;
        this.name = name;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;

    }

    public VeBlib_StarData(String ID, String name, String typeID, String focusID, float radius, float coronaSize, float windBurnLevel, float flareProbability, float crLossMult)
    {
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
    public void CreateObject(VeBlib_StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i){
//çalış

        VeBlib_Logger.log(this.getClass(), "get star data from hashmap");
        VeBlib_StarData starData = (VeBlib_StarData) data.orderHashMap.get(i);
        VeBlib_Logger.log(this.getClass(), "star " + starData.ID);

        PlanetAPI star = null;

        if (starData.windBurnLevel == -1) {
            star = system.initStar(
                    starData.ID,
                    starData.typeID,
                    starData.radius,
                    starData.coronaSize
            );
        } else {
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
            star.setLocation(starData.x, starData.y);
        } else if (starData.orbitLocationMode == 1) {
            star.setCircularOrbit(SectorEntittyTokenHashMap.get(starData.focusID), starData.angle, starData.orbitRadius, starData.orbitDays);
        } else if (starData.orbitLocationMode == 2) {
            star.setCircularOrbitPointingDown(SectorEntittyTokenHashMap.get(starData.focusID), starData.angle, starData.orbitRadius, starData.orbitDays);
        } else {//orbitLocationMode = 3
            star.setCircularOrbitWithSpin(SectorEntittyTokenHashMap.get(starData.focusID), starData.angle, starData.orbitRadius, starData.orbitDays, starData.minSpin, starData.maxSpin);
        }

        VeBlib_Logger.log(this.getClass(), "set star name");
        star.setName(starData.name);

        VeBlib_Logger.log(this.getClass(), "put star in map");
        SectorEntittyTokenHashMap.put(starData.ID, star);
    }

}
