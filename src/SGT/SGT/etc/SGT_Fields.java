package SGT.SGT.etc;

import java.lang.invoke.MethodHandle;
import java.lang.invoke.MethodHandles;
import java.lang.invoke.MethodType;
import java.lang.reflect.Field;

public class SGT_Fields {


    //made by looking at ReflectionUtils code, except thats on k*tlin
    public static String GetVariableName(Field field) throws Throwable {//its pretty funny you get exeption when you use the normal fuction but invoke works normally lmao
        final Class<?> fieldClass = Class.forName("java.lang.reflect.Field", true, Class.class.getClassLoader());
        final MethodHandle getNameMethod = MethodHandles.lookup().findVirtual(fieldClass, "getName", MethodType.methodType(String.class));


        return getNameMethod.invoke(field).toString();
    }

    public static Class<?> GetVariableType(Field field) throws Throwable {
        final Class<?> fieldClass = Class.forName("java.lang.reflect.Field", true, Class.class.getClassLoader());
        final MethodHandle getTypeMethod = MethodHandles.lookup().findVirtual(fieldClass, "getType", MethodType.methodType(Class.class));

        return (Class<?>) getTypeMethod.invoke(field);
    }

    public static void SetVariable(Field field,Object thingToSetTo,Object setValue) throws Throwable {
        final Class<?> fieldClass = Class.forName("java.lang.reflect.Field", true, Class.class.getClassLoader());
        final MethodHandle setMethod = MethodHandles.lookup().findVirtual(fieldClass, "set", MethodType.methodType(void.class,Object.class,Object.class));

        setMethod.invoke(field,thingToSetTo,setValue);
    }

}
