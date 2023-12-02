package SGT.SGT.SystemGeneration.systemFiles;

public class VeBlib_StarData extends VeBlib_SGTExtend {

    //region overloads
    public VeBlib_StarData(String ID, String typeID, String focusID, float radius, float coronaSize) {
        this.ID = ID;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;

    }

    public VeBlib_StarData(String ID, String typeID, String focusID, float radius, float coronaSize, float windBurnLevel, float flareProbability, float crLossMult) {
        this.ID = ID;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;
        this.windBurnLevel = windBurnLevel;
        this.flareProbability = flareProbability;
        this.crLossMult = crLossMult;
    }

    public VeBlib_StarData(String ID, String name, String typeID, String focusID, float radius, float coronaSize) {
        this.ID = ID;
        this.name = name;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;

    }

    public VeBlib_StarData(String ID, String name, String typeID, String focusID, float radius, float coronaSize, float windBurnLevel, float flareProbability, float crLossMult) {
        this.ID = ID;
        this.name = name;
        this.typeID = typeID;
        this.focusID = focusID;
        this.radius = radius;
        this.coronaSize = coronaSize;
        this.windBurnLevel = windBurnLevel;
        this.flareProbability = flareProbability;
        this.crLossMult = crLossMult;
    }


    //endregion


    public String ID;//unique id
    public String name;//its name
    public String focusID;//"" for center
    public float radius;//radius of the star
    public float coronaSize;//size of the covid-1984
    public float windBurnLevel = -1;//idk mayn star things
    public float flareProbability = -1;//idk mayn star things
    public float crLossMult = -1;//how much crd does the thing loss when inside teh corona, probably (give it negative numbers or fake n gay)


}
