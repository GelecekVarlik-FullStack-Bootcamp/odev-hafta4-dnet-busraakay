using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Models
{
    public class Homework4Context : DbContext
    {
        IConfiguration configuration;
        public Homework4Context()
        {
            
        }

        public Homework4Context(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));
            
            optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=Homework4; integrated security=true");

        }

        

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
