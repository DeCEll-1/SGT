package SGT.SGT;

import SGT.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.BaseModPlugin;

public class SGT_ModPlugin extends BaseModPlugin {

    @Override
    public void onApplicationLoad() throws Exception {
        VeBlib_Logger.log(this.getClass(), "SGT Loaded");
    }

}
