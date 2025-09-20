class Exercise9_1_2 {

    private readonly int[] accounts = {903, 716, 67};

    public Exercise9_1_2() {

        Console.WriteLine("Exercise 9.1.2");

        while (true) {   
            int accountId = GetAccountNumber();
            if (accountId == -1) {
                Console.WriteLine("Fejl i input");
            } else {
                PrintAccountState(accountId);
            }
        }
    }

    private int GetAccountNumber() {
        Console.WriteLine("Enter an account number: ");

        if (int.TryParse(Console.ReadLine(), out int number)) {
            return number;
        }

        return -1;
    }

    private void PrintAccountState(int accountId) {
        if (accountId > accounts.Length - 1) {
            Console.WriteLine("AccountId er større end accounts array");
        } else {
            Console.WriteLine($"Account {accountId} contains {accounts[accountId]}");
        }
    }

}


