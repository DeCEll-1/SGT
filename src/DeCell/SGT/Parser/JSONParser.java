package DeCell.SGT.Parser;

import DeCell.SGT.Helpers.VeBlib_Logger;
import DeCell.SGT.Reflection.ReflectionWorks;
import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Array;
import java.lang.reflect.Field;

//@Deprecated
public class JSONParser<T> {

    //    @Deprecated
    private Class<T> clazz;

    //    @Deprecated
    public JSONParser(Class<T> clazz) {
        this.clazz = clazz;
    }

    //    @Deprecated
    public T Convert(JSONObject jsonObject) throws Throwable {
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
                String fieldName = ReflectionWorks.GetVariableName(field);//get the name of the variable
                VeBlib_Logger.log(this.getClass(), "Get the variable class");
                Class<?> fieldClass = ReflectionWorks.GetVariableType(field);//fields class

//                String stringClass = String.class.getSimpleName();
//                String chClass = char.class.getSimpleName();
//                String intClass = int.class.getSimpleName();
//                String floatClass = float.class.getSimpleName();
//                String doubleClass = double.class.getSimpleName();
//                String longClass = long.class.getSimpleName();
//                String shortClass = short.class.getSimpleName();
//                String booleanClass = boolean.class.getSimpleName();

                VeBlib_Logger.log(this.getClass(), "Get fields simple name");
                String fieldClassName = fieldClass.getSimpleName();//float and stuff

                VeBlib_Logger.log(this.getClass(), "Assigning Field To " + fieldName + " : " + fieldClassName + " For Class " + clazz.getSimpleName());

                switch (fieldClassName) {
                    case "boolean":
                        ReflectionWorks.SetVariable(field, TVariable, jsonObject.getBoolean(fieldName));
//                    field.setBoolean(TVariable, jsonObject.getBoolean(fieldName));
                        break;
                    case "float":
                        ReflectionWorks.SetVariable(field, TVariable, (float) jsonObject.getDouble(fieldName));
//                    field.setFloat(TVariable, (float) jsonObject.getDouble(fieldName));
                        break;
                    case "double":
                        ReflectionWorks.SetVariable(field, TVariable, jsonObject.getDouble(fieldName));
//                    field.setDouble(TVariable, jsonObject.getDouble(fieldName));
                        break;
                    case "byte"://because i love bytes
                        ReflectionWorks.SetVariable(field, TVariable, (byte) jsonObject.getInt(fieldName));
//                    field.setByte(TVariable, (byte) jsonObject.getInt(fieldName));
                        break;
                    case "int":
                        ReflectionWorks.SetVariable(field, TVariable, jsonObject.getInt(fieldName));
//                    field.setInt(TVariable, jsonObject.getInt(fieldName));
                        break;
                    case "long":
                        ReflectionWorks.SetVariable(field, TVariable, jsonObject.getLong(fieldName));
//                    field.setLong(TVariable, jsonObject.getLong(fieldName));
                        break;
                    case "short":
                        ReflectionWorks.SetVariable(field, TVariable, (short) jsonObject.getInt(fieldName));
//                    field.setShort(TVariable, (short) jsonObject.getInt(fieldName));
                        break;
                    case "char":
                        ReflectionWorks.SetVariable(field, TVariable, jsonObject.getString(fieldName).toCharArray()[0]);
//                    field.setChar(TVariable, jsonObject.getString(fieldName).toCharArray()[0]);
                        break;
                    case "String":
                        ReflectionWorks.SetVariable(field, TVariable, jsonObject.getString(fieldName));
//                    field.set(TVariable, jsonObject.getString(fieldName));
                        break;
                    default:

                        VeBlib_Logger.log(this.getClass(), "Error Assigning Field To " + fieldName + " : " + fieldClassName + " For Class " + clazz.getSimpleName());

//                      https://stackoverflow.com/a/21789658 // "it cant be run at runtime so sowwy 3:"
//                      JSONParser < Class.forName(fieldClassName) > s = new JSONParser<Class.forName(fieldClassName) > ();

//                      field.set(TVariable, jsonObject.getJSONObject(fieldName));

                        break;

                }


            } catch (Exception ex) {
                VeBlib_Logger.log(this.getClass(), ex.toString());
            }
        }

        return TVariable;

    }

    @Deprecated // gives reflection error idk why
    public T[] Convert(JSONObject[] objects) throws Throwable {
        // ignore the warning
        T[] result = (T[]) Array.newInstance(clazz, objects.length);

        for (int i = 0; i < objects.length; i++) {
            result[i] = Convert(objects[i]);
        }

        return result;
    }

}
