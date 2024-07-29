using Microsoft.EntityFrameworkCore;
using MvcAppWIthEF.Models;

namespace MvcAppWIthEF.Context
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options)
        : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
