package SGT.SGT.Helpers;

import SGT.SGT.Parser.SGT_ParseJson;
import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;

import java.util.List;

public class SGT_GetSystemsList {


    public static List<VeBlib_StarSystemData> GetSystems() throws Throwable {
        VeBlib_Logger.log(SGT_GetSystemsList.class, "Getting Json");
        return SGT_ParseJson.GetJson("data/strings/SGTSystems.json");
    }


}
