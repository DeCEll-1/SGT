package SGT.SGT.Parser;

import SGT.SGT.Helpers.VeBlib_Logger;
import SGT.SGT.SystemGeneration.systemFiles.*;
import com.fs.starfarer.api.Global;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.awt.*;
import java.util.ArrayList;
import java.util.List;

public class SGT_ParseJson {

    /**
     * gets systems </br>
     *
     * @param path path to the system json
     */
    public static List<VeBlib_StarSystemData> GetJson(String path) throws Throwable {
        VeBlib_Logger.log(SGT_ParseJson.class, "Getting Json - in function");

        VeBlib_Logger.log(SGT_ParseJson.class, "Init System List");
        List<VeBlib_StarSystemData> systemList = new ArrayList<>();

        VeBlib_Logger.log(SGT_ParseJson.class, "Get Merged Json Object");
        JSONObject jsonObject = Global.getSettings().getMergedJSON(path);

        VeBlib_Logger.log(SGT_ParseJson.class, "Get StarSystemDataList Json Array");
        JSONArray systemJsonList = jsonObject.getJSONArray("StarSystemDataList");

        VeBlib_Logger.log(SGT_ParseJson.class, "System For Start");
        for (int s = 0; s < systemJsonList.length(); s++) {
            VeBlib_Logger.log(SGT_ParseJson.class, "Get System");
            JSONObject systemJsonObject = systemJsonList.getJSONObject(s);

            VeBlib_Logger.log(SGT_ParseJson.class, "Parse System");
            JSONParserForSGT<VeBlib_StarSystemData> systemParser = new JSONParserForSGT<VeBlib_StarSystemData>(VeBlib_StarSystemData.class);

            VeBlib_Logger.log(SGT_ParseJson.class, "Convert System");
            VeBlib_StarSystemData system = systemParser.Convert(systemJsonObject);

            system.stuffOrbitingAround = GetStuffOrbitingAround(systemJsonObject);// :)

            //region stars
            VeBlib_Logger.log(SGT_ParseJson.class, "Get Stars");
            JSONArray starListJsonArray = systemJsonObject.getJSONArray("starList");

            VeBlib_Logger.log(SGT_ParseJson.class, "Star For Start");
            for (int st = 0; st < starListJsonArray.length(); st++) {
                JSONObject starJsonObject = starListJsonArray.getJSONObject(st);

                JSONParserForSGT<VeBlib_StarData> starParser = new JSONParserForSGT<>(VeBlib_StarData.class);

                VeBlib_StarData star = starParser.Convert(starJsonObject);

                star.stuffOrbitingAround = GetStuffOrbitingAround(starJsonObject);

                system.starList.add(star);
            }
            //endregion

            //region planets
            VeBlib_Logger.log(SGT_ParseJson.class, "Get Planet List");
            JSONArray planetsJsonArray = systemJsonObject.getJSONArray("planetList");

            for (int pl = 0; pl < planetsJsonArray.length(); pl++) {
                JSONObject planetJsonObject = planetsJsonArray.getJSONObject(pl);

                JSONParserForSGT<VeBlib_PlanetData> planetParser = new JSONParserForSGT<>(VeBlib_PlanetData.class);

                VeBlib_PlanetData planet = planetParser.Convert(planetJsonObject);

                planet.stuffOrbitingAround = GetStuffOrbitingAround(planetJsonObject);

                system.planetList.add(planet);
            }
            //endregion

            //region markets
            VeBlib_Logger.log(SGT_ParseJson.class, "Get Market List");
            JSONArray marketJsonArray = systemJsonObject.getJSONArray("marketList");

            for (int ma = 0; ma < marketJsonArray.length(); ma++) {
                JSONObject marketJsonObject = marketJsonArray.getJSONObject(ma);

                JSONParserForSGT<VeBlib_MarketData> marketParser = new JSONParserForSGT<>(VeBlib_MarketData.class);

                VeBlib_MarketData market = marketParser.Convert(marketJsonObject);

                market.stuffOrbitingAround = GetStuffOrbitingAround(marketJsonObject);//wont do shit but no reson to remove either

                system.marketList.add(market);
            }
            //endregion

            //region astreoids
            VeBlib_Logger.log(SGT_ParseJson.class, "Get Astreoid Belt List");
            JSONArray astreoidJsonArray = systemJsonObject.getJSONArray("astreoidBeltDataList");

            for (int as = 0; as < astreoidJsonArray.length(); as++) {
                JSONObject astreoidJsonObject = astreoidJsonArray.getJSONObject(as);

                JSONParserForSGT<VeBlib_AstreoidBeltData> marketParser = new JSONParserForSGT<>(VeBlib_AstreoidBeltData.class);

                VeBlib_AstreoidBeltData astreoidBelt = marketParser.Convert(astreoidJsonObject);

                astreoidBelt.stuffOrbitingAround = GetStuffOrbitingAround(astreoidJsonObject);

                system.astreoidBeltDataList.add(astreoidBelt);
            }
            //endregion

            //region ringBands
            VeBlib_Logger.log(SGT_ParseJson.class, "Get Ring Band List");
            JSONArray ringBandJsonArray = systemJsonObject.getJSONArray("ringBandDataList");

            for (int ri = 0; ri < ringBandJsonArray.length(); ri++) {
                JSONObject ringBandJsonObject = ringBandJsonArray.getJSONObject(ri);

                JSONParserForSGT<VeBlib_RingBandData> ringBandParser = new JSONParserForSGT<>(VeBlib_RingBandData.class);

                VeBlib_RingBandData ringBand = ringBandParser.Convert(ringBandJsonObject);

                ringBand.stuffOrbitingAround = GetStuffOrbitingAround(ringBandJsonObject);

                String[] colorsStr = ringBand.color.split(",");

                int[] colors = Str2IntArray(colorsStr);

                if (colors.length == 4) ringBand.colorColor = new Color(colors[1], colors[2], colors[3], colors[0]);
                if (colors.length == 3) ringBand.colorColor = new Color(colors[0], colors[1], colors[2]);


                system.ringBandDataList.add(ringBand);
            }
            //endregion

            //region sectorEntityToken
            VeBlib_Logger.log(SGT_ParseJson.class, "Get Sector Entity Token List");
            JSONArray sectorEntityTokenJsonArray = systemJsonObject.getJSONArray("sectorEntityTokenList");

            for (int set = 0; set < sectorEntityTokenJsonArray.length(); set++) {
                JSONObject sectorEntityTokenJsonObject = sectorEntityTokenJsonArray.getJSONObject(set);

                JSONParserForSGT<VeBlib_SectorEntittyTokenData> sectorEntityTokenParser = new JSONParserForSGT<>(VeBlib_SectorEntittyTokenData.class);

                VeBlib_SectorEntittyTokenData sectorEntityToken = sectorEntityTokenParser.Convert(sectorEntityTokenJsonObject);

                sectorEntityToken.stuffOrbitingAround = GetStuffOrbitingAround(sectorEntityTokenJsonObject);

                system.sectorEntityTokenList.add(sectorEntityToken);
            }
            //endregion


            systemList.add(system);


        }

        return systemList;
    }

    private static String[] GetStuffOrbitingAround(JSONObject extendJsonObject) throws JSONException {
        JSONArray stuffOrbitingAround = extendJsonObject.getJSONArray("stuffOrbitingAround");

        if (stuffOrbitingAround.length() == 0) return new String[0];

        String[] returnString = new String[stuffOrbitingAround.length()];

        for (int o = 0; o < stuffOrbitingAround.length(); o++) {

            returnString[o] = stuffOrbitingAround.getString(o);

        }

        return returnString;

    }

    private static int[] Str2IntArray(String[] list) {
        //oooo it needs to inherit object oooo you cant make lists of primitive types fuck of and paint yourself
        int[] returnArray = new int[list.length];
        byte i = 0;//byte because fuck you i love bytes i AM bytes
        for (String str : list) {

            returnArray[i] = Integer.parseInt(str.trim());

            i++;
        }
        return returnArray;
    }

}
