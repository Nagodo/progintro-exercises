static class Exercise6_3_3 {

    const int SECONDS_PER_DAY = 86400;
    const int DAYS_PER_MONTH = 30;

    const int DISCOUNT = 30; // In percentage

    public static void Task() {

        Console.WriteLine("Exercise 6.3.3");

        int secondsSince = 30816000; // 30816000 = chrisgtmas
        double defaultPrice = 599.95;

        int days = secondsSince / SECONDS_PER_DAY;
        int month = days / DAYS_PER_MONTH + 1;

        Console.WriteLine($"Days: {days} - Month: {month}");

        bool christmasMonth = month == 12;

        double priceWithDiscount = christmasMonth ? defaultPrice - defaultPrice * (DISCOUNT / 100f) : defaultPrice;
        
        Console.WriteLine($"Current price: {priceWithDiscount:0.00}");
    }
}


