static class Exercise5_7_11 {

    const int SECONDS_SINCE = 1000000000; 
    
    public static void Task() {

        Console.WriteLine("Exercise 5.7.11");

        int minutes = SECONDS_SINCE / 60;
        int hours = minutes / 60;
        int days = hours / 24;
        int years = days / 365;

        int correctedDays = days - (years * 365);
        int correctedHours = hours - (days * 24);
        int correctedMinutes = minutes - (hours * 60);

        Console.WriteLine($"Years: {years}. Days: {days}. Hours: {hours}. Minutes: {minutes}");
        Console.WriteLine($"Years: {years}. Days: {correctedDays}. Hours: {correctedHours}. Minutes: {correctedMinutes}");

    }
}


