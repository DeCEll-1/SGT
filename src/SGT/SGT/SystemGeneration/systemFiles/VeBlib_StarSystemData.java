package SGT.SGT.SystemGeneration.systemFiles;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class VeBlib_StarSystemData extends VeBlib_SGTExtend {

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

        orderHashMap = new HashMap<>();

        List<Object> everything = new ArrayList<>();

        everything.addAll(astreoidBeltDataList);
        everything.addAll(marketList);
        everything.addAll(starList);
        everything.addAll(planetList);
        everything.addAll(ringBandDataList);
        everything.addAll(sectorEntityTokenList);

        for (int i = 0; i < astreoidBeltDataList.size() + marketList.size() + planetList.size() + ringBandDataList.size() + starList.size() + sectorEntityTokenList.size(); i++) {

            if (everything.get(i) instanceof VeBlib_StarData) {
                VeBlib_StarData starData = (VeBlib_StarData) orderHashMap.get(i);
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

        orderHashMap = new HashMap<>();

        List<Object> everything = new ArrayList<>();

        everything.addAll(astreoidBeltDataList);
        everything.addAll(marketList);
        everything.addAll(starList);
        everything.addAll(planetList);
        everything.addAll(ringBandDataList);
        everything.addAll(sectorEntityTokenList);

        for (int i = 0; i < astreoidBeltDataList.size() + marketList.size() + planetList.size() + ringBandDataList.size() + starList.size() + sectorEntityTokenList.size(); i++) {

            if (everything.get(i) instanceof VeBlib_StarData) {
                VeBlib_StarData starData = (VeBlib_StarData) orderHashMap.get(i);
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

    public HashMap<Integer, Object> orderHashMap;

    public String ID;
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


    public boolean autoGenerateEntrancesAtGasGiants;//for autogenerateHyperspaceJumpPoints

    public boolean autoGenerateFringeJumpPoint;
    public boolean generatePlanetConditions;

    public float minHyperspaceRadius;

}
