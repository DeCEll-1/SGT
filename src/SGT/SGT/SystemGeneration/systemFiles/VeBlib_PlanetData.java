package SGT.SGT.SystemGeneration.systemFiles;

public class VeBlib_PlanetData extends VeBlib_SGTExtend {

    public VeBlib_PlanetData(String Id, String OrbitFocus, String Name, String TypeId, float angle, float Radius, float orbitRadius, float orbitDays) {
        this.Id = Id;
        this.focusID = OrbitFocus;
        this.Name = Name;
        this.typeID = TypeId;
        this.angle = angle;
        this.Radius = Radius;
        this.orbitRadius = orbitRadius;
        this.orbitDays = orbitDays;

    }

    public String Id;
    public String Name;
    public float Radius;


}
