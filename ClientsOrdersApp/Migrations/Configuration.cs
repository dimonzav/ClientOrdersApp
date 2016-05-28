namespace ClientsOrdersApp.Migrations
{
    using ClientsOrdersApp.DataAccess;
    using ClientsOrdersApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClientsOrdersApp.DataAccess.ClientsContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.CommandTimeout = 60000;
        }

        protected override void Seed(ClientsContext context)
        {
            context.Products.AddOrUpdate(Products());
        }

        private Product[] Products()
        {
            List<Product> list = new List<Product>
            {
                new Product { ProductId = 1, Name = "Sumsung Galaxy S7", Category = "Mobile", Price = 800.99 },
                new Product { ProductId = 2, Name = "Apple iPhone 5s", Category = "Mobile", Price = 350.50 },
                new Product { ProductId = 3, Name = "Huawei Y6 Pro", Category = "Mobile", Price = 175.00 },
                new Product { ProductId = 4, Name = "Lenovo IdeaPad Miix 300", Category = "Notebooks", Price = 285.99 },
                new Product { ProductId = 5, Name = "Dell XPS 15", Category = "Notebooks", Price = 2800.00 },
                new Product { ProductId = 6, Name = "Apple A1502 MacBook", Category = "Notebooks", Price = 1599.99 }
            };

            return list.ToArray();
        }
    }
}
