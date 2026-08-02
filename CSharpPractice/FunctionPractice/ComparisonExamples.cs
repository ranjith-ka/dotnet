static class ComparisonExamples
{
    internal static void Show(int age)
    {
        if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }
    }

    internal static void RunDemo()
    {
        Console.WriteLine("Age comparisons:");
        Show(15);
        Show(30);
        Show(70);
    }

    internal static void DemoSwitch(string color)
    {
        Console.WriteLine("Run the Swtich");
        switch (color.ToLower())
        {
            case "green":
                Console.WriteLine("Green man");
                break;
            case "red":
                Console.WriteLine("Red man");
                break;
            default:
                Console.WriteLine("Have a sleep");
                break;

        }
    }

    internal static void DemopForLoop()
    {
        for (int i = 0; i < 10 + 1; i++)
        {
            Console.WriteLine(i);
        }
    }

}