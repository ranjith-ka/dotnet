public class CompanyInheritance
{
    public int CompanyId { get; set; }
    public string CompanyName { get; set; }

    public CompanyInheritance(int companyId, string companyName)
    {
        CompanyId = companyId;
        CompanyName = companyName;
    }
}
