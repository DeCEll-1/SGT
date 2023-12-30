package SGT.SGT.Statics;

import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import SGT.SGT.Parser.SGT_ParseJson;

import java.util.List;

@Deprecated
public class SGT_Statics {
    @Deprecated
    public static List<VeBlib_StarSystemData> starSystemList;

    static {
        try {
//            JSONArray starSystemJsonList = Global.getSettings().getMergedJSONForMod("data/strings/SGTSystems.json", "SGT").getJSONArray("StarSystemDataList");

            SGT_ParseJson.GetJson("data/strings/SGTSystems.json");


        } catch (Throwable e) {
            throw new RuntimeException(e);
        }
    }


}
