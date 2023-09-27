using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MVC_Lap2.Models
{
    public class EmployeeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=Company_G4;Trusted_Connection=True;TrustserverCertificate=True");
         
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Emp_Project> Employees_Projects { get; set;}
    }
}
