package SGT.SGT.test;

import SGT.SGT.SystemGeneration.systemFiles.VeBlib_PlanetData;
import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import com.fs.starfarer.api.Global;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class SGT_ParseJson {


    public static List<VeBlib_StarSystemData> GetJson(String path) throws JSONException, IOException, InstantiationException, IllegalAccessException {

        List<VeBlib_StarSystemData> systemList = new ArrayList<>();

        JSONObject jsonObject = Global.getSettings().getMergedJSONForMod(path, "SGT");

        JSONArray systemJsonList = jsonObject.getJSONArray("StarSystemDataList");

        for (int s = 0; s < systemJsonList.length(); s++) {
            JSONObject systemJsonObject = systemJsonList.getJSONObject(s);

            JSONParserForSGT<VeBlib_StarSystemData> systemParser = new JSONParserForSGT<>(VeBlib_StarSystemData.class);

            VeBlib_StarSystemData system = systemParser.Convert(systemJsonObject);

            JSONArray planetsJsonArray = systemJsonObject.getJSONArray("planetList");

            for (int p = 0; p < planetsJsonArray.length(); p++) {
                JSONObject planetJsonObject = planetsJsonArray.getJSONObject(p);

                JSONParserForSGT<VeBlib_PlanetData> planetParser = new JSONParserForSGT<>(VeBlib_PlanetData.class);

                VeBlib_PlanetData planet = planetParser.Convert(planetJsonObject);


            }


        }

        return systemList;
    }

}
