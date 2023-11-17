using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class VeBlib_MarketData : Extend
    {

        public VeBlib_MarketData()
        {
            this.factionID = "";
            this.primaryEntity = "";
            this.connectedEntities = new List<string>();
            this.name = "";
            this.size = 0;
            this.marketConditions = new List<string>();
            this.submarkets = new List<string>();
            this.industries = new List<string>();
            this.WithJunkAndChatter = false;
            this.PirateMode = false;
        }

        public VeBlib_MarketData(String factionID, String primaryEntity, List<String> connectedEntities, String name, byte size, List<String> marketConditions, List<String> submarkets, List<String> industries, Boolean WithJunkAndChatter, Boolean PirateMode)
        {
            this.factionID = factionID;
            this.primaryEntity = primaryEntity;
            this.connectedEntities = connectedEntities;
            this.name = name;
            this.size = size;
            this.marketConditions = marketConditions;
            this.submarkets = submarkets;
            this.industries = industries;
            this.WithJunkAndChatter = WithJunkAndChatter;
            this.PirateMode = PirateMode;
        }

        public String factionID;
        public String primaryEntity;
        public byte size;
        public List<String> connectedEntities;
        public List<String> marketConditions;
        public List<String> submarkets;
        public List<String> industries;
        public Boolean WithJunkAndChatter;
        public Boolean PirateMode;

    }
}
