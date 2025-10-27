class Program {
    static void Main(string[] args) {

        IDynamicArray<int> a = new DynamicArray<int>(1);

        Console.WriteLine("Add elements:");
        Console.WriteLine(a);

        for (int i=0 ; i<20 ; i++) {
            a.Append(i);
            Console.WriteLine(a);
        }

        Console.WriteLine("");
        Random random = new Random();
        Console.WriteLine("Remove elements:");
        Console.WriteLine(a);

        for (int i=19 ; i>=0 ; i--) {
            a.Remove(random.Next(a.GetFill()));
            Console.WriteLine(a);
        }

        Console.WriteLine("\nManual Testing:");
		a.Append(5);
		a.Append(11);
		a.Append(7);
		Console.WriteLine(">>Print: " + a);
		
		Console.WriteLine("Get [1]: " + a.Get(1));
		
		Console.WriteLine("Set [2] = -3");
		a.Set(2, -3);
		Console.WriteLine(">>Print: " + a);
		
		Console.WriteLine("Insert at [2]: 99");
		a.Insert(99, 2);
		Console.WriteLine(">>Print: " + a);
		
		Console.WriteLine("Remove at [1]");
		a.Remove(1);
		Console.WriteLine(">>Print: " + a);

		Console.WriteLine("Get [1]: " + a.Get(1));

		Console.WriteLine("Remove  at [0]");
		a.Remove(0);
		Console.WriteLine(">>Print: " + a);
    }
}