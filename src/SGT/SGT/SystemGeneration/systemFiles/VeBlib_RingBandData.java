package SGT.SGT.SystemGeneration.systemFiles;

import SGT.SGT.Helpers.VeBlib_Logger;
import com.fs.starfarer.api.campaign.SectorEntityToken;
import com.fs.starfarer.api.campaign.StarSystemAPI;

import java.awt.*;
import java.util.HashMap;

public class VeBlib_RingBandData extends VeBlib_SGTExtend {

    public VeBlib_RingBandData() {
        this.ID = "";//id of the band useless because bands arent used in anything USELESS https://ih1.redbubble.net/image.358838235.6847/raf,360x360,075,t,fafafa:ca443f4786.jpg
        //then why its here? maybe it will be used lol just put null
        this.focusID = "";
        this.category = "";//the category in the config/settings.json, misc is recommended its at line 1077,
        //try putting wormhole_ring2 lmao what can go wrong after all :xdd:
        this.key = "";//texture id, idk why its named key :taxevasion:
        this.bandWidthInTexture = 0;
        this.bandIndex = 0;//idfk what this is the default system i got from the fat fetishist is 1 and there arent any comments on it so use 1
        this.color = "255, 255, 0, 0";
        this.colorColor = Color.red;//colour tint, end text
        this.bandWidthInEngine = 0;//band width in game, idk what the texture thing does but i think its for scaling nuts
        this.middleRadius = 0;//probably the orbit radiussy
        this.orbitDays = 0;//orbit days, do 1 for it to orbit once everyday (funi)
        this.terrainId = "";//Terrain.PULSAR_BEAM;//this
        this.name = "";//idk lol put null or smthin//this is the belts name

    }

    public VeBlib_RingBandData(String ID, String focusID, String category, String key, float bandWidthInTexture, int bandIndex, Color color, float bandWidthInEngine, float middleRadius, float orbitDays, String terrainId, String name) {
        this.ID = ID;//id of the band useless because bands arent used in anything USELESS https://ih1.redbubble.net/image.358838235.6847/raf,360x360,075,t,fafafa:ca443f4786.jpg
        //then why its here? maybe it will be used lol just put null
        this.focusID = focusID;
        this.category = category;//the category in the config/settings.json, misc is recommended its at line 1077,
        //try putting wormhole_ring2 lmao what can go wrong after all :xdd:
        this.key = key;//texture id, idk why its named key :taxevasion:
        this.bandWidthInTexture = bandWidthInTexture;
        this.bandIndex = bandIndex;//idfk what this is the default system i got from the fat fetishist is 1 and there arent any comments on it so use 1
        this.colorColor = color;//colour tint, end text
        this.bandWidthInEngine = bandWidthInEngine;//band width in game, idk what the texture thing does but i think its for scaling nuts
        this.middleRadius = middleRadius;//probably the orbit radiussy
        this.orbitDays = orbitDays;//orbit days, do 1 for it to orbit once everyday (funi)
        this.terrainId = terrainId;//Terrain.PULSAR_BEAM;//this
        this.name = name;//idk lol put null or smthin//this is the belts name

    }

    public String category;
    public String key;
    public float bandWidthInTexture;
    public int bandIndex;
    public String color = "255, 255, 0, 0";
    public Color colorColor;
    public float middleRadius;
    public String terrainId;

    @Override
    public void CreateObject(VeBlib_StarSystemData data, StarSystemAPI system, HashMap<String, SectorEntityToken> SectorEntittyTokenHashMap, int i) {
        VeBlib_Logger.log(this.getClass(), "rings ");
        VeBlib_RingBandData ringBandData = (VeBlib_RingBandData) data.orderHashMap.get(i);
        VeBlib_Logger.log(this.getClass(), "rings " + ringBandData.ID);

        VeBlib_Logger.log(this.getClass(), "generate ring");
        if (ringBandData.terrainId.equals("") || ringBandData.name.equals("")) {
            SectorEntityToken ringBand = system.addRingBand(
                    SectorEntittyTokenHashMap.get(ringBandData.focusID),
                    ringBandData.category,
                    ringBandData.key,
                    ringBandData.bandWidthInTexture,
                    ringBandData.bandIndex,
                    ringBandData.colorColor,
                    ringBandData.bandWidthInEngine,
                    ringBandData.middleRadius,
                    ringBandData.orbitDays
            );
            SectorEntittyTokenHashMap.put(ringBandData.ID, ringBand);
        } else {
            SectorEntityToken ringBand = system.addRingBand(
                    SectorEntittyTokenHashMap.get(ringBandData.focusID),
                    ringBandData.category,
                    ringBandData.key,
                    ringBandData.bandWidthInTexture,
                    ringBandData.bandIndex,
                    ringBandData.colorColor,
                    ringBandData.bandWidthInEngine,
                    ringBandData.middleRadius,
                    ringBandData.orbitDays,
                    ringBandData.terrainId,
                    ringBandData.name
            );
            VeBlib_Logger.log(this.getClass(), "ring map");
            SectorEntittyTokenHashMap.put(ringBandData.ID, ringBand);
        }
    }

}
