class Exercise8_3_5 {

    private const double MAX_PRECISION = 0.00000001d;

    public Exercise8_3_5() {

        Console.WriteLine("Exercise 8.3.5");

        long test = 1000000000000000;
        double sqrt = Sqrt(test);
        
        Console.WriteLine($"Sqrt af: {test} er: {sqrt}");

    }

    private double Sqrt(long number) {
        if (number == 0 || number == 1) return number;

        double currentSqrt = number / 2;

        //Rough // Value below correct after this
        while (currentSqrt * currentSqrt > number) {
            currentSqrt /= 2;
        }

        currentSqrt = (int)currentSqrt;

        double currentPrecision = 1f;

        while (number - currentSqrt * currentSqrt > currentPrecision) {

            if (Math.Pow(currentSqrt + currentPrecision, 2) > number) {
                
                currentPrecision /= 10d;
                if (currentPrecision < MAX_PRECISION) break;

            } else {

                currentSqrt += currentPrecision;

            }
        }

        return currentSqrt;
    }  
}


