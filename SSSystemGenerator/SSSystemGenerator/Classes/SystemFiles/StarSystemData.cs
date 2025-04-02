using Newtonsoft.Json;
using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class StarSystemData : Extend , ICloneable
    {

        public StarSystemData()
        {

            this.ID = "";

            this.systemX = 0;

            this.systemY = 0;

            this.backgroundTextureFilename = "";


            this.starList = new List<StarData> { };

            this.planetList = new List<PlanetData> { };

            this.marketList = new List<MarketData> { };

            //        this.WithJunkAndChatter= WithJunkAndChatter;
            //        this.PirateMode= PirateMode;

            this.astreoidBeltDataList = new List<AstreoidBeltData> { };
            this.ringBandDataList = new List<RingBandData> { };

            this.sectorEntityTokenList = new List<SectorEntittyTokenData> { };


            this.autoGenerateEntrancesAtGasGiants = false;

            this.autoGenerateFringeJumpPoint = false;
            this.generatePlanetConditions = false;

            this.minHyperspaceRadius = 0;


        }

        public StarSystemData(String systemID, String systemName, float systemX, float systemY, String backgroundTextureFilename, List<StarData> starList, List<PlanetData> planetList, List<MarketData> marketList, List<AstreoidBeltData> astreoidBeltDataList, List<RingBandData> ringBandDataList, List<SectorEntittyTokenData> sectorEntityTokenList, bool autoGenerateEntrancesAtGasGiants, bool autoGenerateFringeJumpPoint, bool generatePlanetConditions, float minHyperspaceRadius)
        {
            this.ID = systemID;

            this.systemName = systemName;

            this.systemX = systemX;

            this.systemY = systemY;

            this.backgroundTextureFilename = backgroundTextureFilename;


            this.starList = starList;

            this.planetList = planetList;

            this.marketList = marketList;

            //        this.WithJunkAndChatter= WithJunkAndChatter;
            //        this.PirateMode= PirateMode;

            this.astreoidBeltDataList = astreoidBeltDataList;
            this.ringBandDataList = ringBandDataList;

            this.sectorEntityTokenList = sectorEntityTokenList;


            this.autoGenerateEntrancesAtGasGiants = autoGenerateEntrancesAtGasGiants;

            this.autoGenerateFringeJumpPoint = autoGenerateFringeJumpPoint;
            this.generatePlanetConditions = generatePlanetConditions;

            this.minHyperspaceRadius = minHyperspaceRadius;

        }

        public String systemName;

        public float systemX;

        public float systemY;

        public String backgroundTextureFilename;

        public List<StarData> starList;

        public List<PlanetData> planetList;

        public List<MarketData> marketList;

        //    public ArrayList<Boolean> WithJunkAndChatter;//if its null will be false
        //    public ArrayList<Boolean> PirateMode;//if its null will be false

        public List<AstreoidBeltData> astreoidBeltDataList;
        public List<RingBandData> ringBandDataList;

        public List<SectorEntittyTokenData> sectorEntityTokenList;//anchors,custom entittys in Entities aka com.fs.starfarer.api.impl.campaign.ids;


        public bool autoGenerateEntrancesAtGasGiants;//for autogenerateHyperspaceJumpPoints

        public bool autoGenerateFringeJumpPoint;
        public bool generatePlanetConditions;

        public float minHyperspaceRadius;

        [Newtonsoft.Json.JsonIgnore]
        public Bitmap systemImage;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
