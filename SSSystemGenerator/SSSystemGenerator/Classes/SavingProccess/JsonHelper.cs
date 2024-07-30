using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
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
using DataEmbeddingInImageTest;
using Newtonsoft.Json;
using SSSystemGenerator.Forms;
namespace SSSystemGenerator.Classes
{
    public class JsonHelper
    {

        //    //https://stackoverflow.com/questions/661561/how-do-i-update-the-gui-from-another-thread
        //    //this thing is hot, really, i love this, i wanna marry this, such a beauty
        //    form.Invoke((MethodInvoker)delegate
        //    {
        //        Statics.SGTBaseMDIContainer.UpdateSaving((byte)completionPercent);
        //    });

        // ok so FİRST
        // FUCKİNG get the systems into a DAMN bitmap, simple? not? just get the fucking panel and bitmap the system? you fucking idiot?

        public static Task SerialiseToBaseJSONFile(BaseClass baseClass, string jsonPath)
        { // do the setup of stuff here

            baseClass.StarSystemDataList.ForEach
                (system =>
                {

                    Map map = new Map();
                    system.systemImage = map.ReturnPanelImage();

                });

            return Task.Run(() => SerialiseToBaseJSONFilePrivate(baseClass, jsonPath));
        }

        public static bool saving { get; set; } = false;

        private static void SerialiseToBaseJSONFilePrivate(BaseClass baseClass, string jsonPath)
        {
            baseClass.GenerateMetadata();
            if (saving) { MessageBox.Show("saving"); return; }

            saving = true;

            SGTBaseMDIContainer form = Statics.SGTBaseMDIContainer;

            UpdateMDIFormSavingStatusLabel("Setting up files");
            fileHelper.SetupFiles();

            UpdateMDIFormSavingStatusLabel("Parsing SystemMetadata to Json");
            String jsonString = SerialiseToJson(baseClass.MetadataHolder);

            UpdateMDIFormSavingStatusLabel("Saving Metadata");
            SaveStringToFile(jsonString, jsonPath);

            UpdateMDIFormSavingStatusLabel("Saving Embedded Images");

            ImageWorks imageWorks = new ImageWorks(); // class with embedding / extracting functions

            baseClass.StarSystemDataList.ForEach(system =>
            {
                string systemString = SerialiseToJson(system); // we turn the system into string

                Bitmap embeddedImage = imageWorks.TextToBitmap(systemString, system.systemImage);

                embeddedImage.Save(Paths.SystemsFolder.FullName + "\\" + system.ID + ".png"); // why does it need \\systems again it already haves it

            });

            UpdateMDIFormSavingStatusLabel("Saved");
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

        public static String SerialiseToJson(VeBlib_StarSystemData system)
        {
            return JsonConvert.SerializeObject(system, Formatting.Indented);
        }

        public static String SerialiseToJson(MetadataHolder systemInfo)
        {
            return JsonConvert.SerializeObject(systemInfo, Formatting.Indented);
        }

        public static MetadataHolder GetSystemMetadataListFromJsonFile(string path)
        {
            Misc.WaitUntilSaveEnds();



            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();

                return JsonConvert.DeserializeObject<MetadataHolder>(json);
            }
        }

        public static VeBlib_StarSystemData GetSystemListFromJsonFile(string value)
        {
            Misc.WaitUntilSaveEnds();

            return JsonConvert.DeserializeObject<VeBlib_StarSystemData>(value);
        }

        public static void SaveStringToFile(string value, string path)
        {
            UpdateMDIFormSavingStatusLabel("Getting Json File Info");
            FileInfo saveFile = new FileInfo(path);

            string saveFilePath = saveFile.FullName;

            if (!saveFile.Exists)
            {
                saveFile.Create();
            }

            UpdateMDIFormSavingStatusLabel("Generating Temp File");
            string tempFilePath = Path.GetTempFileName();

            UpdateMDIFormSavingStatusLabel("Starting Stream Writer");

            using (StreamWriter fs = new StreamWriter(tempFilePath))
            { //write to temp file

                fs.WriteLine(value);

            }

            File.Delete(saveFilePath);

            File.Move(tempFilePath, saveFilePath);

        }

    }
}
