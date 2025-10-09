

class TestCircle {
    static void Main (string[] args) {
        Circle c = new Circle(1.24, 2.83, 12.7); // New circle instance with x,y,radius
        Console.WriteLine("x=" + c.coordinate.GetX() + " y=" + c.coordinate.GetY() + " r=" + c.r);
        c.r *= 1.37;
        c.coordinate.SetX(c.coordinate.X + 0.65);
        Console.WriteLine("x=" + c.coordinate.x + " y=" + c.coordinate.y + " r=" + c.r);
    }
}

class Circle {
    public Coordinate coordinate;
    public double r;
    public double diameter {
        get;
        private set;
    }
    

    public Circle (double x, double y, double radius) {
        this.coordinate = new(x, y);
        this.r = radius;
        this.diameter = radius * 2;
    }

}