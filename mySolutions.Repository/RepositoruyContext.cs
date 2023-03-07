using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mySolutions.Domain.Entities;
using mySolutions.Repository;

namespace mySolutions.Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) 
        : base(options)
        { }

        public DbSet<Company>? Companies { get; set; } 
        public DbSet<Employee>? Employees { get; set; }
    }
}