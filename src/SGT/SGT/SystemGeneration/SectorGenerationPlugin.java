package SGT.SGT.SystemGeneration;

import SGT.SGT.SystemGeneration.systemFiles.*;
import com.fs.starfarer.api.Global;
import com.fs.starfarer.api.campaign.*;
import com.fs.starfarer.api.campaign.econ.MarketAPI;
import com.fs.starfarer.api.impl.campaign.procgen.NebulaEditor;
import com.fs.starfarer.api.impl.campaign.terrain.HyperspaceTerrainPlugin;
import com.fs.starfarer.api.util.Misc;

import java.util.*;

public class SectorGenerationPlugin implements SectorGeneratorPlugin {


    public List<VeBlib_StarSystemData> starSystemDataList;

    public SectorGenerationPlugin(List<VeBlib_StarSystemData> starSystemDataList) {
        this.starSystemDataList = starSystemDataList;
    }

    @Override
    public void generate(SectorAPI sector) {

        if (starSystemDataList != null) {


            for (VeBlib_StarSystemData data : starSystemDataList) {

                if (sector.getStarSystem(data.name) != null) {
                    continue;//if the same system already exist dont generate a new one
                }

                StarSystemAPI system = sector.createStarSystem(data.ID);
                system.getLocation().set(data.systemX, data.systemY);
                system.setBackgroundTextureFilename(data.backgroundTextureFilename);

                system.setBaseName(data.name);


                HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap = new HashMap<>();

                data.GenerateOrderHasMap();

                for (int i = 0; i < data.orderHashMap.size(); i++) {

                    if (data.orderHashMap.get(i) instanceof VeBlib_StarData) {
                        //çalış

                        VeBlib_StarData starData = (VeBlib_StarData) data.orderHashMap.get(i);

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

                        star.setName(starData.name);

                        SectorEntittyTokenHashMap.put(starData.ID, star);
                    }

                    if (data.orderHashMap.get(i) instanceof VeBlib_PlanetData) {
                        VeBlib_PlanetData planetData = (VeBlib_PlanetData) data.orderHashMap.get(i);
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

                        if (planetData.orbitLocationMode == 0) {
                            planet.setLocation(planetData.x, planetData.y);
                        } else if (planetData.orbitLocationMode == 1) {
                            planet.setCircularOrbit(SectorEntittyTokenHashMap.get(planetData.focusID), planetData.angle, planetData.orbitRadius, planetData.orbitDays);
                        } else if (planetData.orbitLocationMode == 2) {
                            planet.setCircularOrbitPointingDown(SectorEntittyTokenHashMap.get(planetData.focusID), planetData.angle, planetData.orbitRadius, planetData.orbitDays);
                        } else {//orbitLocationMode = 3
                            planet.setCircularOrbitWithSpin(SectorEntittyTokenHashMap.get(planetData.focusID), planetData.angle, planetData.orbitRadius, planetData.orbitDays, planetData.minSpin, planetData.maxSpin);
                        }

                        SectorEntittyTokenHashMap.put(planetData.ID, planet);


                    }

                    if (data.orderHashMap.get(i) instanceof VeBlib_SectorEntittyTokenData) {
                        VeBlib_SectorEntittyTokenData sectorEntityTokenData = (VeBlib_SectorEntittyTokenData) data.orderHashMap.get(i);
                        SectorEntityToken addCustomEntity = system.addCustomEntity(
                                sectorEntityTokenData.ID,
                                sectorEntityTokenData.name,
                                sectorEntityTokenData.customEntittyType,
                                sectorEntityTokenData.factionID
                        );

                        if (sectorEntityTokenData.orbitLocationMode == 0) {
                            addCustomEntity.setLocation(sectorEntityTokenData.x, sectorEntityTokenData.y);
                        } else if (sectorEntityTokenData.orbitLocationMode == 1) {
                            addCustomEntity.setCircularOrbit(SectorEntittyTokenHashMap.get(sectorEntityTokenData.focusID), sectorEntityTokenData.angle, sectorEntityTokenData.orbitRadius, sectorEntityTokenData.orbitDays);
                        } else if (sectorEntityTokenData.orbitLocationMode == 2) {
                            addCustomEntity.setCircularOrbitPointingDown(SectorEntittyTokenHashMap.get(sectorEntityTokenData.focusID), sectorEntityTokenData.angle, sectorEntityTokenData.orbitRadius, sectorEntityTokenData.orbitDays);
                        } else {//orbitLocationMode = 3
                            addCustomEntity.setCircularOrbitWithSpin(SectorEntittyTokenHashMap.get(sectorEntityTokenData.focusID), sectorEntityTokenData.angle, sectorEntityTokenData.orbitRadius, sectorEntityTokenData.orbitDays, sectorEntityTokenData.minSpin, sectorEntityTokenData.maxSpin);
                        }

                        SectorEntittyTokenHashMap.put(sectorEntityTokenData.ID, addCustomEntity);

                    }

                    if (data.orderHashMap.get(i) instanceof VeBlib_MarketData) {
                        VeBlib_MarketData marketData = (VeBlib_MarketData) data.orderHashMap.get(i);


//                boolean currentWithJunkAndChatter = false;

//                if (WithJunkAndChatterIterator.hasNext()) {
//                    currentWithJunkAndChatter = (boolean) WithJunkAndChatterIterator.next();
//                }
//
//                boolean PirateMode = false;
//
//                if (PirateModeIterator.hasNext()) {
//                    PirateMode = (boolean) PirateModeIterator.next();
//                }
                        ArrayList<String> marketDataConditionAList = new ArrayList<>();
                        marketDataConditionAList.addAll(marketData.marketConditions);

                        ArrayList<String> marketDataSubmarketList = new ArrayList<>();
                        marketDataSubmarketList.addAll(marketData.submarkets);

                        ArrayList<String> marketDataIndustriesList = new ArrayList<>();
                        marketDataIndustriesList.addAll(marketData.industries);

                        ArrayList<SectorEntityToken> connectedEntittys = new ArrayList<>();

                        for (String entittyID : marketData.connectedEntities) {
                            connectedEntittys.add(SectorEntittyTokenHashMap.get(entittyID));
                        }

                        if (marketData.ID.equals(""))//doesnt have an id
                        {
                            MarketAPI market = VeBlib_AddMarket.addMarketplace(
                                    marketData.factionID,
                                    SectorEntittyTokenHashMap.get(marketData.primaryEntity),
                                    connectedEntittys,
                                    marketData.name,
                                    marketData.size,
                                    marketDataConditionAList,
                                    marketDataSubmarketList,
                                    marketDataIndustriesList,
                                    marketData.WithJunkAndChatter,
                                    marketData.PirateMode
                            );
                        } else {//haves an id
                            MarketAPI market = VeBlib_AddMarket.addMarketplace(
                                    marketData.ID,
                                    marketData.factionID,
                                    SectorEntittyTokenHashMap.get(marketData.primaryEntity),
                                    connectedEntittys,
                                    marketData.name,
                                    marketData.size,
                                    marketDataConditionAList,
                                    marketDataSubmarketList,
                                    marketDataIndustriesList,
                                    marketData.WithJunkAndChatter,
                                    marketData.PirateMode
                            );
                        }


                    }

                    if (data.orderHashMap.get(i) instanceof VeBlib_AstreoidBeltData) {
                        VeBlib_AstreoidBeltData astreoidData = (VeBlib_AstreoidBeltData) data.orderHashMap.get(i);

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
                            SectorEntittyTokenHashMap.put(astreoidData.name, astreoidBelt);
                        }

                    }

                    if (data.orderHashMap.get(i) instanceof VeBlib_RingBandData) {
                        VeBlib_RingBandData ringBandData = (VeBlib_RingBandData) data.orderHashMap.get(i);

                        if (ringBandData.terrainId.equals("") || ringBandData.name.equals("")) {
                            SectorEntityToken ringBand = system.addRingBand(
                                    SectorEntittyTokenHashMap.get(ringBandData.focusID),
                                    ringBandData.category,
                                    ringBandData.key,
                                    ringBandData.bandWidthInTexture,
                                    ringBandData.bandIndex,
                                    ringBandData.color,
                                    ringBandData.bandWidthInEngine,
                                    ringBandData.middleRadius,
                                    ringBandData.orbitDays
                            );
                            SectorEntittyTokenHashMap.put(ringBandData.ID, ringBand);
                        } else {
                            SectorEntityToken ringBand = system.addRingBand(
                                    SectorEntittyTokenHashMap.get(ringBandData.focusID),
                                    ringBandData.category,
                                    ringBandData.key,
                                    ringBandData.bandWidthInTexture,
                                    ringBandData.bandIndex,
                                    ringBandData.color,
                                    ringBandData.bandWidthInEngine,
                                    ringBandData.middleRadius,
                                    ringBandData.orbitDays,
                                    ringBandData.terrainId,
                                    ringBandData.name
                            );
                            SectorEntittyTokenHashMap.put(ringBandData.ID, ringBand);
                        }
                    }
                }

                if (data.starList.size() == 0) {

//                    system.initNonStarCenter();
                    PlanetAPI star = system.initStar(
                            "SGT_SystemCenter" + "SGTNebulaSystemTempInitStar" + data.systemName,
                            "SGT_SystemCenter",
                            0,
                            0
                    );

                }

                system.autogenerateHyperspaceJumpPoints(data.autoGenerateEntrancesAtGasGiants, data.autoGenerateFringeJumpPoint, data.generatePlanetConditions);

                system.removeEntity(system.getStar());


                HyperspaceTerrainPlugin hyperspaceTerrainPlugin = (HyperspaceTerrainPlugin) Misc.getHyperspaceTerrain().getPlugin(); //get instance of hyperspace terrain
                NebulaEditor nebulaEditor = new NebulaEditor(hyperspaceTerrainPlugin); //object used to make changes to hyperspace nebula

                float minHyperspaceRadius = hyperspaceTerrainPlugin.getTileSize() * data.minHyperspaceRadius;
                float maxHyperspaceRadius = system.getMaxRadiusInHyperspace();

                nebulaEditor.clearArc(data.systemX, data.systemY, 0, minHyperspaceRadius + maxHyperspaceRadius, 0f, 360f, 0.25f);

            }
        }
    }

}
