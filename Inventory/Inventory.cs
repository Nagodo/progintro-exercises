public class Inventory {

    public Item[] items;

    public Inventory() {

        items = new Item[20];

        for (int i = 0; i < 10; i++) {

            string itemName = "Item" + i;
            double price = 6.9 * i;

            FoodItem foodItem = new FoodItem(itemName, price);
            AddItem(foodItem);
        }

        for (int i = 0; i < 10; i++) {

            string itemName = "Item" + i;
            double price = 6.9 * i;
            string[] materials = {"Lort", "Jern"};

            NonFoodItem nonFoodItem = new NonFoodItem(itemName, price, materials);
            AddItem(nonFoodItem);
        }

        Test1();

        // Console.WriteLine(GetInventoryValue());
        // PrintInventory();
    }

    public void AddItem(Item item) {
        Console.WriteLine(item.GetPrice());
        for (int i = 0; i < items.Length; i++) {
            if (items[i] == null) {
                items[i] = item;
            }
        }
    }

    public void RemoveItem(Item item) {
        for (int i = 0; i < items.Length; i++) {
            if (items[i].Equals(item)) {
                items[i] = null;
            }
        }
    }

    public double GetInventoryValue() {
        double priceSum = 0;
        for (int i = 0; i < items.Length; i++) {
            priceSum += items[i].GetPrice();
        }

        return priceSum;
    }

    public void PrintInventory() {
        for (int i = 0; i < items.Length; i++) {
            Console.WriteLine($"Item: {items[i].GetName()} Pris: {items[i].GetPrice()}");
        }
    }

    public void Test1()
    {
        for (int i = 0; i < items.Length; i++)
        {
            Item item = items[i];
        }

        foreach (Item item in items)
        {
            
        }
    }

}