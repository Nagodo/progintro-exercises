public class Item {

    protected double price;
    protected string name;

    public Item(string name, double price) {
        this.name = name;
        this.price = price;
    }

    public string GetName() {
        return name;
    }

    public double GetPrice() {
        return price;
    }
}