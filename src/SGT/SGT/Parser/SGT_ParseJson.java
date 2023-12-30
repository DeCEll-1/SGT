package SGT.SGT.Parser;

import SGT.SGT.SystemGeneration.systemFiles.*;
import com.fs.starfarer.api.Global;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

public class SGT_ParseJson {

    /**
     *gets systems </br>
     *
     * @param path path to the system json
     *
     * */
    public static List<VeBlib_StarSystemData> GetJson(String path) throws Throwable {

        List<VeBlib_StarSystemData> systemList = new ArrayList<>();

        JSONObject jsonObject = Global.getSettings().getMergedJSONForMod(path, "SGT");

        JSONArray systemJsonList = jsonObject.getJSONArray("StarSystemDataList");

        for (int s = 0; s < systemJsonList.length(); s++) {
            JSONObject systemJsonObject = systemJsonList.getJSONObject(s);

            JSONParserForSGT<VeBlib_StarSystemData> systemParser = new JSONParserForSGT<VeBlib_StarSystemData>(VeBlib_StarSystemData.class);

            VeBlib_StarSystemData system = systemParser.Convert(systemJsonObject);

            system.stuffOrbitingAround = GetStuffOrbitingAround(systemJsonObject);// :)

            //region stars
            JSONArray starListJsonArray = systemJsonObject.getJSONArray("starList");

            for (int st = 0; st < starListJsonArray.length(); st++) {
                JSONObject starJsonObject = starListJsonArray.getJSONObject(st);

                JSONParserForSGT<VeBlib_StarData> starParser = new JSONParserForSGT<>(VeBlib_StarData.class);

                VeBlib_StarData star = starParser.Convert(starJsonObject);

                star.stuffOrbitingAround = GetStuffOrbitingAround(starJsonObject);

                system.starList.add(star);
            }
            //endregion

            //region planets
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
            JSONArray ringBandJsonArray = systemJsonObject.getJSONArray("ringBandDataList");

            for (int ri = 0; ri < ringBandJsonArray.length(); ri++) {
                JSONObject ringBandJsonObject = ringBandJsonArray.getJSONObject(ri);

                JSONParserForSGT<VeBlib_RingBandData> ringBandParser = new JSONParserForSGT<>(VeBlib_RingBandData.class);

                VeBlib_RingBandData ringBand = ringBandParser.Convert(ringBandJsonObject);

                ringBand.stuffOrbitingAround = GetStuffOrbitingAround(ringBandJsonObject);

                system.ringBandDataList.add(ringBand);
            }
            //endregion

            //region sectorEntityToken
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

}
