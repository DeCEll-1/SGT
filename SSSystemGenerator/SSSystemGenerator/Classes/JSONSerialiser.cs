using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace SSSystemGenerator.Classes
{
    public class JSONSerialiser
    {

        public static void serialiseToBaseJSON(BaseClass baseClass)
        {

            fileHelper.setupFiles();


            String jsonString = serialiseToJson(baseClass);



        }



        public static String serialiseToJson(BaseClass baseClass)
        {
            return JsonSerializer.Serialize(baseClass);
        }

    }
}
