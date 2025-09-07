static class Exercise5_7_10 {

    static float celsiusTemperature = 10f;
    public static void Task() {

        Console.WriteLine("Exercise 5.7.10");

        Console.WriteLine(ToFahrenheiht(celsiusTemperature));

    }

    static float ToFahrenheiht(float celsius) => 32 + (9f/5f * celsius);
        
}


