static class Exercise7_6_12 {
    
    public static void Task() {

        int[] daysInMonths = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int[] daysInMonthsLeap = new int[12] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        Console.WriteLine("Exercise 7.6.12");
        
        for (int i = 2000; i < 2020; i++) {

            int[] daysInMonth;

            if (i % 4 == 0) {
                daysInMonth = daysInMonthsLeap;
            } else {
                daysInMonth = daysInMonths;
            }

            Console.WriteLine($"\nDays in year{i}:");
            for (int x = 0; x < daysInMonth.Length; x++) {
                Console.Write(daysInMonth[x] + " ");
            }

        }
        
    }

}


