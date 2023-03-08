using mySolutions.Contracts.IRepositories;
using mySolutions.Domain.Entities;

namespace mySolutions.Repository.IRepositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
    public EmployeeRepository(RepositoryContext repositoryContext)
                : base(repositoryContext)
        {
        }
        }
}   