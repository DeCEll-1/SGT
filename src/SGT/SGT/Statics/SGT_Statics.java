package SGT.SGT.Statics;

import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import com.fs.starfarer.api.Global;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class SGT_Statics {

    public static List<VeBlib_StarSystemData> starSystemList;

    static {
        try {


            starSystemList = (List<VeBlib_StarSystemData>) Global.getSettings().getMergedJSONForMod("data/strings/SGTSystems.json", "SGT").getJSONArray("StarSystemDataList");
        } catch (JSONException | IOException e) {
            throw new RuntimeException(e);
        }
    }


}
