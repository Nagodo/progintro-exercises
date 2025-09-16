class Exercise8_3_9 {

    private readonly int[] radiuses = {1, 3, 5};

    public Exercise8_3_9() {

        Console.WriteLine("Exercise 8.3.9");
        
        foreach (int radius in radiuses) {
            double area = CircleArea(radius);
            double circumference = CircleCircumference(radius);
            Console.WriteLine($"Radius: {radius} Area: {area:0.00} Circumference: {circumference:0.00}");
        }
    }

    private double CircleArea(int radius) => radius * radius * Math.PI;
    private double CircleCircumference(int radius) => radius * Math.PI * 2;
    
}


