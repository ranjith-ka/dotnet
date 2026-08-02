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


}
