package SGT.SGT.SystemGeneration.systemFiles;

public class VeBlib_SGTExtend {

    public int order;

    public float x;
    public float y;

    public String ID;

    public String typeID;
    public String focusID;

    public float angle;
    public float orbitRadius;
    public float orbitDays;
    public float minSpin;
    public float maxSpin;
    public int orbitLocationMode;
    //0 = setFixedLocation; only needs x and y other than neccessary stuff.
    //1 = setCircularOrbit; needs focusID;angle;orbitRadius;orbitDays;
    //2 = setCircularOrbitPointingDown; same as 1
    //3 = setCircularOrbitWithSpin; same as 1/2 just with minSpin  maxSpin additions

}
