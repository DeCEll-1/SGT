using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSystemGenerator.Classes
{
    public class fileHelper
    {

        public static void UpdateFileAttributes(DirectoryInfo dInfo)
        {
            //https://stackoverflow.com/questions/17273650/setting-file-attributes-recursively-subfolders
            // Set Directory attribute
            dInfo.Attributes &= ~FileAttributes.ReadOnly;

            // get list of all files in the directory and clear 
            // the Read-Only flag

            foreach (FileInfo file in dInfo.GetFiles())
            {
                file.Attributes &= ~FileAttributes.ReadOnly;
            }

            // recurse all of the subdirectories
            foreach (DirectoryInfo subDir in dInfo.GetDirectories())
            {
                UpdateFileAttributes(subDir);
            }
        }

        public static void SetupFiles()
        {
            FileInfo fi = new FileInfo(Statics.JSONPath.FullName);

            if (!fi.Exists)
            {
                if (!fi.Directory.Parent.Parent.Exists) fi.Directory.Parent.Create();
                if (!fi.Directory.Parent.Exists) fi.Directory.Create();
                fi.Create();
            }

            //this is so that when you dont run as admin you can still use the app (atleast thats what i remember of what this does),
            //but it runs every time this function runs which takes a lot of time and i dont really wanna find a way to make it faster
            //TODO: make this faster so the app haves a higher chance to run without admin, not neccessary, or however you spell that
            //fileHelper.UpdateFileAttributes(Directory.GetParent(Statics.EXEPath.FullName).Parent.Parent);

        }

        public static void UpdateStaticWithSystemJson()
        {
            BaseClass baseClass = JsonHelper.GetBaseClassFromJsonFile(Statics.JSONPath.FullName) as BaseClass;

            if (baseClass == null)
            {

                Statics.SGTBaseMDIContainer.Invoke((MethodInvoker)delegate
                {
                    Statics.SGTBaseMDIContainer.saveToolStripMenuItem_Click(null, null);
                });
                
                return;

            }
            Statics.baseClass = baseClass;

        }

    }
}
