static class Exercise5_7_8 {

    static int[] radius = new int[3] {1,3,5};

    public static void Task() {

        Console.WriteLine("Exercise 5.7.8");

        for (int i = 0; i < radius.Length; i++) {
            Console.WriteLine(CircleArea(radius[i]));
        }

    }

    static float CircleArea(float r) => r*r * 3.14f;
        
}


