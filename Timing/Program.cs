public class Timing {

    public static void Main() {
        double x = 1.0000001;

        long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        for (int y = 1; y <= 32; y++) {
            Console.WriteLine(Fun(x, y));
        }

        long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        Console.WriteLine("Ms: " + (endTime - startTime));
    }

    public static double Fun(double x, double y) {

        if (y <= 1) return x;

        return Fun(x, y - 1) * Fun(x, y- 1 );

    }
}