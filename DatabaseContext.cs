using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FastFoodApp
{
    public partial class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Manager>  Managers  { get; set; }
    }

    public class DatabaseContextStandard : DbContext
    {
        public DatabaseContextStandard()
            : base("name=DatabaseContext")
        {
        }
        public DbSet<Product>               Products            { get; set; }
        public DbSet<Ingredient>            Ingredients         { get; set; }
        public DbSet<ProductIngredients>    ProductIngredients  { get; set; }
        public DbSet<Order>                 Orders              { get; set; }
        public DbSet<OrderProducts>         OrderProducts       { get; set; }
        //public DbSet<Request>             Requests            { get; set; }

    }
}
