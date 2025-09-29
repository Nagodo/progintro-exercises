public class CustomerDatabase {
    
    private Customer[] customers = new Customer[10];
    private int currentIndex = 0;

    public CustomerDatabase() {
        customers = new Customer[10];
    }

    public void AddCustomer(Customer customer) {
        customers[currentIndex] = customer;
        currentIndex += 1;
    }

    
    public void RemoveCustomerById(int id) {
        for (int i = 0; i < customers.Length; i++) {
        
            if (customers[i] == null) continue;

            if (customers[i].id == id) {
                customers[i] = null;
                currentIndex -= 1;
            }
        }
    }

    public Customer[] GetAllCustomers() {
        return customers;
    }

    public void PrintCustomers() {
        for (int i = 0; i < customers.Length; i++) {
            if (customers[i] == null) continue;

            Console.WriteLine($"Konto: {customers[i].id} har {customers[i].balance}kr");
        }
    }
}