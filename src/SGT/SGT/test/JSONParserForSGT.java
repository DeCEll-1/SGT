package SGT.SGT.test;

import SGT.SGT.SystemGeneration.systemFiles.VeBlib_StarSystemData;
import com.fs.starfarer.api.Global;
import com.fs.starfarer.api.impl.campaign.ids.Factions;
import com.sun.deploy.util.ReflectionUtil;
import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Field;

//@Deprecated
public class JSONParserForSGT<T> {

//    @Deprecated
    private Class<T> clazz;

//    @Deprecated
    public JSONParserForSGT(Class<T> clazz) {
        this.clazz = clazz;
    }

//    @Deprecated
    public T Convert(JSONObject jsonObject) throws InstantiationException, IllegalAccessException, JSONException {
//https://stackoverflow.com/a/2126722
        Field[] fields = clazz.getFields();

//        VeBlib_StarSystemData system = new VeBlib_StarSystemData();

        T TVariable = clazz.newInstance();

        //https://stackoverflow.com/a/1090488


        for (Field field : fields) {

            String fieldName = field.getName();//get the name of the variable
            Class<?> fieldClass = field.getType();//fields class

            String fieldClassName = fieldClass.getName();//float and stuff

            if (fieldClassName.equals("float")) fieldClassName = "double";

            switch (fieldClassName) {
                case "boolean":
                    field.setBoolean(TVariable, jsonObject.getBoolean(fieldName));
                    break;
                case "double":
                    field.setFloat(TVariable, (float) jsonObject.getDouble(fieldName));
                    break;
                case "byte"://because i love bytes
                    field.setByte(TVariable, (byte)jsonObject.getInt(fieldName));
                    break;
                case "int":
                    field.setInt(TVariable, jsonObject.getInt(fieldName));
                    break;
                case "long":
                    field.setLong(TVariable, jsonObject.getLong(fieldName));
                    break;
                case "string":
                    field.set(TVariable, jsonObject.getString(fieldName));
                    break;
                default:


                    //https://stackoverflow.com/a/21789658 // "it cant be run at runtime so sowwy 3:"
//                    JSONParserForSGT < Class.forName(fieldClassName) > s = new JSONParserForSGT<Class.forName(fieldClassName) > ();

//                    field.set(TVariable, jsonObject.getJSONObject(fieldName));

                    break;

            }

        }

        return TVariable;

    }


}

@Deprecated
enum variableNames {
    BOOLEAN,
    DOUBLE,
    INT,
    LONG,
    STRING;
}
