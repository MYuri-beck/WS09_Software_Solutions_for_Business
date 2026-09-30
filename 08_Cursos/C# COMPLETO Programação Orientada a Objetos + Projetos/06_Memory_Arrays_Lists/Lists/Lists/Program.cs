namespace Lists;

class Program {
    static void Main(string[] args) {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original list: " + string.Join(", ", numbers));
        // Add an element to the list
        numbers.Add(6);
        Console.WriteLine("After adding 6: " + string.Join(", ", numbers));
        // Remove an element from the list
        numbers.Remove(3);
        Console.WriteLine("After removing 3: " + string.Join(", ", numbers));
        // Insert an element at a specific index
        numbers.Insert(2, 10);
        Console.WriteLine("After inserting 10 at index 2: " + string.Join(", ", numbers));
        // Sort the list
        numbers.Sort();
        Console.WriteLine("After sorting: " + string.Join(", ", numbers));
        // Reverse the list
        numbers.Reverse();
        Console.WriteLine("After reversing: " + string.Join(", ", numbers));


        List<string> list = new List<string>();
        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");
        list.Insert(2, "Marco");
        foreach (string obj in list) {
            Console.WriteLine(obj);
        }
        Console.WriteLine("Listcount: " + list.Count);
        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("First'A': " + s1);
        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("Last'A': " + s2);
        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("Firstposition 'A': " + pos1);
        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("Lastposition 'A': " + pos2);
        List<string> list2 = list.FindAll(x => x.Length == 5);
        Console.WriteLine("---------------------");
        foreach (string obj in list2) {
            Console.WriteLine(obj);
        }
        list.Remove("Alex");
        Console.WriteLine("---------------------");
        foreach (string obj in list) {
            Console.WriteLine(obj);
        }
        list.RemoveAll(x => x[0] == 'M');
        Console.WriteLine("---------------------");
        foreach (string obj in list) {
            Console.WriteLine(obj);
        }
    }
}