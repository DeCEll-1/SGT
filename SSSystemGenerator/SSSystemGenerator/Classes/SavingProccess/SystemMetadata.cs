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

        public SystemMetadata(string ID, string ImagePath)
        {
            this.ID = ID;
            this.ImagePath = ImagePath;
        }

        public string ID;
        public string ImagePath;

    }
}
