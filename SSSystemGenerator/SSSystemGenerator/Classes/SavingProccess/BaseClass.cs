﻿using Newtonsoft.Json;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        public MetadataHolder MetadataHolder{ get; set; } = new MetadataHolder();

        public void GenerateMetadata()
        {
            this.MetadataHolder.SystemMetadatas.Clear();

            StarSystemDataList.ForEach(system =>
            {

                this.MetadataHolder.SystemMetadatas.Add(new SystemMetadata(system.ID, Paths.SystemsFolder.FullName + "\\" + system.ID + ".png"));

            });
        }

    }

    public class MetadataHolder // balls
    {
        public List<SystemMetadata> SystemMetadatas { get; set; } = new List<SystemMetadata> { };

    }

}
