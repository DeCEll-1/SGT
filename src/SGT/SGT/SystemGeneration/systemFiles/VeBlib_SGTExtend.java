package SGT.SGT.SystemGeneration.systemFiles;

import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.sql.Array;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class VeBlib_SGTExtend {

    public int order = -1;


    public String GUID;

    public String ID;
    public String name;

    public float radius;

    public float bandWidthInEngine = 0; //ring band

    public float width = 0;//astreoid belt


    public String systemID;
    public String systemGUID;

    public float x;
    public float y;

    public String focusID;//"" for center
    public String[] stuffOrbitingAround ;
    public String typeID;

    public String WhatIsThis;

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

    public void CreateObject(VeBlib_StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i){

    }

}
