package SGT.SGT.SystemGeneration.systemFiles;

import java.util.ArrayList;
import java.util.List;

public class VeBlib_MarketData extends VeBlib_SGTExtend{

    public VeBlib_MarketData(String factionID,    String primaryEntity,    ArrayList<String> connectedEntities,    String name,    int size,    List<String> marketConditions,    List<String> submarkets,    List<String> industries,    Boolean WithJunkAndChatter,    Boolean PirateMode) {
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
    public ArrayList<String> connectedEntities;
    public String name;
    public int size;
    public List<String> marketConditions;
    public List<String> submarkets;
    public List<String> industries;
    public Boolean WithJunkAndChatter;
    public Boolean PirateMode;

}
