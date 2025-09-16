class Exercise8_3_5 {

    private const float PRECISION_INCREMENT = 0.01f;
    private const float MAX_DIFFERENCE = 0.001f;

    public Exercise8_3_5() {

        Console.WriteLine("Exercise 8.3.5");

        int test = 25;
        double sqrt = Sqrt(test);
        
        Console.WriteLine($"Sqrt af: {test} er: {sqrt:0.0}");
    }

    private double Sqrt(int number) {
        if (number == 0 || number == 1) return number;

        float currentSqrt = number / 2;

        //Rough
        while (currentSqrt * currentSqrt > number) {
            currentSqrt /= 2;
        }

        //More precise
        while (number - currentSqrt * currentSqrt > MAX_DIFFERENCE) {
            currentSqrt += PRECISION_INCREMENT;
        }

        return currentSqrt;
    }  
}


