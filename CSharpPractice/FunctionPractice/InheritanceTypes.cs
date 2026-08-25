// Single inheritance: Car has one direct base class, Vehicle.
public class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

public class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

// Multiple inheritance in C# is achieved with interfaces.
public interface ICanFly
{
    void Fly();
}

public interface ICanSwim
{
    void Swim();
}

public class Duck : ICanFly, ICanSwim
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying.");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming.");
    }
}

// Hierarchical inheritance: both Circle and Square inherit from Shape.
public class Shape
{
    public void Describe()
    {
        Console.WriteLine("This is a shape.");
    }
}

public class Circle : Shape
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Square : Shape
{
    public void DrawSquare()
    {
        Console.WriteLine("Drawing a square.");
    }
}

public static class InheritanceTypesDemo
{
    public static void RunAll()
    {
        RunSingleInheritance();
        RunMultipleInheritance();
        RunMultilevelInheritance();
        RunHierarchicalInheritance();
    }

    private static void RunSingleInheritance()
    {
        Console.WriteLine("\nSingle inheritance:");
        Car car = new Car();
        car.Start();
        car.Drive();
    }

    private static void RunMultipleInheritance()
    {
        Console.WriteLine("\nMultiple inheritance using interfaces:");
        Duck duck = new Duck();
        duck.Fly();
        duck.Swim();
    }

    private static void RunMultilevelInheritance()
    {
        Console.WriteLine("\nMultilevel inheritance:");
        Boss boss = new Boss(1, "Microsoft", 101, "Ranjith", 3000, "Engineering");
        boss.DisplayData();
        boss.DisplayEmployeeData();
        boss.SalaryDetails();
        boss.DisplayBossData();
    }

    private static void RunHierarchicalInheritance()
    {
        Console.WriteLine("\nHierarchical inheritance:");
        Circle circle = new Circle();
        Square square = new Square();
        circle.Describe();
        circle.DrawCircle();
        square.Describe();
        square.DrawSquare();
    }
}
