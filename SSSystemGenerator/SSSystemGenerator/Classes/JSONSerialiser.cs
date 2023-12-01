using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace SSSystemGenerator.Classes
{
    public class JSONSerialiser
    {

        public static Task SerialiseToBaseJSONFile(BaseClass baseClass, IProgress<int> progress)
        {
            return Task.Run(() => SerialiseToBaseJSONFilePrivate(baseClass, progress));
        }

        public static bool saving { get; set; } = false;

        private static async void SerialiseToBaseJSONFilePrivate(BaseClass baseClass, IProgress<int> progress)
        {

            if (saving) return;

            saving = true;

            fileHelper.setupFiles();


            String jsonString = SerialiseToJson(baseClass);

            FileInfo saveFile = new FileInfo(Statics.JSONPath.FullName);

            string saveFilePath = saveFile.FullName;

            if (!saveFile.Exists)
            {
                Helper.ThrowCrash("JSONSerialiser.cs", "SerialiseToBaseJSON");
            }

            string tempFilePath = Path.GetTempFileName();

            using (StreamWriter fs = new StreamWriter(tempFilePath))//write to temp file
            {//https://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c

                string[] lines = jsonString.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 0; i < lines.Length; i++)
                {
                    await fs.WriteLineAsync(lines[i]);

                    int reportValue = (int)(((float)i / (float)lines.Length) * 100f);

                    progress.Report(reportValue);
                }

            }

            progress.Report(100);

            File.Delete(saveFilePath);

            File.Move(tempFilePath, saveFilePath);

            saving = false;

        }

        public static String SerialiseToJson(BaseClass baseClass)
        {
            return JsonConvert.SerializeObject(baseClass, Formatting.Indented);
        }

    }
}
