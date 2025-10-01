public class Inventory {

    public Item[] foodItems;

    public Inventory() {

        foodItems = new Item[20];

        for (int i = 0; i < 10; i++) {

            string itemName = "Item" + i;
            double price = 6.9 * i;

            foodItems[i] = new FoodItem(itemName, price);
        }

        for (int i = 0; i < 10; i++) {

            string itemName = "Item" + i;
            double price = 6.9 * i;
            string[] materials = {"Lort", "Jern"};

            foodItems[i + 10] = new NonFoodItem(itemName, price, materials);
        }
    }

}