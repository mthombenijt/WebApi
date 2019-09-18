namespace DeepCart.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DeepCart.Models.DeepCartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "DeepCart.Models.DeepCartContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DeepCart.Models.DeepCartContext context)
        {
            
    }
}
