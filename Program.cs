class Program {
    public static void Main(string[] args) {

        string[] names = {"John", "Din mor", "John John", "Lort"};

        CustomerDatabase customerDatabase = new();

        for (int i = 0; i < names.Length; i++) {
            Customer newCustomer = new(names[i], i);
            customerDatabase.AddCustomer(newCustomer);
        }

        customerDatabase.PrintCustomers();
    }
}