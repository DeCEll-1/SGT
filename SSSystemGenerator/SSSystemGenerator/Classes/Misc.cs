using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Classes
{
    public class Misc
    {

        public static void WaitUntilSaveEnds()
        {
            if (Statics.SGTBaseMDIContainer.thread != null) Statics.SGTBaseMDIContainer.thread.Join(20);

        }

        public static void FireMethodOnDifferentThread(object thingToInvokeIn, Type t, string methodToRun, object[] myParams)
        {
            MethodInfo invokeOnDifferentThread = t.GetMethod("Invoke", new[] { typeof(Delegate) });//get the Invoke for the objects thread

            MethodInfo methodToRunI = t.GetMethod(methodToRun);//get the thing we want to run

            object methodInvokerDelegate = (MethodInvoker)delegate { methodToRunI.Invoke(thingToInvokeIn, myParams); };

            invokeOnDifferentThread.Invoke(thingToInvokeIn, new object[1] { methodInvokerDelegate });
        }

        public static void SetDoubleBuffer(Panel panel, bool DoubleBuffered)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
           | BindingFlags.Instance | BindingFlags.NonPublic, null,
           panel, new object[] { DoubleBuffered });
        }

    }
}
