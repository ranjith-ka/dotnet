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