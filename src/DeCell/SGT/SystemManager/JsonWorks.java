package DeCell.SGT.SystemManager;

import DeCell.SGT.Helpers.JsonHelper;
import DeCell.SGT.Helpers.VeBlib_Logger;
import DeCell.SGT.Parser.ImageWorks;
import DeCell.SGT.Parser.JSONParser;
import DeCell.SGT.Parser.ParseJson;
import DeCell.SGT.Parser.SystemMetadata;
import DeCell.SGT.Paths;
import DeCell.SGT.Reflection.ReflectionWorks;
import DeCell.SGT.SystemGeneration.systemFiles.*;
import com.fs.starfarer.api.Global;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class JsonWorks {

    public static List<StarSystemData> getSystems() throws Throwable {
        List<StarSystemData> systems = new ArrayList<>();
        for (SystemMetadata metadata : getSystemsMetadata()) {
            systems.add(getStarSystemData(metadata));
        }
        return systems;
    }

    // jdk.nashorn.internal.parser.JSONParser
    public static List<SystemMetadata> getSystemsMetadata() throws JSONException, IOException {
        JSONObject[] merged = JsonHelper.JSONArray2JSONObjectArray(Global.getSettings().getMergedJSON(Paths.SystemMetadatas).getJSONArray("SystemMetadatas"));
        SystemMetadata[] result = new SystemMetadata[merged.length];
        JSONParser<SystemMetadata> parser = new JSONParser<>(SystemMetadata.class);
        try {
            for (int i = 0; i < merged.length; i++) {
                result[i] = parser.Convert(merged[i]);
            }
        } catch (Throwable e) {
            throw new RuntimeException(e);
        }
        return Arrays.asList(result);
    }

    public static StarSystemData getStarSystemData(SystemMetadata metadata) throws Throwable {
        String savedImagePathRoot = metadata.ImagePath;
        ImageWorks iw = new ImageWorks();
//get ze image
        BufferedImage image = ReflectionWorks.GetBufferedImage(savedImagePathRoot);
        // get ze json from ze image
        String systemJson = iw.BitmapToText(image, metadata.width, metadata.height);

        // do ze rest of ze parsing
        return getSystem(systemJson);

    }

    private static StarSystemData getSystem(String json) throws Throwable {
//get ze object
        VeBlib_Logger.log(ParseJson.class, "Get System");
        JSONObject systemJsonObject = new JSONObject(json);

        VeBlib_Logger.log(ParseJson.class, "Parse System");
        JSONParser<StarSystemData> systemParser = new JSONParser<StarSystemData>(StarSystemData.class);

        VeBlib_Logger.log(ParseJson.class, "Convert System");
        StarSystemData system = systemParser.Convert(systemJsonObject);

        system.stuffOrbitingAround = GetStuffOrbitingAround(systemJsonObject);// :) // idk why i put smile here idk what this does nor how it does

        VeBlib_Logger.log(ParseJson.class, "Star For Start"); // good motto frfr og
        system.starList = getStars(systemJsonObject.getJSONArray("starList"));

        VeBlib_Logger.log(ParseJson.class, "Get Planet List");
        system.planetList = getPlanets(systemJsonObject.getJSONArray("planetList"));

        VeBlib_Logger.log(ParseJson.class, "Get Market List");
        system.marketList = getMarkets(systemJsonObject.getJSONArray("marketList"));

        VeBlib_Logger.log(ParseJson.class, "Get Astreoid Belt List");
        system.astreoidBeltDataList = getAstreoidBelts(systemJsonObject.getJSONArray("astreoidBeltDataList"));

        VeBlib_Logger.log(ParseJson.class, "Get Ring Band List");
        system.ringBandDataList = getRingBands(systemJsonObject.getJSONArray("ringBandDataList"));

        VeBlib_Logger.log(ParseJson.class, "Get Sector Entity Token List");
        system.sectorEntityTokenList = getSectorEntities(systemJsonObject.getJSONArray("sectorEntityTokenList"));

        return system;
    }

    private static List<SectorEntittyTokenData> getSectorEntities(JSONArray sectorEntityTokenJsonArray) throws Throwable {
        List<SectorEntittyTokenData> entities = new ArrayList<>();
        for (int set = 0; set < sectorEntityTokenJsonArray.length(); set++) {
            JSONObject sectorEntityTokenJsonObject = sectorEntityTokenJsonArray.getJSONObject(set);

            JSONParser<SectorEntittyTokenData> sectorEntityTokenParser = new JSONParser<>(SectorEntittyTokenData.class);

            SectorEntittyTokenData sectorEntityToken = sectorEntityTokenParser.Convert(sectorEntityTokenJsonObject);

            sectorEntityToken.stuffOrbitingAround = GetStuffOrbitingAround(sectorEntityTokenJsonObject);

            entities.add(sectorEntityToken);
        }
        return entities;
    }

    private static List<RingBandData> getRingBands(JSONArray ringBandJsonArray) throws Throwable {
        List<RingBandData> ringBands = new ArrayList<>();
        for (int ri = 0; ri < ringBandJsonArray.length(); ri++) {
            JSONObject ringBandJsonObject = ringBandJsonArray.getJSONObject(ri);

            JSONParser<RingBandData> ringBandParser = new JSONParser<>(RingBandData.class);

            RingBandData ringBand = ringBandParser.Convert(ringBandJsonObject);

            ringBand.stuffOrbitingAround = GetStuffOrbitingAround(ringBandJsonObject);

            String[] colorsStr = ringBand.color.split(",");

            int[] colors = Str2IntArray(colorsStr);

            if (colors.length == 4) ringBand.colorColor = new Color(colors[1], colors[2], colors[3], colors[0]);
            if (colors.length == 3) ringBand.colorColor = new Color(colors[0], colors[1], colors[2]);


            ringBands.add(ringBand);
        }
        return ringBands;
    }

    private static List<AstreoidBeltData> getAstreoidBelts(JSONArray astreoidJsonArray) throws Throwable {
        List<AstreoidBeltData> astreoidBelts = new ArrayList<>();

        for (int as = 0; as < astreoidJsonArray.length(); as++) {
            JSONObject astreoidJsonObject = astreoidJsonArray.getJSONObject(as);

            JSONParser<AstreoidBeltData> marketParser = new JSONParser<>(AstreoidBeltData.class);

            AstreoidBeltData astreoidBelt = marketParser.Convert(astreoidJsonObject);

            astreoidBelt.stuffOrbitingAround = GetStuffOrbitingAround(astreoidJsonObject);

            astreoidBelts.add(astreoidBelt);
        }
        return astreoidBelts;
    }

    private static List<MarketData> getMarkets(JSONArray marketJsonArray) throws Throwable {
        List<MarketData> markets = new ArrayList<>();

        for (int ma = 0; ma < marketJsonArray.length(); ma++) {
            JSONObject marketJsonObject = marketJsonArray.getJSONObject(ma);

            JSONParser<MarketData> marketParser = new JSONParser<>(MarketData.class);

            MarketData market = marketParser.Convert(marketJsonObject);

            market.stuffOrbitingAround = GetStuffOrbitingAround(marketJsonObject);//wont do shit but no reson to remove either
            // how does a market have stuff orbiting around it?
            for (int i =  0; i <marketJsonObject.getJSONArray("marketConditions").length() ; i++) {
                market.marketConditions.add( marketJsonObject.getJSONArray("marketConditions").getString(i));
            }
            for (int i =  0; i <marketJsonObject.getJSONArray("submarkets").length() ; i++) {
                market.submarkets.add( marketJsonObject.getJSONArray("submarkets").getString(i));
            }
            for (int i =  0; i <marketJsonObject.getJSONArray("industries").length() ; i++) {
                market.industries.add( marketJsonObject.getJSONArray("industries").getString(i));
            }

            markets.add(market);
        }
        return markets;
    }

    private static List<PlanetData> getPlanets(JSONArray planetsJsonArray) throws Throwable {
        List<PlanetData> planets = new ArrayList<>();

        for (int pl = 0; pl < planetsJsonArray.length(); pl++) {
            JSONObject planetJsonObject = planetsJsonArray.getJSONObject(pl);

            JSONParser<PlanetData> planetParser = new JSONParser<>(PlanetData.class);

            PlanetData planet = planetParser.Convert(planetJsonObject);

            planet.stuffOrbitingAround = GetStuffOrbitingAround(planetJsonObject);

            planets.add(planet);
        }
        return planets;
    }

    private static List<StarData> getStars(JSONArray starListJsonArray) throws Throwable {
        List<StarData> stars = new ArrayList<>();

        VeBlib_Logger.log(ParseJson.class, "Star For Start");
        for (int st = 0; st < starListJsonArray.length(); st++) {
            JSONObject starJsonObject = starListJsonArray.getJSONObject(st);

            JSONParser<StarData> starParser = new JSONParser<>(StarData.class);

            StarData star = starParser.Convert(starJsonObject);

            star.stuffOrbitingAround = GetStuffOrbitingAround(starJsonObject);

            stars.add(star);
        }

        return stars;
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
