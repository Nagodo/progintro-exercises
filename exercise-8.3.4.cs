class Exercise8_3_4 {

    public Exercise8_3_4(params int[] numbers) {

        Console.WriteLine("Exercise 8.3.4");
        
        Console.WriteLine(Add(numbers));
    }

    private int Add(int[] numbers) {

        int total = 0;
        foreach (int number in numbers) {
            total += number;
        }

        return total;
    }

}


