public class Program {
    static void Main(string[] args) {
        List<Person> persons = new();

        persons.Add(new("John Olsen", 69, "010101-0101"));

        for (int i = 0; i < 4; i++) {
            persons.Add(new("John" + i, i * 12, (27272 * i).ToString()));
        }

        //Find person
        foreach(Person person in persons) {
            if (person.GetCpr() == "010101-0101") {
                Console.WriteLine(person.ToString());
            }
        }

        Dictionary<string, Person> personDict = new();
        foreach (Person person in persons) {
            personDict.Add(person.GetCpr(), person);
        }

        Console.WriteLine(personDict["010101-0101"]);
    }
}