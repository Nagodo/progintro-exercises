public class Program {
    static void Main(string[] args) {

        Inventory inventory = new();

        foreach (Item item in inventory.foodItems) {
            Console.WriteLine(item.ToString());
        }

    }
}