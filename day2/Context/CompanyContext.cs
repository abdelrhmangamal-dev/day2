using Microsoft.EntityFrameworkCore;
using MVC_Day2.Models;

namespace day2.Context
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString =
     "Server=(local)\\SQLEXPRESS;" +
     "Database=MVC_Day2;" +
     "Trusted_Connection=True;" +
     "TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            var depts = new List<Department>()
            {
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Finance" },
                new Department { Id = 4, Name = "Admin" }
            };

            var Emps = new List<Employee>()
            {
                new Employee
                {
                    Id = 1,
                    Name = "ahmed",
                    Age = 30,
                    Salary = 9999,
                    DepartmentId = 1
                },

                new Employee
                {
                    Id = 2,
                    Name = "ali",
                    Age = 30,
                    Salary = 55010,
                    DepartmentId = 3
                },

                new Employee
                {
                    Id = 3,
                    Name = "ahmed",
                    Age = 25,
                    Salary = 55010,
                    DepartmentId = 1
                },

                new Employee
                {
                    Id = 4,
                    Name = "sara",
                    Age = 30,
                    Salary = 55010,
                    DepartmentId = 3
                },

                new Employee
                {
                    Id = 5,
                    Name = "aya",
                    Age = 35,
                    Salary = 10000,
                    DepartmentId = 2
                },

                new Employee
                {
                    Id = 6,
                    Name = "mohamed",
                    Age = 30,
                    Salary = 55010,
                    DepartmentId = 1
                }
            };

            modelBuilder.Entity<Department>().HasData(depts);
            modelBuilder.Entity<Employee>().HasData(Emps);
        }
    }
}