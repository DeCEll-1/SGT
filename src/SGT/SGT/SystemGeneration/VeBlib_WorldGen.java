package SGT.SGT.SystemGeneration;

import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import SGT.SGT.SystemGeneration.SectorGenerationPlugin;
import com.fs.starfarer.api.campaign.SectorAPI;
import com.fs.starfarer.api.campaign.SectorGeneratorPlugin;

import java.util.ArrayList;
import java.util.List;

public class VeBlib_WorldGen implements SectorGeneratorPlugin {

    public List<VeBlib_StarSystemData> starSystemDataList = new ArrayList<>();

    public VeBlib_WorldGen(List<VeBlib_StarSystemData> starSystemDataList) {//put the gotten star system data list in the and then run generate
        this.starSystemDataList = starSystemDataList;
    }

    @Override
    public void generate(SectorAPI sector) {

        SectorGenerationPlugin sectorGenerationPlugin = new SectorGenerationPlugin(starSystemDataList);

        sectorGenerationPlugin.generate(sector);
    }
}
