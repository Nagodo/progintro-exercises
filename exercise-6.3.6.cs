static class Exercise6_3_6 {
    
    const int START_CELCIUS = -5;
    const int STOP_CELCIUS = 40;
    const float CELCIUS_INCREMENT = 0.5f;

    public static void Task() {

        Console.WriteLine("Exercise 6.3.6");
        
        for (float i = START_CELCIUS; i <= STOP_CELCIUS; i+=CELCIUS_INCREMENT) {
            Console.WriteLine($"C: {i, 4} | F: {ToFahrenheit(i)}");
        }
    }

    public static float ToFahrenheit(float celcius) {
        return 32 + 9/5f * celcius;
    }
}


