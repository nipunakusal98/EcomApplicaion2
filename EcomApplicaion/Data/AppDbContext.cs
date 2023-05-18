using EcomApplicaion.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomApplicaion.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AntivirusSoftware> AntivirusSoftwares { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerConfiguration> CustomerConfigurations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<VGA> VGAs { get; set; }


    }
}
