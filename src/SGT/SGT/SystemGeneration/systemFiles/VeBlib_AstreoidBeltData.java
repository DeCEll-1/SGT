package SGT.SGT.SystemGeneration.systemFiles;

import SGT.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.util.HashMap;

public class VeBlib_AstreoidBeltData  extends VeBlib_SGTExtend{

    public VeBlib_AstreoidBeltData(){
        this.ID = "";//this is for identifieing the belt, maybe it will be used, might crash if you dont give it an id, you can do java.util.UUID.randomUUID(); which will give a random string (just do toString), there can be duplicate ones but its pratically ibloppable so dont worry
        //İTS USED İN ORBİTS HOW THE HELL SOMETHİNG CAN ORBİT AROUND SOMETHİNG AAAAAAAAAAAAAAAAAAAAA
        this.focusID = "";
        this.numAsteroids = 0;
        this.orbitRadius = 0;
        this.width = 0;
        this.minOrbitDays = 0;
        this.maxOrbitDays = 0;
        this.terrainId = "";
        this.name = "";//display name
    }

    public VeBlib_AstreoidBeltData(String ID, String focus, int numAsteroids, float orbitRadius, float width, float minOrbitDays, float maxOrbitDays, String terrainId, String optionalName)
    {
        this.ID = ID;//this is for identifieing the belt, maybe it will be used, might crash if you dont give it an id, you can do java.util.UUID.randomUUID(); which will give a random string (just do toString), there can be duplicate ones but its pratically ibloppable so dont worry
        //İTS USED İN ORBİTS HOW THE HELL SOMETHİNG CAN ORBİT AROUND SOMETHİNG AAAAAAAAAAAAAAAAAAAAA
        this.focusID = focus;
        this.numAsteroids = numAsteroids;
        this.orbitRadius = orbitRadius;
        this.width = width;
        this.minOrbitDays = minOrbitDays;
        this.maxOrbitDays = maxOrbitDays;
        this.terrainId = terrainId;
        this.name = optionalName;//display name

    }

    public int numAsteroids;//number of asteroid entities
    public float minOrbitDays;//minimum and maximum visual orbit speeds of asteroids
    public float maxOrbitDays;
    public String terrainId;//ID of the terrain type that appears in the section above the abilities bar//Terrain.PULSAR_BEAM;//this

    @Override
    public void CreateObject(VeBlib_StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i){
        VeBlib_Logger.log(this.getClass(), "astreoids");
        VeBlib_AstreoidBeltData astreoidData = (VeBlib_AstreoidBeltData) data.orderHashMap.get(i);
        VeBlib_Logger.log(this.getClass(), "astreoids " + astreoidData.ID);

        VeBlib_Logger.log(this.getClass(), "generate astreoids");
        if (astreoidData.terrainId.equals("") || astreoidData.name.equals("")) {
            SectorEntityToken astreoidBelt = system.addAsteroidBelt(
                    SectorEntittyTokenHashMap.get(astreoidData.focusID),
                    astreoidData.numAsteroids,
                    astreoidData.orbitRadius,
                    astreoidData.width,
                    astreoidData.minOrbitDays,
                    astreoidData.maxOrbitDays
            );
            SectorEntittyTokenHashMap.put(astreoidData.name, astreoidBelt);
        } else {
            SectorEntityToken astreoidBelt = system.addAsteroidBelt(
                    SectorEntittyTokenHashMap.get(astreoidData.focusID),
                    astreoidData.numAsteroids,
                    astreoidData.orbitRadius,
                    astreoidData.width,
                    astreoidData.minOrbitDays,
                    astreoidData.maxOrbitDays,
                    astreoidData.terrainId,
                    astreoidData.name
            );
            VeBlib_Logger.log(this.getClass(), "asteroids map");
            SectorEntittyTokenHashMap.put(astreoidData.name, astreoidBelt);
        }
    }

}
