using System.Collections;

static class NewCollections
{
    internal static void DemoArray()
    {
        string[] names = new string[] { "RK", "NY" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }

    internal static void ArryList()
    {
        ArrayList data = new ArrayList();
        data.Add(40);
        data.Add("RK");
        data.Add(true);

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
        //List
        List<int> num = new List<int>();
        num.Add(30);
        num.Add(55);

        foreach (var item in num)
        {
            Console.WriteLine(item);
        }

    }

    internal static void HashTable()
    {
        //HashMap Non Generic
        Hashtable data = new Hashtable();
        data.Add(1, "Ram");
        data.Add(3, 5);
        data.Add("Ram", "sita");
        Console.WriteLine(data[3]);
        Console.WriteLine(data[1]);
        Console.WriteLine(data["Ram"]);

        foreach (DictionaryEntry item in data)
        {
            Console.WriteLine(item.Value);
        }

    }

    internal static void DicTable()
    {
        Dictionary<string, string> data = new Dictionary<string, string>();
        data.Add("aa", "bb");
        data.Add("cc", "dd");
        Console.WriteLine(data["aa"]);
        Console.WriteLine(data["cc"]);
    }

    internal static void Stack()
    {
        Stack<string> data = new Stack<string>();
        data.Push("KK");

        while (data.Count() > 0)
        {
            Console.WriteLine(data.Pop());
        }
    }

    internal static void Queue()
    {
        Queue<string> data = new Queue<string>();
        data.Enqueue("MM");

        Console.WriteLine(data.Peek());

        data.Dequeue();

    }

    internal static void DemoList()
    {
        // A List stores values of one specific type: here, only strings.
        List<string> companies = new List<string>();

        // Add items
        companies.Add("Google");
        companies.Add("Oyo");
        companies.Add("Netflix");

        // Read by index (index starts at 0)
        Console.WriteLine(companies[0]); // Google

        // Change an item
        companies[1] = "YouTube";

        // Remove an item
        companies.Remove("Netflix");

        // Check whether an item exists
        Console.WriteLine(companies.Contains("Google")); // True

        // Loop through every item
        foreach (string company in companies)
        {
            Console.WriteLine(company);
        }

        // Total number of items
        Console.WriteLine($"Count: {companies.Count}");
    }
}
