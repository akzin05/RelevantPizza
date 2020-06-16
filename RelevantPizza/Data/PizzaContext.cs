using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RelevantPizza.Models;

namespace RelevantPizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItemDetail> OrderItemDetails { get; set; }

        //protected override void OnModelCreating (ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().ToTable("Employee");
        //}
        // if you don't want tabel name with Employees use this method
    }
}
