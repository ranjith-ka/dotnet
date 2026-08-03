class Company
{
    public int id = 1;
    public string name = "Google";

    public void DisplayCompanyDetails()
    {
        Console.WriteLine($"Id:{id} and Name:{name}");
    }
}

class CompanySetter
{
    public string name = "Netflix";
    public void SetName(string name)
    {
        this.name = name;
    }
}

class CompanySetter2
{
    private int Id { get; set; } = 1;
    private string Name { get; set; } = "RK";

    public string GetName()
    {
        return Name;
    }
    public void SetName(string Name)
    {
        this.Name = Name;
    }

    // Constructor
    public CompanySetter2()
    {
        //Empty constructor
        Console.WriteLine("Print this");
    }

}

class MyConstructorClass
{
    public int Id { get; set; } = 1;
    public string Name { get; set; } = "RK";

    public MyConstructorClass(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public MyConstructorClass(int id)
    {
        Id = id;
    }
    public void DisplayData()
    {
        Console.WriteLine($"Id: {Id} and Name: {Name}");
    }
}