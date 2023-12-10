package SGT.SGT.Plugins;

import SGT.SGT.Helpers.VeBlib_Logger;
import SGT.SGT.Statics.SGT_Statics;
import com.fs.starfarer.api.BaseModPlugin;
import com.fs.starfarer.api.Global;
import org.json.JSONObject;

public class SGT_ModPlugin extends BaseModPlugin {

    @Override
    public void onApplicationLoad() throws Exception {
        VeBlib_Logger.log(this.getClass(), "SGT Loaded");

        

        Object s = SGT_Statics.starSystemList;
        Object sd = SGT_Statics.starSystemList;

    }

}
