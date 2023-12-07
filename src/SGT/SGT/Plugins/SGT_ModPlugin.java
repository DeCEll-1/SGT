package SGT.SGT.Plugins;

import SGT.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.BaseModPlugin;
import com.fs.starfarer.api.combat.listeners.FighterOPCostModifier;
import com.fs.starfarer.loading.specs.FighterWingSpec;

public class SGT_ModPlugin extends BaseModPlugin {

    @Override
    public void onApplicationLoad() throws Exception {
        VeBlib_Logger.log(this.getClass(), "SGT Loaded");

        

    }

}
