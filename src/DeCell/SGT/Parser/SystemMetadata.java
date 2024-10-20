package DeCell.SGT.Parser;

public class SystemMetadata {
    public SystemMetadata() {
    }
    public SystemMetadata(String ID, String ImagePath, int width, int height) {
        this.ID = ID;
        this.ImagePath = ImagePath;
        this.width = width;
        this.height = height;
    }

    public String ID;
    public String ImagePath;
    public int width;
    public int height;
}
