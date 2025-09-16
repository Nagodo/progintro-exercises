static class Exercise7_6_14 {

    static int[][] validSoduku = new int[9][] {
        new int[9] {5, 3, 4, 6, 7, 8, 9, 1, 2},
        new int[9] {6, 7, 2, 1, 9, 5, 3, 4, 8},
        new int[9] {1, 9, 8, 3, 4, 2, 5, 6, 7},
        new int[9] {8, 5, 9, 7, 6, 1, 4, 2, 3},
        new int[9] {4, 2, 6, 8, 5, 3, 7, 9, 1},
        new int[9] {7, 1, 3, 9, 2, 4, 8, 5, 6},
        new int[9] {9, 6, 1, 5, 3, 7, 2, 8, 4},
        new int[9] {2, 8, 7, 4, 1, 9, 6, 3, 5},
        new int[9] {3, 4, 5, 2, 8, 6, 1, 7, 9}
    };

    // Invalid Sudoku grid (duplicate '5' in the first row)
    static int[][] invalidSoduku = new int[9][] {
    new int[9] {5, 3, 4, 6, 7, 8, 9, 1, 2},
    new int[9] {6, 7, 2, 1, 9, 5, 3, 4, 8},
    new int[9] {1, 9, 8, 3, 4, 2, 5, 6, 7},
    new int[9] {8, 5, 9, 7, 6, 1, 4, 2, 3},
    new int[9] {4, 2, 6, 8, 5, 3, 7, 9, 1},
    new int[9] {7, 1, 3, 9, 2, 4, 8, 5, 6},
    new int[9] {9, 6, 1, 5, 3, 7, 2, 8, 4},
    new int[9] {2, 8, 7, 4, 1, 9, 6, 3, 5},
    new int[9] {3, 4, 5, 2, 8, 6, 1, 7, 5} // duplicate '5' in last column, no row error
    };


    
    public static void Task() {

        Console.WriteLine("\nExercise 7.6.14");
        

        var useSoduku = invalidSoduku;
    
        //Rows
        for (int y = 0; y < useSoduku.Length; y++) {

            bool[] rowUsed = new bool[9];

            for (int x = 0; x < useSoduku[y].Length; x++) {

                int numCheck = useSoduku[y][x] - 1;

                if (rowUsed[numCheck] == false) {
                    rowUsed[numCheck] = true;
                } else {
                    //Trying to use same number
                    Console.WriteLine($"Fejl: x:{x+1} y: {y+1}");
                    return;
                }
            }
        }

        //Column
        for (int x = 0; x < useSoduku.Length; x++) {

            bool[] columnUsed = new bool[9];

            for (int y = 0; y < 9; y++) {

                int checkNum = useSoduku[y][x];

                if (columnUsed[checkNum] == false) {
                    columnUsed[checkNum] = true;
                } else {
                    Console.WriteLine($"Fejl: x:{x+1} y: {y+1}");
                    return ;
                }

            }

        }

        for (int i = 0; i < 9; i++) {

            for (int y = 0; y < 3; y++) {

                for (int x = 0; x < 3; x++) {

                }

            }

        }


        Console.WriteLine("Soduku is valid");
    }
}


