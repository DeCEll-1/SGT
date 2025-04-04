package DeCell.SGT.SystemGeneration.systemFiles;

import DeCell.SGT.Helpers.VeBlib_Logger;
import DeCell.SGT.SystemGeneration.VeBlib_AddMarket;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;
import com.fs.starfarer.api.campaign.econ.MarketAPI;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class MarketData extends SGTExtend {

    public MarketData() {
        this.factionID = "";
        this.primaryEntity = "";
        this.connectedEntities = new ArrayList<>();
        this.name = "";
        this.size = 0;
        this.marketConditions = new ArrayList<>();
        this.submarkets = new ArrayList<>();
        this.industries = new ArrayList<>();
        this.WithJunkAndChatter = false;
        this.PirateMode = false;
    }

    public MarketData(String factionID, String primaryEntity, List<String> connectedEntities, String name, byte size, List<String> marketConditions, List<String> submarkets, List<String> industries, Boolean WithJunkAndChatter, Boolean PirateMode) {
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

    public void CreateObject(StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, MarketData marketData){
        VeBlib_Logger.log(this.getClass(), "market " + marketData.name);


//                boolean currentWithJunkAndChatter = false;

//                if (WithJunkAndChatterIterator.hasNext()) {
//                    currentWithJunkAndChatter = (boolean) WithJunkAndChatterIterator.next();
//                }
//
//                boolean PirateMode = false;
//
//                if (PirateModeIterator.hasNext()) {
//                    PirateMode = (boolean) PirateModeIterator.next();
//                }
        ArrayList<String> marketDataConditionAList = new ArrayList<>();
        marketDataConditionAList.addAll(marketData.marketConditions);

        ArrayList<String> marketDataSubmarketList = new ArrayList<>();
        marketDataSubmarketList.addAll(marketData.submarkets);

        ArrayList<String> marketDataIndustriesList = new ArrayList<>();
        marketDataIndustriesList.addAll(marketData.industries);

        ArrayList<SectorEntityToken> connectedEntittys = new ArrayList<>();

        for (String entittyID : marketData.connectedEntities) {
            connectedEntittys.add(SectorEntittyTokenHashMap.get(entittyID));
        }

        VeBlib_Logger.log(this.getClass(), "generate market");
        if (marketData.ID.equals(""))//doesnt have an id
        {
            VeBlib_Logger.log(this.getClass(), "primary entity: " + marketData.primaryEntity);
            VeBlib_Logger.log(this.getClass(), "connected entities: " + connectedEntittys);
            VeBlib_Logger.log(this.getClass(), "conditions: " + marketDataConditionAList);
            VeBlib_Logger.log(this.getClass(), "submarkets: " + marketDataSubmarketList);
            VeBlib_Logger.log(this.getClass(), "industries: " + industries);
            MarketAPI market = VeBlib_AddMarket.addMarketplace(
                    marketData.factionID,
                    SectorEntittyTokenHashMap.get(marketData.primaryEntity),
                    connectedEntittys,
                    marketData.name,
                    marketData.size,
                    marketDataConditionAList,
                    marketDataSubmarketList,
                    marketDataIndustriesList,
                    marketData.WithJunkAndChatter,
                    marketData.PirateMode
            );
        } else {//haves an id
            VeBlib_Logger.log(this.getClass(), "primary entity: " + marketData.primaryEntity);
            VeBlib_Logger.log(this.getClass(), "connected entities: " + connectedEntittys);
            VeBlib_Logger.log(this.getClass(), "conditions: " + marketDataConditionAList);
            VeBlib_Logger.log(this.getClass(), "submarkets: " + marketDataSubmarketList);
            VeBlib_Logger.log(this.getClass(), "industries: " + industries);
            MarketAPI market = VeBlib_AddMarket.addMarketplace(
                    marketData.ID,
                    marketData.factionID,
                    SectorEntittyTokenHashMap.get(marketData.primaryEntity),
                    connectedEntittys,
                    marketData.name,
                    marketData.size,
                    marketDataConditionAList,
                    marketDataSubmarketList,
                    marketDataIndustriesList,
                    marketData.WithJunkAndChatter,
                    marketData.PirateMode
            );
        }
    }

}
