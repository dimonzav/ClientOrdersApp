namespace ClientsOrdersApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Order
    {
        [Key]
        public string OrderId { get; set; }

        [Required]
        public int OrderNumber { get; set; }

        [Required]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public int Status { get; set; }

        public string ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
