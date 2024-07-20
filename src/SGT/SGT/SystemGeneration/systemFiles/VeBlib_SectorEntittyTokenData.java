package SGT.SGT.SystemGeneration.systemFiles;

import SGT.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.util.HashMap;

public class VeBlib_SectorEntittyTokenData extends VeBlib_SGTExtend{

    public VeBlib_SectorEntittyTokenData()
    {
        this.ID = "";
        this.name = "";
        this.customEntittyType = "";
        this.factionID = "";
    }

    public VeBlib_SectorEntittyTokenData(String ID, String name, String customEntittyType, String factionID, float x, float y)
    {
        this.ID = ID;
        this.name = name;
        this.customEntittyType = customEntittyType;
        this.factionID = factionID;
        this.x = x;
        this.y = y;
        this.orbitLocationMode = 0;
    }

    public VeBlib_SectorEntittyTokenData(String ID, String name, String customEntittyType, String factionID, String focusID, float angle, float orbitRadius, float orbitDays, boolean setCircularOrbitPointingDown)
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

    public VeBlib_SectorEntittyTokenData(String ID, String name, String customEntittyType, String factionID, String focusID, float angle, float orbitRadius, float orbitDays, float minSpin, float maxSpin)
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


    @Override
    public void CreateObject(VeBlib_StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i){
        VeBlib_Logger.log(this.getClass(), "entity");
        VeBlib_SectorEntittyTokenData sectorEntityTokenData = (VeBlib_SectorEntittyTokenData) data.orderHashMap.get(i);
        VeBlib_Logger.log(this.getClass(), "generate entity " + sectorEntityTokenData.ID);
        SectorEntityToken addCustomEntity = system.addCustomEntity(
                sectorEntityTokenData.ID,
                sectorEntityTokenData.name,
                sectorEntityTokenData.customEntittyType,
                sectorEntityTokenData.factionID
        );

        VeBlib_Logger.log(this.getClass(), "orbit - entity");
        if (sectorEntityTokenData.orbitLocationMode == 0) {
            addCustomEntity.setLocation(sectorEntityTokenData.x, sectorEntityTokenData.y);
        } else if (sectorEntityTokenData.orbitLocationMode == 1) {
            addCustomEntity.setCircularOrbit(SectorEntittyTokenHashMap.get(sectorEntityTokenData.focusID), sectorEntityTokenData.angle, sectorEntityTokenData.orbitRadius, sectorEntityTokenData.orbitDays);
        } else if (sectorEntityTokenData.orbitLocationMode == 2) {
            addCustomEntity.setCircularOrbitPointingDown(SectorEntittyTokenHashMap.get(sectorEntityTokenData.focusID), sectorEntityTokenData.angle, sectorEntityTokenData.orbitRadius, sectorEntityTokenData.orbitDays);
        } else {//orbitLocationMode = 3
            addCustomEntity.setCircularOrbitWithSpin(SectorEntittyTokenHashMap.get(sectorEntityTokenData.focusID), sectorEntityTokenData.angle, sectorEntityTokenData.orbitRadius, sectorEntityTokenData.orbitDays, sectorEntityTokenData.minSpin, sectorEntityTokenData.maxSpin);
        }

        VeBlib_Logger.log(this.getClass(), "entity map ");
        SectorEntittyTokenHashMap.put(sectorEntityTokenData.ID, addCustomEntity);
    }


}
