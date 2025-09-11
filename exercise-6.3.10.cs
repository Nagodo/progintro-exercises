static class Exercise6_3_10 {
    
    public static void Task() {

        Console.WriteLine("Exercise 6.3.10");
        
        int largestPrime = 0;
        int primeAmount = 0;
        for (int i = 0; i < 100000; i++) {

            if (!i.IsPrime()) continue; 

            if (i > largestPrime) largestPrime = i;
            primeAmount++;
        }
        
        Console.WriteLine($"Largest: {largestPrime}. Amount: {primeAmount}");
    }


    public static bool IsPrime(this int number) {
        if (number == 1 || number == 0) return false;

        int maxDivider = number / 2;
        for (int i = 2; i <= maxDivider; i++) {
            if (number % i == 0) return false;
        }

        return true;
    }

}


