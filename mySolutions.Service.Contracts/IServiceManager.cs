

namespace mySolutions.Service.Contracts
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; } 
        IEmployeeService EmployeeService { get; }
    }
}