static class Exercise6_3_4 {
    
    public static void Task() {

        Console.WriteLine("Exercise 6.3.4");
        int checkMonth = 4;

        int length = checkMonth switch {
            1 => 31,
            2 => 28,
            3 => 31,
            4 => 30,
            5 => 31,
            6 => 30,
            7 => 31,
            8 => 31,
            9 => 30,
            10 => 31,
            11 => 30,
            12 => 31,

            _=> 0
        };

        Console.WriteLine($"Length of month: {length}");
        
    }
}


