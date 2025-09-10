static class Exercise6_3_5 {
    
    public static void Task() {

        Console.WriteLine("Exercise 6.3.5");
        int checkMonth = 4;

        switch (checkMonth) {
            case 4:
                Console.WriteLine("Spring Holiday");
                break;

            case 7:
            case 8:
                Console.WriteLine("Summer Holiday");
                break;

            case 10:
                Console.WriteLine("Autumn Holiday");
                break;

            case 12:
                Console.WriteLine("Christmas Holiday");
                break;

            default:
                Console.WriteLine("Hard work!");
                break;
        }
        
    }
}


