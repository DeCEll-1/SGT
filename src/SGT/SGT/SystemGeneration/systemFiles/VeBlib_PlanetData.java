package SGT.SGT.SystemGeneration.systemFiles;

import SGT.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.PlanetAPI;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.util.HashMap;

public class VeBlib_PlanetData extends VeBlib_SGTExtend {

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

    @Override
    public void CreateObject(VeBlib_StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i){
        VeBlib_Logger.log(this.getClass(), "get planet from hashmap");
        VeBlib_PlanetData planetData = (VeBlib_PlanetData) data.orderHashMap.get(i);
        VeBlib_Logger.log(this.getClass(), "generate planet " + planetData.ID);
        PlanetAPI planet = system.addPlanet(
                planetData.ID,
                SectorEntittyTokenHashMap.get(planetData.focusID),
                planetData.name,
                planetData.typeID,
                planetData.angle,
                planetData.radius,
                planetData.orbitRadius,
                planetData.orbitDays
        );

        VeBlib_Logger.log(this.getClass(), "orbit-planet");
        if (planetData.orbitLocationMode == 0) {
            planet.setLocation(planetData.x, planetData.y);
        } else if (planetData.orbitLocationMode == 1) {
            planet.setCircularOrbit(SectorEntittyTokenHashMap.get(planetData.focusID), planetData.angle, planetData.orbitRadius, planetData.orbitDays);
        } else if (planetData.orbitLocationMode == 2) {
            planet.setCircularOrbitPointingDown(SectorEntittyTokenHashMap.get(planetData.focusID), planetData.angle, planetData.orbitRadius, planetData.orbitDays);
        } else {//orbitLocationMode = 3
            planet.setCircularOrbitWithSpin(SectorEntittyTokenHashMap.get(planetData.focusID), planetData.angle, planetData.orbitRadius, planetData.orbitDays, planetData.minSpin, planetData.maxSpin);
        }

        VeBlib_Logger.log(this.getClass(), "put in map-  planet");
        SectorEntittyTokenHashMap.put(planetData.ID, planet);
    }


}
