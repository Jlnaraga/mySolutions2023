using mySolutions.Contracts.IRepositories;
using mySolutions.Domain.Entities;

namespace mySolutions.Repository.Repositories
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository 
    {
        public CompanyRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext) 
            {   
            }
    }
}