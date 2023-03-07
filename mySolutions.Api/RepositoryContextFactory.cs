using mySolutions.Repository;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace mySolutions.Api
{
   public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext> {
     public RepositoryContext CreateDbContext(string[] args) 
     
     { 
        var configuration = new ConfigurationBuilder() 
            .SetBasePath(Directory.GetCurrentDirectory()) 
            .AddJsonFile("appsettings.json") 
            .Build(); 

         var builder = new DbContextOptionsBuilder<RepositoryContext>() 
           .UseSqlServer(configuration.GetConnectionString("sqlConnection"), 
                b => b.MigrationsAssembly("mySolutions.Api"));
            return new RepositoryContext(builder.Options); } 








     }
}