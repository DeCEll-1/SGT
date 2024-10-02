package SGT.SGT.Plugins;

import SGT.SGT.Helpers.SGT_GetSystemsList;
import SGT.SGT.Helpers.VeBlib_Logger;
import SGT.SGT.SystemGeneration.VeBlib_WorldGen;
import com.fs.starfarer.api.BaseModPlugin;
import com.fs.starfarer.api.Global;

public class ModPlugin extends BaseModPlugin {

    @Override
    public void onApplicationLoad() {
        VeBlib_Logger.log(this.getClass(), "SGT Loaded");
    }

    @Override
    public void onGameLoad(boolean newGame) {

//        if(true )return;

        VeBlib_Logger.log(this.getClass(), "Nulling worldGen");
        VeBlib_WorldGen worldGen = null;
//        try {
        try {
            VeBlib_Logger.log(this.getClass(), "Generating worldGen");
            new VeBlib_WorldGen(SGT_GetSystemsList.GetSystems()).generate(Global.getSector());
        } catch (Throwable e) {
            throw new RuntimeException(e);
        }


        VeBlib_Logger.log(this.getClass(), "finished try");

//        } catch (Throwable ex) {
//            throw new RuntimeException("SGT-ErrorGeneratingSystems\nError:" + ex.toString() + Arrays.toString(ex.getStackTrace()));
//        }
        VeBlib_Logger.log(this.getClass(), "exiting try//SGT ends");


    }


}
