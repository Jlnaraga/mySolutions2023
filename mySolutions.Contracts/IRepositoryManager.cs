
using mySolutions.Contracts.IRepositories;

namespace mySolutions.Contracts
{
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; } 
        IEmployeeRepository Employee { get; }
        void Save();
    }
}