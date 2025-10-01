public class Customer {
    public string name;
    public int id;
    public double balance;

    public Customer(string name, int id) {
        this.name = name;
        this.id = id;
        this.balance = 0;
    }

    public Customer(string name, int id, double balance) {
        this.name = name;
        this.id = id;
        this.balance = balance;
    }

    public void Deposit(double amount) {
        balance += amount;  
    }

    public void Withdraw(double amount) {
        balance -= amount;
    }

    public double GetBalance() {
        return balance;
    }
}