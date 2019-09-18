using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DeepCart.Models
{
    public class DeepCartContext : DbContext
    {
        
    
        public DeepCartContext() : base("name=DeepCartContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DeepCartContext, DeepCart.Migrations.Configuration>());
        }

        public System.Data.Entity.DbSet<DeepCart.Models.Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<DeepCart.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<DeepCart.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<DeepCart.Models.OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
