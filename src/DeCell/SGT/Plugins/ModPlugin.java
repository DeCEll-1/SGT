package DeCell.SGT.Plugins;

import DeCell.SGT.Helpers.VeBlib_Logger;
import DeCell.SGT.SystemGeneration.VeBlib_WorldGen;
import DeCell.SGT.SystemManager.JsonWorks;
import com.fs.starfarer.api.BaseModPlugin;
import com.fs.starfarer.api.Global;

public class ModPlugin extends BaseModPlugin {

    @Override
    public void onApplicationLoad() {
        VeBlib_Logger.log(this.getClass(), "SGT Loaded");
    }

    @Override
    public void onGameLoad(boolean newGame) {

        VeBlib_Logger.log(this.getClass(), "SGT start");
        VeBlib_WorldGen worldGen = null;
        try {
            VeBlib_Logger.log(this.getClass(), "Generating worldGen");
            new VeBlib_WorldGen(JsonWorks.getSystems()).generate(Global.getSector());
        } catch (Throwable e) {
            throw new RuntimeException(e);
        }
        VeBlib_Logger.log(this.getClass(), "SGT end");


    }


}
