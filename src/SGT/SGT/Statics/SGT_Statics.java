package SGT.SGT.Statics;

import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import SGT.SGT.test.SGT_ParseJson;
import com.fs.starfarer.api.Global;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import sun.org.mozilla.javascript.internal.json.JsonParser;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class SGT_Statics {

    public static List<VeBlib_StarSystemData> starSystemList;

    static {
        try {
//            JSONArray starSystemJsonList = Global.getSettings().getMergedJSONForMod("data/strings/SGTSystems.json", "SGT").getJSONArray("StarSystemDataList");

            SGT_ParseJson.GetJson("data/strings/SGTSystems.json");


        } catch (JSONException | IOException | InstantiationException | IllegalAccessException e) {
            throw new RuntimeException(e);
        }
    }


}
