﻿using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class BaseClass
    {

        public BaseClass()
        {
            StarSystemDataList = new List<VeBlib_StarSystemData>();
        }

        public List<VeBlib_StarSystemData> StarSystemDataList { get; set; } = new List<VeBlib_StarSystemData> { };




    }
}
