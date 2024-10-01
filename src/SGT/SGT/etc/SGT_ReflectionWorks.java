package SGT.SGT.etc;

import SGT.SGT.Helpers.VeBlib_Logger;

import java.awt.image.BufferedImage;
import java.lang.invoke.MethodHandle;
import java.lang.invoke.MethodHandles;
import java.lang.invoke.MethodType;
import java.lang.reflect.Constructor;

public class SGT_ReflectionWorks {
    //made by looking at ReflectionUtils code, except thats on k*tlin
    public static String GetVariableName(Object field) throws Throwable {
        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Field Class - Get Variable Name");
        final Class<?> fieldClass = Class.forName("java.lang.reflect.Field", false, Class.class.getClassLoader());

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Find Virtual - Set Access");
        final MethodHandle setAccessMethod = MethodHandles.lookup().findVirtual(fieldClass, "setAccessible", MethodType.methodType(void.class, boolean.class));

        setAccessMethod.invoke(field, true);

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Name Method");
        final MethodHandle getNameMethod = MethodHandles.lookup().findVirtual(fieldClass, "getName", MethodType.methodType(String.class));

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Name Method - Invoke ");
        return getNameMethod.invoke(field).toString();
    }

    public static Class<?> GetVariableType(Object field) throws Throwable {
        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Field Class - Get Variable Type");
        final Class<?> fieldClass = Class.forName("java.lang.reflect.Field", false, Class.class.getClassLoader());

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Find Virtual - Set Access");
        final MethodHandle setAccessMethod = MethodHandles.lookup().findVirtual(fieldClass, "setAccessible", MethodType.methodType(void.class, boolean.class));

        setAccessMethod.invoke(field, true);

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Type Method");
        final MethodHandle getTypeMethod = MethodHandles.lookup().findVirtual(fieldClass, "getType", MethodType.methodType(Class.class));

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Type Method - Invoke ");
        return (Class<?>) getTypeMethod.invoke(field);
    }

    public static void SetVariable(Object field, Object thingToSetTo, Object setValue) throws Throwable {
        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get Field Class - Set Variable");
        final Class<?> fieldClass = Class.forName("java.lang.reflect.Field", false, Class.class.getClassLoader());

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Find Virtual - Set Access");
        final MethodHandle setAccessMethod = MethodHandles.lookup().findVirtual(fieldClass, "setAccessible", MethodType.methodType(void.class, boolean.class));

        setAccessMethod.invoke(field, true);

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Set Value Method");
        final MethodHandle setMethod = MethodHandles.lookup().findVirtual(fieldClass, "set", MethodType.methodType(void.class, Object.class, Object.class));

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Set Variable Method - Invoke ");
        setMethod.invoke(field, thingToSetTo, setValue);
    }

    public static BufferedImage GetBufferedImage(String filePath) throws Throwable {
        //https://www.baeldung.com/java-reflection

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get File Class");
        final Class<?> fileClass = Class.forName("java.io.File", false, Class.class.getClassLoader());
        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get File Constructor");
        Constructor<?> fileConstructor = fileClass.getConstructor(String.class);
        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Construct File Object");
        Object file = MethodHandles.lookup().findConstructor(fileClass, MethodType.methodType(void.class, String.class)).invoke((String) filePath);
//        Object file = (Object) fileConstructor.newInstance((String) filePath);


        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Get ImageIO Class");
        final Class<?> imageioClass = Class.forName("javax.imageio.ImageIO", true, Class.class.getClassLoader());

        VeBlib_Logger.log(SGT_ReflectionWorks.class, "Find Static - ImageIO Read");
        final MethodHandle imageioRead = MethodHandles.lookup().findStatic(imageioClass, "read", MethodType.methodType(BufferedImage.class, fileClass));
//        final MethodHandle setMethod = MethodHandles.lookup().findVirtual(fieldClass, "set", MethodType.methodType(void.class, Object.class, Object.class));

        BufferedImage image = (BufferedImage) imageioRead.invoke(file);

        return image;
    }

}
