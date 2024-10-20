package DeCell.SGT.Statics;

import DeCell.SGT.Parser.ParseJson;
import DeCell.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;

import java.util.List;

@Deprecated
public class SGT_Statics {
    @Deprecated
    public static List<VeBlib_StarSystemData> starSystemList;

    static {
        try {
//            JSONArray starSystemJsonList = Global.getSettings().getMergedJSONForMod("data/strings/SGTSystems.json", "SGT").getJSONArray("StarSystemDataList");

            ParseJson.GetJson("data/strings/SGTSystems.json");


        } catch (Throwable e) {
            throw new RuntimeException(e);
        }
    }


}
