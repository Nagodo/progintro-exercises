public class Program {
    public static void Main(string[] args) {
        
        Random rnd = new Random();

        const int AMOUNT = 10;
        Kitten[] kittens = new Kitten[AMOUNT];

        for (int i = 0; i < AMOUNT; i++) {
            Kitten kitten = new Kitten(rnd.Next(1, 100));
            kittens[i] = kitten;
        }

        Console.WriteLine($"Kitten amount: {Kitten.count}");

    }
}