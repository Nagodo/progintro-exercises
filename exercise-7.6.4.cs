static class Exercise7_6_4 {
    
    public static void Task() {

        Console.WriteLine("Exercise 7.6.4");
        
        int[] numbers = new int[] {1, 2, 3, 43, 2, 92, 56, 24, 63, 63, 99, 3, 5}; 

        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++) {
            int number = numbers[i];
            if (number > max) max = number;
        }
        

        Console.WriteLine($"Max number: {max}");
    }

}


