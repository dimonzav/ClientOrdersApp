namespace ClientsOrdersApp.DataAccess
{
    using System.Data.Entity;
    using System.Linq;
    using ClientsOrdersApp.Models;

    public class ClientsContext : DbContext
    {
        public ClientsContext() : base("DefaultConnection")
        {
            this.Database.CommandTimeout = 180;
        }

        public virtual DbSet<ApplicationUser> Users { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
