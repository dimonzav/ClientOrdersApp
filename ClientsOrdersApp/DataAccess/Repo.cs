namespace ClientsOrdersApp.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ClientsOrdersApp.Models;
    using ClientsOrdersApp.ViewModels;

    public class Repo
    {
        private ClientsContext context;

        public Repo()
        {
            this.context = new ClientsContext();
        }

        public Repo(ClientsContext context)
        {
            this.context = context;
        }

        public bool Register(string userName, string password)
        {
            var findUser = this.context.Users.Where(u => u.Username == userName).FirstOrDefault();

            if (findUser == null)
            {
                ApplicationUser user = new ApplicationUser();

                user.UserId = Guid.NewGuid().ToString();
                user.Username = userName;
                user.Password = password;

                this.context.Users.Add(user);

                return this.context.SaveChanges() > 0;
            }
            else
            {
                return false;
            }
        }

        public string Login(string userName, string password)
        {
            var findUser = this.context.Users.Where(u => u.Username == userName).FirstOrDefault();

            if (findUser == null)
            {
                return "User not found";
            }
            else {
                if (findUser.Password == password)
                {
                    return "Success";
                }
                else
                {
                    return "Password are incorect";
                }
            }
        }

        public bool AddClient(string clientName, DateTime clientBirhDay, string clientPhone)
        {
            var findClient = this.context.Clients.Where(c => c.Name == clientName).FirstOrDefault();

            if (findClient != null)
            {
                return false;
            }
            else
            {
                Client client = new Client();

                client.ClientId = Guid.NewGuid().ToString();
                client.Name = clientName;
                client.Birthday = clientBirhDay;
                client.Phone = clientPhone;

                this.context.Clients.Add(client);

                return this.context.SaveChanges() > 0;
            }

        }

        public bool updateClient(string clientId, string clientName, DateTime clientBirhDay, string clientPhone)
        {
            var client = this.context.Clients.Where(c => c.ClientId == clientId).FirstOrDefault();

            client.Name = clientName;
            client.Birthday = clientBirhDay;
            client.Phone = clientPhone;

            return this.context.SaveChanges() > 0;
        }

        public List<Client> GetClients()
        {
            return this.context.Clients.ToList();
        }

        public bool AddOrder(OrderViewModel model)
        {
            Order order = new Order();

            order.OrderId = Guid.NewGuid().ToString();
            order.OrderNumber = model.OrderNumber;
            order.ProductId = model.ProductId;
            order.Price = model.Price;
            order.Created = DateTime.Now;
            order.Status = model.Status;
            order.ClientId = model.ClientId;

            this.context.Orders.Add(order);

            return this.context.SaveChanges() > 0;
        }

        public List<OrderViewModel> GetOrders()
        {
            var ordersDb = this.context.Orders.ToList();

            List<OrderViewModel> orders = new List<OrderViewModel>();

            if(orders != null)
            {
                foreach (var order in ordersDb)
                {
                    OrderViewModel model = new OrderViewModel
                    {
                        OrderId = order.OrderId,
                        OrderNumber = order.OrderNumber,
                        Product = new ProductViewModel(order.Product),
                        Price = order.Price,
                        Created = order.Created,
                        Status = order.Status
                    };

                    orders.Add(model);
                }

                return orders;
            }
            else
            {
                return null;
            }
        }

        public bool ChangeOrderState(string orderId, Enumerables.StatusTypes status)
        {
            var order = this.context.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();
            order.Status = (int)status;

            return this.context.SaveChanges() > 0;
        }

        public bool SaveProduct(int id, string name, string category, double price)
        {
            var findProduct = this.context.Products.Where(p => p.Name == name).FirstOrDefault();

            if (findProduct != null)
            {
                return false;
            }
            else
            {
                var product = new Product();
                product.ProductId = id;
                product.Name = name;
                product.Category = category;
                product.Price = price;

                this.context.Products.Add(product);
            }

            return this.context.SaveChanges() > 0;
        }

        public List<ProductViewModel> GetProducts()
        {
            var productsDb = this.context.Products.ToList();

            List<ProductViewModel> products = new List<ProductViewModel>();

            if (productsDb != null)
            {
                foreach (var product in productsDb)
                {
                    ProductViewModel model = new ProductViewModel
                    {
                        ProductId = product.ProductId,
                        Name = product.Name,
                        Category = product.Category,
                        Price = product.Price
                    };

                    products.Add(model);
                }

                return products;
            }
            else
            {
                return null;
            }
        }
    }
}
