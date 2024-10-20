package DeCell.SGT.Helpers;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

public class JsonHelper {

    public static JSONObject[] JSONArray2JSONObjectArray(JSONArray array) throws JSONException {
        JSONObject[] result = new JSONObject[array.length()];
        for (int i = 0; i < array.length(); i++) {
            result[i] = array.getJSONObject(i);
        }
        return result;
    }


}
