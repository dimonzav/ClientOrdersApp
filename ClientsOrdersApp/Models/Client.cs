namespace ClientsOrdersApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Client
    {
        public Client()
        {
            this.Orders = new HashSet<Order>();
        }

        [Key]
        public string ClientId { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
