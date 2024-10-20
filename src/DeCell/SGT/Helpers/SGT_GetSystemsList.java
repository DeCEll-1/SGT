package DeCell.SGT.Helpers;

import DeCell.SGT.Parser.ParseJson;
import DeCell.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;

import java.util.List;

public class SGT_GetSystemsList {


    public static List<VeBlib_StarSystemData> GetSystems() throws Throwable {
        VeBlib_Logger.log(SGT_GetSystemsList.class, "Getting Json");
        return ParseJson.GetJson("data/strings/SGTSystems.json");
    }


}
