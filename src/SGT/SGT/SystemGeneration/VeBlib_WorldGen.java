package SGT.SGT.SystemGeneration;

import SGT.SGT.Helpers.VeBlib_Logger;
import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import SGT.SGT.SystemGeneration.SectorGenerationPlugin;
import com.fs.starfarer.api.campaign.SectorAPI;
import com.fs.starfarer.api.campaign.SectorGeneratorPlugin;

import java.util.ArrayList;
import java.util.List;

public class VeBlib_WorldGen implements SectorGeneratorPlugin {

    public List<VeBlib_StarSystemData> starSystemDataList = new ArrayList<>();

    public VeBlib_WorldGen() {
        VeBlib_Logger.log(this.getClass(), "constructed VeBlib_WorldGen without data");
    }

    public VeBlib_WorldGen(List<VeBlib_StarSystemData> starSystemDataList) {//put the gotten star system data list in the and then run generate
        this.starSystemDataList = starSystemDataList;
        VeBlib_Logger.log(this.getClass(), "constructed VeBlib_WorldGen with data");
    }

    @Override
    public void generate(SectorAPI sector) {
        new SectorGenerationPlugin(starSystemDataList).generate(sector);
    }
}
