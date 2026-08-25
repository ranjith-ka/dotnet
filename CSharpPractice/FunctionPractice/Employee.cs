public class EmpInheritance : CompanyInheritance, IEmployeeSalary
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double Salary { get; set; }

    public EmpInheritance(
        int companyId,
        string companyName,
        int empId,
        string empName,
        double salary)
        : base(companyId, companyName)
    {
        EmpId = empId;
        EmpName = empName;
        Salary = salary;

    }

    public void SalaryDetails()
    {
        Console.WriteLine($"Salary: {Salary} - ok");
    }

    public void DisplayEmployeeData()
    {
        Console.WriteLine($"Employee ID: {EmpId}");
        Console.WriteLine($"Employee Name: {EmpName}");
    }
}
