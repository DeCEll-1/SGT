using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void setupFiles()
        {
            FileInfo fi = new FileInfo(Statics.JSONPath);

            if (!fi.Exists)
            {
                if (!fi.Directory.Parent.Parent.Exists) fi.Directory.Parent.Create();
                if (!fi.Directory.Parent.Exists) fi.Directory.Create();
                fi.Create();
            }

            fileHelper.UpdateFileAttributes(Directory.GetParent(Statics.EXEPath).Parent.Parent);

        }

    }
}
