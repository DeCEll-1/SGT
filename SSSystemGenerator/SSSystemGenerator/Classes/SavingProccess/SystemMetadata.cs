using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class SystemMetadata
    {

        public SystemMetadata(string ID, string ImagePath, int width, int height)
        {
            this.ID = ID;
            this.ImagePath = ImagePath;
            this.width = width;
            this.height = height;
        }

        public string ID;
        public string ImagePath;
        public int width;
        public int height;
    }
}
