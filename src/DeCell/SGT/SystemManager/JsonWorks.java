package DeCell.SGT.SystemManager;

import DeCell.SGT.Helpers.JsonHelper;
import DeCell.SGT.Parser.ImageWorks;
import DeCell.SGT.Parser.JSONParser;
import DeCell.SGT.Parser.SystemMetadata;
import DeCell.SGT.Paths;
import DeCell.SGT.Reflection.ReflectionWorks;
import DeCell.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import com.fs.starfarer.api.Global;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.awt.image.BufferedImage;
import java.io.IOException;
import java.util.Arrays;
import java.util.List;

public class JsonWorks {

    // jdk.nashorn.internal.parser.JSONParser
    public static List<SystemMetadata> getSystemsMetadata(String source) throws JSONException, IOException {
        SystemMetadata[] result;
        JSONObject[] merged = JsonHelper.JSONArray2JSONObjectArray(Global.getSettings().getMergedJSON(Paths.SystemMetadatas).getJSONArray("SystemMetadatas"));
        JSONParser<SystemMetadata> parser = new JSONParser<>(SystemMetadata.class);
        try {
            result = parser.Convert(merged);
        } catch (Throwable e) {
            throw new RuntimeException(e);
        }
        return Arrays.asList(result);
    }

    public static VeBlib_StarSystemData getStarSystemData(SystemMetadata metadata) throws Throwable {
        String savedImagePathRoot = metadata.ImagePath;
        ImageWorks iw = new ImageWorks();
//get ze image
        BufferedImage image = ReflectionWorks.GetBufferedImage(savedImagePathRoot);
        // get ze json from ze image
        String systemJson = iw.BitmapToText(image, metadata.width, metadata.height);

        // do ze rest of ze parsing
        return getSystem(systemJson);


    }

    private static VeBlib_StarSystemData getSystem(String json) throws JSONException {
//get ze object
        JSONObject systemJsonObject = new JSONObject(json);


    }




















}
