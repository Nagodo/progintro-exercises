class Exercise8_3_3 {

    int[][] puzzle= {
        new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
        new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
        new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
        new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
        new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
        new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
        new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
        new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
        new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
    };

    public Exercise8_3_3() {

        Console.WriteLine("Exercise 8.3.3");
        
        PrintSoduku(puzzle);
    }

    private void PrintSoduku(int[][] soduku) {

        PrintHorizontalLine();

        for (int y = 0; y < soduku.Length; y++) {
            for (int x = 0; x < soduku[y].Length; x++) {
                if (x % 3 == 0 && x != 0) {
                    Console.Write("│");
                }
                Console.Write($"{soduku[y][x]} ");
            }

            Console.WriteLine("");

            if ((y+1) % 3 == 0) {
                PrintHorizontalLine();
            }

        }
        
    }

    private void PrintHorizontalLine() {
        for (int i = 0; i < 19; i++) {
            Console.Write("─");
        }

        Console.WriteLine("");
    }

}


