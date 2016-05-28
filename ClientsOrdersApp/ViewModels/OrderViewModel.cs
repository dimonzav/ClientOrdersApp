namespace ClientsOrdersApp.ViewModels
{
    using ClientsOrdersApp.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderViewModel
    {
        public string OrderId { get; set; }

        [Required]
        public int OrderNumber { get; set; }

        [Required]
        public int ProductId { get; set; }

        public virtual ProductViewModel Product { get; set; }

        [Required]
        public double Price { get; set; }
        
        public DateTime Created { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public string ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
