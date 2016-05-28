namespace ClientsOrdersApp.ViewModels
{
    using ClientsOrdersApp.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductViewModel
    {
        public ProductViewModel()
        {

        }

        public ProductViewModel(Product item)
        {
            this.Name = item.Name;
        }

        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Category { get; set; }
    }
}
