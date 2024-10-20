package DeCell.SGT.SystemGeneration.systemFiles;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class VeBlib_StarSystemData extends VeBlib_SGTExtend {

    public VeBlib_StarSystemData() {

        this.ID = "";

        this.systemX = 0;

        this.systemY = 0;

        this.backgroundTextureFilename = "";


        this.starList = new ArrayList<>();

        this.planetList = new ArrayList<>();

        this.marketList = new ArrayList<>();

        //        this.WithJunkAndChatter= WithJunkAndChatter;
        //        this.PirateMode= PirateMode;

        this.astreoidBeltDataList = new ArrayList<>();
        this.ringBandDataList = new ArrayList<>();

        this.sectorEntityTokenList = new ArrayList<>();


        this.autoGenerateEntrancesAtGasGiants = false;

        this.autoGenerateFringeJumpPoint = false;
        this.generatePlanetConditions = false;

        this.minHyperspaceRadius = 0;


    }

    public VeBlib_StarSystemData(String ID, float systemX, float systemY, String backgroundTextureFilename, List<VeBlib_StarData> starList, List<VeBlib_PlanetData> planetList, List<VeBlib_MarketData> marketList, List<VeBlib_AstreoidBeltData> astreoidBeltDataList, List<VeBlib_RingBandData> ringBandDataList, List<VeBlib_SectorEntittyTokenData> sectorEntityTokenList, boolean autoGenerateEntrancesAtGasGiants, boolean autoGenerateFringeJumpPoint, boolean generatePlanetConditions, float minHyperspaceRadius) {
        this.ID = ID;

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

    public VeBlib_StarSystemData(String ID, String systemName, float systemX, float systemY, String backgroundTextureFilename, List<VeBlib_StarData> starList, List<VeBlib_PlanetData> planetList, List<VeBlib_MarketData> marketList, List<VeBlib_AstreoidBeltData> astreoidBeltDataList, List<VeBlib_RingBandData> ringBandDataList, List<VeBlib_SectorEntittyTokenData> sectorEntityTokenList, boolean autoGenerateEntrancesAtGasGiants, boolean autoGenerateFringeJumpPoint, boolean generatePlanetConditions, float minHyperspaceRadius) {
        this.ID = ID;

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

    public void GenerateOrderHasMap() {
        List<VeBlib_SGTExtend> everything = new ArrayList<>();

        AddToList(everything,astreoidBeltDataList);
        AddToList(everything,marketList);
        AddToList(everything,starList);
        AddToList(everything,planetList);
        AddToList(everything,ringBandDataList);
        AddToList(everything,sectorEntityTokenList);

        for (int i = 0; i < everything.size(); i++) {

            if (everything.get(i) instanceof VeBlib_StarData) {
                VeBlib_StarData starData = (VeBlib_StarData) everything.get(i);
                orderHashMap.put(starData.order, everything.get(i));
            }

            if (everything.get(i) instanceof VeBlib_PlanetData) {
                VeBlib_PlanetData planetData = (VeBlib_PlanetData) everything.get(i);
                orderHashMap.put(planetData.order, everything.get(i));
            }

            if (everything.get(i) instanceof VeBlib_SectorEntittyTokenData) {
                VeBlib_SectorEntittyTokenData sectorEntityTokenData = (VeBlib_SectorEntittyTokenData) everything.get(i);
                orderHashMap.put(sectorEntityTokenData.order, everything.get(i));
            }

            if (everything.get(i) instanceof VeBlib_MarketData) {
                VeBlib_MarketData marketData = (VeBlib_MarketData) everything.get(i);
                orderHashMap.put(marketData.order, everything.get(i));
            }

            if (everything.get(i) instanceof VeBlib_AstreoidBeltData) {
                VeBlib_AstreoidBeltData astreoidData = (VeBlib_AstreoidBeltData) everything.get(i);
                orderHashMap.put(astreoidData.order, everything.get(i));
            }

            if (everything.get(i) instanceof VeBlib_RingBandData) {
                VeBlib_RingBandData ringBandData = (VeBlib_RingBandData) everything.get(i);
                orderHashMap.put(ringBandData.order, everything.get(i));
            }


        }
    }

    private void AddToList(List<VeBlib_SGTExtend> list, List<? extends VeBlib_SGTExtend> toAddList) {

        if (toAddList != null) list.addAll(toAddList);

    }

    public HashMap<Integer, VeBlib_SGTExtend> orderHashMap = new HashMap<>();

    public String systemName;

    public float systemX;

    public float systemY;

    public String backgroundTextureFilename;

    public List<VeBlib_StarData> starList = new ArrayList<>();

    public List<VeBlib_PlanetData> planetList = new ArrayList<>();

    public List<VeBlib_MarketData> marketList = new ArrayList<>();

    //    public ArrayList<Boolean> WithJunkAndChatter;//if its null will be false
    //    public ArrayList<Boolean> PirateMode;//if its null will be false

    public List<VeBlib_AstreoidBeltData> astreoidBeltDataList = new ArrayList<>();
    public List<VeBlib_RingBandData> ringBandDataList = new ArrayList<>();

    public List<VeBlib_SectorEntittyTokenData> sectorEntityTokenList;//anchors,custom entittys in Entities aka com.fs.starfarer.api.impl.campaign.ids;


    public boolean autoGenerateEntrancesAtGasGiants;//for autogenerateHyperspaceJumpPoints

    public boolean autoGenerateFringeJumpPoint;
    public boolean generatePlanetConditions;

    public float minHyperspaceRadius;

}
