class Exercise8_3_7 {

    public Exercise8_3_7() {

        Console.WriteLine("Exercise 8.3.7");

        //double a = 1, b = 5, c = 6; // To roots
        double a = 1, b = 2, c = 1; // En root
        //double a = 1, b = 2, c = 3; // Ingen root
        double[] roots = Roots(a, b, c);

        Console.WriteLine("Roots:");
        foreach (double root in roots) {
            Console.WriteLine(root);
        }
        
    }

    private double Discriminant(double a, double b, double c) {
        return b*b - 4 * a * c;
    }

    private double[] Roots(double a, double b, double c) {

        double discriminant = Discriminant(a, b, c);
        if (discriminant < 0) {
            return new double[] {};
        } else if (discriminant == 0) {
            double root = (-b + Math.Sqrt(b*b - 4 * a * c)) / (2 * a);

            return new double[] {root};
        } else {
            double positiveRoot = (-b + Math.Sqrt(b*b - 4 * a * c)) / (2 * a);
            double negativeRoot = (-b - Math.Sqrt(b*b - 4 * a * c)) / (2 * a);

            return new double[] {positiveRoot, negativeRoot};
        }

    }

}


