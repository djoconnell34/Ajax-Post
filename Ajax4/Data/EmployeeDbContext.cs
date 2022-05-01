using Ajax4.Models;
using Microsoft.EntityFrameworkCore;

namespace Ajax4.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
