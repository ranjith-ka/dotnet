public class Boss : EmpInheritance
{
    public string Department { get; set; }

    public Boss(
        int companyId,
        string companyName,
        int empId,
        string empName,
        double salary,
        string department)
        : base(companyId, companyName, empId, empName, salary)
    {
        Department = department;
    }

    public void DisplayBossData()
    {
        Console.WriteLine($"Department: {Department}");
    }
}
