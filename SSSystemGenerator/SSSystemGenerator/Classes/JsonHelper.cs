using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace SSSystemGenerator.Classes
{
    public class JsonHelper
    {

        public static Task SerialiseToBaseJSONFile(BaseClass baseClass, IProgress<int> progress, string jsonPath)
        {
            return Task.Run(() => SerialiseToBaseJSONFilePrivate(baseClass, progress, jsonPath));
        }//is not used because switched to threads

        public static bool saving { get; set; } = false;

        private static void SerialiseToBaseJSONFilePrivate(BaseClass baseClass, IProgress<int> progress, string jsonPath)
        {

            if (saving) { MessageBox.Show("saving"); return; }

            saving = true;

            SGTBaseMDIContainer form = Statics.SGTBaseMDIContainer;

            UpdateMDIFormSavingStatusLabel("Setting up files");
            fileHelper.SetupFiles();

            UpdateMDIFormSavingStatusLabel("Parsing To Json");
            String jsonString = SerialiseToJson(baseClass);

            UpdateMDIFormSavingStatusLabel("Getting Json File Info");
            FileInfo saveFile = new FileInfo(jsonPath);

            string saveFilePath = saveFile.FullName;

            if (!saveFile.Exists)
            {
                saveFile.Create();
            }

            UpdateMDIFormSavingStatusLabel("Generating Temp File");
            string tempFilePath = Path.GetTempFileName();

            UpdateMDIFormSavingStatusLabel("Starting Stream Writer");
            using (StreamWriter fs = new StreamWriter(tempFilePath))//write to temp file
            {//https://stackoverflow.com/questions/668907/how-to-delete-a-line-from-a-text-file-in-c

                string[] lines = jsonString.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);


                for (int i = 0; i < lines.Length; i++)
                {
                    fs.WriteLine(lines[i]);

                    int completionPercent = (int)(((float)i / (float)lines.Length) * 100f);

                    //progress.Report(completionPercent);//not used

                    //https://stackoverflow.com/questions/661561/how-do-i-update-the-gui-from-another-thread
                    //this thing is hot, really, i love this, i wanna marry this, such a beauty
                    form.Invoke((MethodInvoker)delegate
                    {
                        Statics.SGTBaseMDIContainer.UpdateSaving((byte)completionPercent);
                    });




                    //https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/create-thread
                    Thread.Sleep(1);//wait by 0.01 seconds aka 10 miliseconds
                }

            }

            if (progress != null) progress.Report(100);


            File.Delete(saveFilePath);

            File.Move(tempFilePath, saveFilePath);

            saving = false;

            if (Statics.CloseTheForm) Misc.FireMethodOnDifferentThread(Statics.SGTBaseMDIContainer, Statics.SGTBaseMDIContainer.GetType(), "Close", new object[0]);

        }

        private static void UpdateMDIFormSavingStatusLabel(string text)
        {
            Statics.SGTBaseMDIContainer.Invoke((MethodInvoker)delegate
            {
                Statics.SGTBaseMDIContainer.TSSL_Saving.Text = text;
            });
        }

        public static String SerialiseToJson(BaseClass baseClass)
        {
            return JsonConvert.SerializeObject(baseClass, Formatting.Indented);
        }

        public static BaseClass GetBaseClassFromJsonFile(string path)
        {

            Misc.WaitUntilSaveEnds();

            using (StreamReader sr = new StreamReader(path))
            {

                string json = sr.ReadToEnd();

                return JsonConvert.DeserializeObject<BaseClass>(json);
            }


        }

    }
}
