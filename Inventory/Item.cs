public class Item : IEquatable<Item> {

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

    public override bool Equals(object? obj) {
        if (obj is not Item) return false;

        Item item = (Item) obj;

        return (this.price == item.price && this.name == item.name);
    }

    public bool Equals(Item? other) {
        if (other == null) return false;
        return this.price == other.price && this.name == other.name;
    }
}