class Exercise9_1_2 {

    private readonly int[] accounts = {903, 716, 67};

    public Exercise9_1_2() {

        Console.WriteLine("Exercise 9.1.2");

        while (true) {   
            try {
                int accountId = GetAccountNumber();
                PrintAccountState(accountId);

            } catch (Exception) {
                Console.WriteLine("Fejl i input");
            }
        }
    }

    private int GetAccountNumber() {
        Console.WriteLine("Enter an account number: ");

        if (int.TryParse(Console.ReadLine(), out int number)) {
            return number;
        }

        throw new Exception();
    }
  
    private void PrintAccountState(int accountId) {

        if (accountId < 0) {
            Console.WriteLine("AccountId skal være positivt");
            return;
        }

        if (accountId > accounts.Length - 1) {
            Console.WriteLine("AccountId er større end accounts array");
        } else {
            Console.WriteLine($"Account {accountId} contains {accounts[accountId]}");
        }
    }

}


