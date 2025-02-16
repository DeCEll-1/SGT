package DeCell.SGT.SystemGeneration.systemFiles;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class StarSystemData extends SGTExtend {

    public StarSystemData() {

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

    public StarSystemData(String ID, float systemX, float systemY, String backgroundTextureFilename, List<StarData> starList, List<PlanetData> planetList, List<MarketData> marketList, List<AstreoidBeltData> astreoidBeltDataList, List<RingBandData> ringBandDataList, List<SectorEntittyTokenData> sectorEntityTokenList, boolean autoGenerateEntrancesAtGasGiants, boolean autoGenerateFringeJumpPoint, boolean generatePlanetConditions, float minHyperspaceRadius) {
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

    public StarSystemData(String ID, String systemName, float systemX, float systemY, String backgroundTextureFilename, List<StarData> starList, List<PlanetData> planetList, List<MarketData> marketList, List<AstreoidBeltData> astreoidBeltDataList, List<RingBandData> ringBandDataList, List<SectorEntittyTokenData> sectorEntityTokenList, boolean autoGenerateEntrancesAtGasGiants, boolean autoGenerateFringeJumpPoint, boolean generatePlanetConditions, float minHyperspaceRadius) {
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
        List<SGTExtend> everything = new ArrayList<>();

        AddToList(everything,astreoidBeltDataList);
        AddToList(everything,marketList);
        AddToList(everything,starList);
        AddToList(everything,planetList);
        AddToList(everything,ringBandDataList);
        AddToList(everything,sectorEntityTokenList);

        for (int i = 0; i < everything.size(); i++) {

            if (everything.get(i) instanceof StarData) {
                StarData starData = (StarData) everything.get(i);
                orderHashMap.put(starData.order, everything.get(i));
            }

            if (everything.get(i) instanceof PlanetData) {
                PlanetData planetData = (PlanetData) everything.get(i);
                orderHashMap.put(planetData.order, everything.get(i));
            }

            if (everything.get(i) instanceof SectorEntittyTokenData) {
                SectorEntittyTokenData sectorEntityTokenData = (SectorEntittyTokenData) everything.get(i);
                orderHashMap.put(sectorEntityTokenData.order, everything.get(i));
            }

            // no market cuz they got no order (practically)

            if (everything.get(i) instanceof AstreoidBeltData) {
                AstreoidBeltData astreoidData = (AstreoidBeltData) everything.get(i);
                orderHashMap.put(astreoidData.order, everything.get(i));
            }

            if (everything.get(i) instanceof RingBandData) {
                RingBandData ringBandData = (RingBandData) everything.get(i);
                orderHashMap.put(ringBandData.order, everything.get(i));
            }


        }
    }

    private void AddToList(List<SGTExtend> list, List<? extends SGTExtend> toAddList) {

        if (toAddList != null) list.addAll(toAddList);

    }

    public HashMap<Integer, SGTExtend> orderHashMap = new HashMap<>();

    public String systemName;

    public float systemX;

    public float systemY;

    public String backgroundTextureFilename;

    public List<StarData> starList = new ArrayList<>();

    public List<PlanetData> planetList = new ArrayList<>();

    public List<MarketData> marketList = new ArrayList<>();

    //    public ArrayList<Boolean> WithJunkAndChatter;//if its null will be false
    //    public ArrayList<Boolean> PirateMode;//if its null will be false

    public List<AstreoidBeltData> astreoidBeltDataList = new ArrayList<>();
    public List<RingBandData> ringBandDataList = new ArrayList<>();

    public List<SectorEntittyTokenData> sectorEntityTokenList;//anchors,custom entittys in Entities aka com.fs.starfarer.api.impl.campaign.ids;


    public boolean autoGenerateEntrancesAtGasGiants;//for autogenerateHyperspaceJumpPoints

    public boolean autoGenerateFringeJumpPoint;
    public boolean generatePlanetConditions;

    public float minHyperspaceRadius;

}
