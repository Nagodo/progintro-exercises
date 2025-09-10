static class Exercise6_3_9 {
    
    static int[] radius = new int[3] {1,3,5};

    public static void Task() {

        Console.WriteLine("Exercise 6.3.9");

        for (int i = 0; i < radius.Length; i++) {
            Console.WriteLine(CircleArea(radius[i]));
        }

    }

    static double CircleArea(double r) => r*r * Math.PI;

}


