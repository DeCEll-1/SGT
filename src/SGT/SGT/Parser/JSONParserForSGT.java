package SGT.SGT.Parser;

import SGT.SGT.Helpers.VeBlib_Logger;
import SGT.SGT.etc.SGT_Fields;
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
    public T Convert(JSONObject jsonObject) throws InstantiationException, IllegalAccessException, JSONException, Throwable {
//https://stackoverflow.com/a/2126722
        VeBlib_Logger.log(this.getClass(), "Getting Fields");
        Field[] fields = clazz.getFields();

//        VeBlib_StarSystemData system = new VeBlib_StarSystemData();
        VeBlib_Logger.log(this.getClass(), "Instancing Variable");
        T TVariable = clazz.newInstance();

        //https://stackoverflow.com/a/1090488


        VeBlib_Logger.log(this.getClass(), "Foreach fields");
        for (Field field : fields) {
            try {

                VeBlib_Logger.log(this.getClass(), "Get the name of the variable");
                String fieldName = SGT_Fields.GetVariableName(field);//get the name of the variable
                VeBlib_Logger.log(this.getClass(), "Get the variable class");
                Class<?> fieldClass = SGT_Fields.GetVariableType(field);//fields class

                String stringClass = String.class.getSimpleName();
                String chClass = char.class.getSimpleName();
                String intClass = int.class.getSimpleName();
                String floatClass = float.class.getSimpleName();
                String doubleClass = double.class.getSimpleName();
                String longClass = long.class.getSimpleName();
                String shortClass = short.class.getSimpleName();
                String booleanClass = boolean.class.getSimpleName();

                VeBlib_Logger.log(this.getClass(), "Get fields simple name");
                String fieldClassName = fieldClass.getSimpleName();//float and stuff

                VeBlib_Logger.log(this.getClass(), "Assigning Field To " + fieldName + " : " + fieldClassName + " For Class " + clazz.getSimpleName());

                switch (fieldClassName) {
                    case "boolean":
                        SGT_Fields.SetVariable(field, TVariable, jsonObject.getBoolean(fieldName));
//                    field.setBoolean(TVariable, jsonObject.getBoolean(fieldName));
                        break;
                    case "float":
                        SGT_Fields.SetVariable(field, TVariable, (float) jsonObject.getDouble(fieldName));
//                    field.setFloat(TVariable, (float) jsonObject.getDouble(fieldName));
                        break;
                    case "double":
                        SGT_Fields.SetVariable(field, TVariable, jsonObject.getDouble(fieldName));
//                    field.setDouble(TVariable, jsonObject.getDouble(fieldName));
                        break;
                    case "byte"://because i love bytes
                        SGT_Fields.SetVariable(field, TVariable, (byte) jsonObject.getInt(fieldName));
//                    field.setByte(TVariable, (byte) jsonObject.getInt(fieldName));
                        break;
                    case "int":
                        SGT_Fields.SetVariable(field, TVariable, jsonObject.getInt(fieldName));
//                    field.setInt(TVariable, jsonObject.getInt(fieldName));
                        break;
                    case "long":
                        SGT_Fields.SetVariable(field, TVariable, jsonObject.getLong(fieldName));
//                    field.setLong(TVariable, jsonObject.getLong(fieldName));
                        break;
                    case "short":
                        SGT_Fields.SetVariable(field, TVariable, (short) jsonObject.getInt(fieldName));
//                    field.setShort(TVariable, (short) jsonObject.getInt(fieldName));
                        break;
                    case "char":
                        SGT_Fields.SetVariable(field, TVariable, jsonObject.getString(fieldName).toCharArray()[0]);
//                    field.setChar(TVariable, jsonObject.getString(fieldName).toCharArray()[0]);
                        break;
                    case "String":
                        SGT_Fields.SetVariable(field, TVariable, jsonObject.getString(fieldName));
//                    field.set(TVariable, jsonObject.getString(fieldName));
                        break;
                    default:

                        VeBlib_Logger.log(this.getClass(), "Error Assigning Field To " + fieldName + " : " + fieldClassName + " For Class " + clazz.getSimpleName());

//                      https://stackoverflow.com/a/21789658 // "it cant be run at runtime so sowwy 3:"
//                      JSONParserForSGT < Class.forName(fieldClassName) > s = new JSONParserForSGT<Class.forName(fieldClassName) > ();

//                      field.set(TVariable, jsonObject.getJSONObject(fieldName));

                        break;

                }


            } catch (Exception ex) {
                VeBlib_Logger.log(this.getClass(), ex.toString());
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
