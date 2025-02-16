package DeCell.SGT.SystemGeneration;

import DeCell.SGT.SystemGeneration.systemFiles.MarketData;
import DeCell.SGT.SystemGeneration.systemFiles.StarSystemData;
import DeCell.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.*;
import com.fs.starfarer.api.impl.campaign.procgen.NebulaEditor;
import com.fs.starfarer.api.impl.campaign.terrain.HyperspaceTerrainPlugin;
import com.fs.starfarer.api.util.Misc;

import java.util.*;

public class SectorGenerationPlugin implements SectorGeneratorPlugin {


    public List<StarSystemData> starSystemDataList;

    public SectorGenerationPlugin(List<StarSystemData> starSystemDataList) {
        this.starSystemDataList = starSystemDataList;
    }

    @Override
    public void generate(SectorAPI sector) {

        VeBlib_Logger.log(this.getClass(), "System null check");
        if (starSystemDataList == null) return;

        VeBlib_Logger.log(this.getClass(), "System list for start");
        for (StarSystemData data : starSystemDataList) {

            VeBlib_Logger.log(this.getClass(), "if the same system exist dont generate a new one " + data.name);
            if (sector.getStarSystem(data.name) != null) {
                continue;//if the same system already exist dont generate a new one
            }

            VeBlib_Logger.log(this.getClass(), "generate system " + data.ID);
            StarSystemAPI system = sector.createStarSystem(data.ID);
            VeBlib_Logger.log(this.getClass(), "set location " + data.systemX + " " + data.systemY);
            system.getLocation().set(data.systemX, data.systemY);
            VeBlib_Logger.log(this.getClass(), "set background " + data.backgroundTextureFilename);
            system.setBackgroundTextureFilename(data.backgroundTextureFilename);

            VeBlib_Logger.log(this.getClass(), "set base name " + data.name);
            system.setBaseName(data.name);


            VeBlib_Logger.log(this.getClass(), "generate hasmap");
            HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap = new HashMap<>();

            VeBlib_Logger.log(this.getClass(), "order hashmap");
            data.GenerateOrderHasMap();

            VeBlib_Logger.log(this.getClass(), "hashmap for");
            for (int i = 0; i < data.orderHashMap.size(); i++) {
                VeBlib_Logger.log(this.getClass(), "create sector object");
                if (data.orderHashMap.get(i) != null) {
                    data.orderHashMap.get(i).CreateObject(data, system, SectorEntittyTokenHashMap, i);
                }
            }

            for (MarketData marketData : data.marketList) {
                marketData.CreateObject(data, system, SectorEntittyTokenHashMap, marketData);
            }


            if (data.starList.size() == 0) {
                VeBlib_Logger.log(this.getClass(), "star init for starless systems");
//                    system.initNonStarCenter();
                PlanetAPI star = system.initStar(
                        "SGT_SystemCenter" + "SGTNebulaSystemTempInitStar" + data.systemName,
                        "SGT_SystemCenter",
                        0,
                        0
                );

            }

            if (data.starList.size() == 0) {
                VeBlib_Logger.log(this.getClass(), "remove the star for starless systems");// TODO fix this // idk whats wrong with this lol
                system.removeEntity(system.getStar());
            }


            VeBlib_Logger.log(this.getClass(), "hyperspace terrain");
            HyperspaceTerrainPlugin hyperspaceTerrainPlugin = (HyperspaceTerrainPlugin) Misc.getHyperspaceTerrain().getPlugin(); //get instance of hyperspace terrain
            VeBlib_Logger.log(this.getClass(), "nebula editor");
            NebulaEditor nebulaEditor = new NebulaEditor(hyperspaceTerrainPlugin); //object used to make changes to hyperspace nebula

            VeBlib_Logger.log(this.getClass(), "radius");
            float minHyperspaceRadius = hyperspaceTerrainPlugin.getTileSize() * data.minHyperspaceRadius;
            VeBlib_Logger.log(this.getClass(), "max radius");
            float maxHyperspaceRadius = system.getMaxRadiusInHyperspace();

            VeBlib_Logger.log(this.getClass(), "clear arc");
            nebulaEditor.clearArc(data.x, data.y, 0, minHyperspaceRadius + maxHyperspaceRadius, 0f, 360f, 0.25f);

            VeBlib_Logger.log(this.getClass(), "autogenerate jump points");
            system.autogenerateHyperspaceJumpPoints(data.autoGenerateEntrancesAtGasGiants, data.autoGenerateFringeJumpPoint, data.generatePlanetConditions);
        }
        VeBlib_Logger.log(this.getClass(), "For ends");

    }

}
