class Exercise8_3_8 {

    public Exercise8_3_8(int number) {

        Console.WriteLine("Exercise 8.3.8");
        
        Console.WriteLine($"{number} factorial er: {Factorial(number)}");
    }

    private int Factorial(int number) {
        if (number == 0 || number == 1) return number;
        
        return number * Factorial(number-1);
        
    }
}


