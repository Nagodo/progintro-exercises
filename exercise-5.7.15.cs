﻿static class Exercise5_7_15 {

    
    public static void Task() {

        Console.WriteLine("Exercise 5.7.15");

        int ada_lovelace = 36;
        int dennis_ritchie = 70;
        int grace_hopper = 85;
        int hedy_lamarr = 85;
        int edsger_dijkstra = 72;
        int douglas_engelbart = 88;

        float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
        float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
        float avg = (male_avg + female_avg) / 2;
        float diff = male_avg - female_avg;
        
        Console.Write("Average lifespan of a male computer scientist: ");
        
        Console.WriteLine(male_avg);
        Console.Write("Average lifespan of a female computer scientist: ");
        Console.WriteLine(female_avg);
        Console.Write("Average lifespan of a computer scientist: ");
        Console.WriteLine(avg);
        Console.Write("Males live this much longer than females: ");
        Console.WriteLine(diff);

    }
}


