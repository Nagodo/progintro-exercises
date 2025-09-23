class Exercise9_1_1 {

    private int iterationer = 10;
    private readonly int[] array = {1, 2, 3, 4, 5};

    public Exercise9_1_1() {

        Console.WriteLine("Exercise 9.1.1");

        for (int i = 0; i < iterationer; i++) {
            try {
                array[i]++;
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("Fejl ved index: " + i);
            }
        }

        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine(array[i]);
        }
        
    }

}


