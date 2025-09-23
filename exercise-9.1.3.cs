class Exercise9_1_3 {

    private int[] grades = {4, 7, 2, 0, 10, 4, 12};

    public Exercise9_1_3() {

        Console.WriteLine("Exercise 9.1.3");

        int count = 0, sum = 0;

        for (int i = 0; i < grades.Length; i++) {
            try {
                int grade = GetGrade(i);

                count++;
                sum += grade;

            } catch (Exception) {
                Console.WriteLine($"Fag: {i} er dumpet");
            }
        }

        Console.WriteLine($"Average grade: {sum/count}. Antal fag: {count}");
       
    }

    private int GetGrade(int courseId) {
        int grade = grades[courseId];
  
        if (grade >= 2) {
            return grade;
        } else {
            throw new Exception();
        }
    }

}