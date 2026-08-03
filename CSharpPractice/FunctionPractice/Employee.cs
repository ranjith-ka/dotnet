public class EmpInheritance : CompanyInheritance
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }

    public EmpInheritance(
        int companyId,
        string companyName,
        int empId,
        string empName)
        : base(companyId, companyName)
    {
        EmpId = empId;
        EmpName = empName;
    }
}