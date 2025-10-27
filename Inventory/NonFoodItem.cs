public class NonFoodItem : Item {
   
    private string[] materials;

    public NonFoodItem(string name, double price, string[] materials) : base(name, price) {
        this.materials = materials;
    }

    public override bool IsExpired() { return false; }

    public override string ToString() {

        string mats = string.Join(",", materials);
        
        
        return $"FoodItem: {name} Pris: {price} Materialer: {mats}";
    }
} 