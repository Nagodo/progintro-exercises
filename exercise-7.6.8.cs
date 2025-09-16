static class Exercise7_6_8 {
    
    public static void Task() {
        int[] radius = new int[3] {1,3,5};

        Console.WriteLine("Exercise 7.6.8");

        for (int i = 0; i < radius.Length; i++) {
            Console.WriteLine(CircleArea(radius[i]));
        }

    }

    static double CircleArea(double r) => r*r * Math.PI;

}


