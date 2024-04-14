using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;


namespace Order
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Commodity> Commodities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new YourEntityConfiguration());
        }
    }
}