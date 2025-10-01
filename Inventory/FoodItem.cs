public class FoodItem : Item {
    private DateTime expiresAt;

    public FoodItem(string name, double price) : base(name, price) {
        expiresAt = new DateTime(2025, 11, 1);
    }

    public DateTime GetExpiresAt() {
        return expiresAt;
    }

    public override string ToString() {
        return $"FoodItem: {name} Pris: {price} Udløber den: {expiresAt.ToShortDateString()}";
    }
} 