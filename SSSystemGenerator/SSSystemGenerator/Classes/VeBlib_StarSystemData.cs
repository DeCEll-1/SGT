using SSSystemGenerator.Classes.SystemFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes
{
    public class VeBlib_StarSystemData : Extend
    {

        public VeBlib_StarSystemData()
        {

            this.ID = "";

            this.systemX = 0;

            this.systemY = 0;

            this.backgroundTextureFilename = "";


            this.starList = new List<VeBlib_StarData> { };

            this.planetList = new List<VeBlib_PlanetData> { };

            this.marketList = new List<VeBlib_MarketData> { };

            //        this.WithJunkAndChatter= WithJunkAndChatter;
            //        this.PirateMode= PirateMode;

            this.astreoidBeltDataList = new List<VeBlib_AstreoidBeltData> { };
            this.ringBandDataList = new List<VeBlib_RingBandData> { };

            this.sectorEntityTokenList = new List<VeBlib_SectorEntittyTokenData> { };


            this.autoGenerateEntrancesAtGasGiants = false;

            this.autoGenerateFringeJumpPoint = false;
            this.generatePlanetConditions = false;

            this.minHyperspaceRadius = 0;


        }

        public VeBlib_StarSystemData(String systemID, String systemName, float systemX, float systemY, String backgroundTextureFilename, List<VeBlib_StarData> starList, List<VeBlib_PlanetData> planetList, List<VeBlib_MarketData> marketList, List<VeBlib_AstreoidBeltData> astreoidBeltDataList, List<VeBlib_RingBandData> ringBandDataList, List<VeBlib_SectorEntittyTokenData> sectorEntityTokenList, bool autoGenerateEntrancesAtGasGiants, bool autoGenerateFringeJumpPoint, bool generatePlanetConditions, float minHyperspaceRadius)
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


        public List<VeBlib_StarData> starList;

        public List<VeBlib_PlanetData> planetList;

        public List<VeBlib_MarketData> marketList;

        //    public ArrayList<Boolean> WithJunkAndChatter;//if its null will be false
        //    public ArrayList<Boolean> PirateMode;//if its null will be false

        public List<VeBlib_AstreoidBeltData> astreoidBeltDataList;
        public List<VeBlib_RingBandData> ringBandDataList;

        public List<VeBlib_SectorEntittyTokenData> sectorEntityTokenList;//anchors,custom entittys in Entities aka com.fs.starfarer.api.impl.campaign.ids;


        public bool autoGenerateEntrancesAtGasGiants;//for autogenerateHyperspaceJumpPoints

        public bool autoGenerateFringeJumpPoint;
        public bool generatePlanetConditions;

        public float minHyperspaceRadius;

    }
}
