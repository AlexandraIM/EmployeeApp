using System.Data.Entity;

namespace EmployeeApp.Models
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }

        public EmployeeContext(): base("EmployeeDb")
        {
            Database.SetInitializer(new DBIitializer());
        }

    }
}