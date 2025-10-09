/// <summary>
/// Har forskellige getter og setter;
/// </summary>
public class Coordinate {
    public double x { get; private set; }
    public double y { get; private set; }

    public double X => x;
    public double Y => y;
    

    public Coordinate(double x, double y) {
        this.x = x;
        this.y = y;
    }
    
    public double GetX() => x;
    public double GetY() => y;

    public void SetX(double x) {
        this.x = x;
    }

    public void SetY(double y) {
        this.y = y;
    }

}