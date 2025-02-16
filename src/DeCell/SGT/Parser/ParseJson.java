package DeCell.SGT.Parser;

import DeCell.SGT.SystemGeneration.systemFiles.*;
import DeCell.SGT.Helpers.VeBlib_Logger;
import DeCell.SGT.Reflection.ReflectionWorks;
import com.fs.graphics.Sprite;
import com.fs.starfarer.api.Global;
import com.fs.starfarer.api.graphics.SpriteAPI;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.awt.*;
import java.awt.image.BufferedImage;
import java.util.ArrayList;
import java.util.List;

import static org.lwjgl.opengl.GL11.glGetTexImage;
@Deprecated
public class ParseJson {

    /**
     * gets systems </br>
     *
     * @param path path to the system json
     */
    public static List<StarSystemData> GetJson(String path) throws Throwable { // path is the target to metadata
        VeBlib_Logger.log(ParseJson.class, "Getting Json - in function");

        VeBlib_Logger.log(ParseJson.class, "Init Metadata System List");
        List<SystemMetadata> systemMetadataList = new ArrayList<>();

        VeBlib_Logger.log(ParseJson.class, "Init System List");
        List<StarSystemData> systemList = new ArrayList<>();


        VeBlib_Logger.log(ParseJson.class, "Get SystemMetadata Json Object");
        JSONObject systemMetadataJson = Global.getSettings().getMergedJSON(path);

        JSONArray metadatas = systemMetadataJson.getJSONArray("SystemMetadatas");

        VeBlib_Logger.log(ParseJson.class, "Image Works Initilization");
        ImageWorks iw = new ImageWorks();

        VeBlib_Logger.log(ParseJson.class, "System For Start");
        for (int currMetadataNo = 0; currMetadataNo < metadatas.length(); currMetadataNo++) {
            JSONParser<SystemMetadata> metadataParser = new JSONParser<SystemMetadata>(SystemMetadata.class);
            SystemMetadata metadata = metadataParser.Convert(metadatas.getJSONObject(currMetadataNo));

            String savedImagePath = "data/strings/systems/" + metadata.ID + ".png";
            String savedImagePathRoot = metadata.ImagePath;
            Global.getSettings().loadTexture(savedImagePath);

            SpriteAPI systemImage = Global.getSettings().getSprite(savedImagePath);

            Sprite texture = new Sprite(savedImagePath);

            // https://stackoverflow.com/a/26111170/21149029 WE HAD A PARSER ALL ALONG ARE YOU FUCKİNG AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
//            BufferedImage image = (BufferedImage) texture.getTexture();
//            BufferedImage image = ImageIO.read((new File(savedImagePathRoot)));

            BufferedImage image = ReflectionWorks.GetBufferedImage(savedImagePathRoot);

//            String json = iw.BitmapToText(image, systemImage);

            String json = "";

            VeBlib_Logger.log(ParseJson.class, "Get System");
            JSONObject systemJsonObject = new JSONObject(json);

            VeBlib_Logger.log(ParseJson.class, "Parse System");
            JSONParser<StarSystemData> systemParser = new JSONParser<StarSystemData>(StarSystemData.class);

            VeBlib_Logger.log(ParseJson.class, "Convert System");
            StarSystemData system = systemParser.Convert(systemJsonObject);

            system.stuffOrbitingAround = GetStuffOrbitingAround(systemJsonObject);// :) // idk why i put smile here idk what this does nor how it does

            //region stars
            VeBlib_Logger.log(ParseJson.class, "Get Stars");
            JSONArray starListJsonArray = systemJsonObject.getJSONArray("starList");

            VeBlib_Logger.log(ParseJson.class, "Star For Start");
            for (int st = 0; st < starListJsonArray.length(); st++) {
                JSONObject starJsonObject = starListJsonArray.getJSONObject(st);

                JSONParser<StarData> starParser = new JSONParser<>(StarData.class);

                StarData star = starParser.Convert(starJsonObject);

                star.stuffOrbitingAround = GetStuffOrbitingAround(starJsonObject);

                system.starList.add(star);
            }
            //endregion

            //region planets
            VeBlib_Logger.log(ParseJson.class, "Get Planet List");
            JSONArray planetsJsonArray = systemJsonObject.getJSONArray("planetList");

            for (int pl = 0; pl < planetsJsonArray.length(); pl++) {
                JSONObject planetJsonObject = planetsJsonArray.getJSONObject(pl);

                JSONParser<PlanetData> planetParser = new JSONParser<>(PlanetData.class);

                PlanetData planet = planetParser.Convert(planetJsonObject);

                planet.stuffOrbitingAround = GetStuffOrbitingAround(planetJsonObject);

                system.planetList.add(planet);
            }
            //endregion

            //region markets
            VeBlib_Logger.log(ParseJson.class, "Get Market List");
            JSONArray marketJsonArray = systemJsonObject.getJSONArray("marketList");

            for (int ma = 0; ma < marketJsonArray.length(); ma++) {
                JSONObject marketJsonObject = marketJsonArray.getJSONObject(ma);

                JSONParser<MarketData> marketParser = new JSONParser<>(MarketData.class);

                MarketData market = marketParser.Convert(marketJsonObject);

                market.stuffOrbitingAround = GetStuffOrbitingAround(marketJsonObject);//wont do shit but no reson to remove either

                system.marketList.add(market);
            }
            //endregion

            //region astreoids
            VeBlib_Logger.log(ParseJson.class, "Get Astreoid Belt List");
            JSONArray astreoidJsonArray = systemJsonObject.getJSONArray("astreoidBeltDataList");

            for (int as = 0; as < astreoidJsonArray.length(); as++) {
                JSONObject astreoidJsonObject = astreoidJsonArray.getJSONObject(as);

                JSONParser<AstreoidBeltData> marketParser = new JSONParser<>(AstreoidBeltData.class);

                AstreoidBeltData astreoidBelt = marketParser.Convert(astreoidJsonObject);

                astreoidBelt.stuffOrbitingAround = GetStuffOrbitingAround(astreoidJsonObject);

                system.astreoidBeltDataList.add(astreoidBelt);
            }
            //endregion

            //region ringBands
            VeBlib_Logger.log(ParseJson.class, "Get Ring Band List");
            JSONArray ringBandJsonArray = systemJsonObject.getJSONArray("ringBandDataList");

            for (int ri = 0; ri < ringBandJsonArray.length(); ri++) {
                JSONObject ringBandJsonObject = ringBandJsonArray.getJSONObject(ri);

                JSONParser<RingBandData> ringBandParser = new JSONParser<>(RingBandData.class);

                RingBandData ringBand = ringBandParser.Convert(ringBandJsonObject);

                ringBand.stuffOrbitingAround = GetStuffOrbitingAround(ringBandJsonObject);

                String[] colorsStr = ringBand.color.split(",");

                int[] colors = Str2IntArray(colorsStr);

                if (colors.length == 4) ringBand.colorColor = new Color(colors[1], colors[2], colors[3], colors[0]);
                if (colors.length == 3) ringBand.colorColor = new Color(colors[0], colors[1], colors[2]);


                system.ringBandDataList.add(ringBand);
            }
            //endregion

            //region sectorEntityToken
            VeBlib_Logger.log(ParseJson.class, "Get Sector Entity Token List");
            JSONArray sectorEntityTokenJsonArray = systemJsonObject.getJSONArray("sectorEntityTokenList");

            for (int set = 0; set < sectorEntityTokenJsonArray.length(); set++) {
                JSONObject sectorEntityTokenJsonObject = sectorEntityTokenJsonArray.getJSONObject(set);

                JSONParser<SectorEntittyTokenData> sectorEntityTokenParser = new JSONParser<>(SectorEntittyTokenData.class);

                SectorEntittyTokenData sectorEntityToken = sectorEntityTokenParser.Convert(sectorEntityTokenJsonObject);

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
