using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSSystemGenerator.Classes.SystemFiles
{
    public class RingBandData : Extend
    {

        public RingBandData()
        {
            this.ID = "";//id of the band useless because bands arent used in anything USELESS https://ih1.redbubble.net/image.358838235.6847/raf,360x360,075,t,fafafa:ca443f4786.jpg
                         //then why its here? maybe it will be used lol just put null
            this.focusID = "";
            this.category = "";//the category in the config/settings.json, misc is recommended its at line 1077,
                               //try putting wormhole_ring2 lmao what can go wrong after all :xdd:
            this.key = "";//texture id, idk why its named key :taxevasion:
            this.bandWidthInTexture = 0;
            this.bandIndex = 0;//idfk what this is the default system i got from the fat fetishist is 1 and there arent any comments on it so use 1
            this.color = Color.Red;//colour tint, end text
            this.bandWidthInEngine = 0;//band width in game, idk what the texture thing does but i think its for scaling nuts
            this.middleRadius = 0;//probably the orbit radiussy
            this.orbitDays = 0;//orbit days, do 1 for it to orbit once everyday (funi)
            this.terrainId = "";//Terrain.PULSAR_BEAM;//this
            this.name = "";//idk lol put null or smthin//this is the belts name

        }

        public RingBandData(String ID, String focusID, String category, String key, float bandWidthInTexture, int bandIndex, Color color, float bandWidthInEngine, float middleRadius, float orbitDays, String terrainId, String name)
        {
            this.ID = ID;//id of the band useless because bands arent used in anything USELESS https://ih1.redbubble.net/image.358838235.6847/raf,360x360,075,t,fafafa:ca443f4786.jpg
                         //then why its here? maybe it will be used lol just put null
            this.focusID = focusID;
            this.category = category;//the category in the config/settings.json, misc is recommended its at line 1077,
                                     //try putting wormhole_ring2 lmao what can go wrong after all :xdd:
            this.key = key;//texture id, idk why its named key :taxevasion:
            this.bandWidthInTexture = bandWidthInTexture;
            this.bandIndex = bandIndex;//idfk what this is the default system i got from the fat fetishist is 1 and there arent any comments on it so use 1
            this.color = color;//colour tint, end text
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
        public Color color;
        public float middleRadius;
        public String terrainId;

    }
}
