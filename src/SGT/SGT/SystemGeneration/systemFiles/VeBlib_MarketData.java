package SGT.SGT.SystemGeneration.systemFiles;

import java.util.ArrayList;
import java.util.List;

public class VeBlib_MarketData extends VeBlib_SGTExtend {

    public VeBlib_MarketData() {
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

    public VeBlib_MarketData(String factionID, String primaryEntity, List<String> connectedEntities, String name, byte size, List<String> marketConditions, List<String> submarkets, List<String> industries, Boolean WithJunkAndChatter, Boolean PirateMode) {
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
