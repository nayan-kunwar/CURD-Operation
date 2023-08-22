using _18_08_EmployeeCURD.Models;
using Microsoft.EntityFrameworkCore;

namespace _18_08_EmployeeCURD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
