using System;
using ClientsOrdersApp.DataAccess;
using ClientsOrdersApp.ViewModels;
using Enums = ClientsOrdersApp.DataAccess.Enumerables;
using ClientsOrdersApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsOrdersApp
{
    public partial class OrderForm : Form
    {
        private Repo _repo;
        private string _clientId;

        public OrderForm(string clientId)
        {
            InitializeComponent();

            _clientId = clientId;

            this._repo = new Repo();

            dgvProductsInOrder.DataSource = this._repo.GetProducts();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var orderNumber = tbOrderNumber.Text != "" ? Convert.ToInt32(tbOrderNumber.Text) : 0;
            var selectedProduct = (ProductViewModel)dgvProductsInOrder.CurrentRow.DataBoundItem;
            var orderPrice = Convert.ToDouble(numericPrice.Value);
            if (orderNumber == 0 || selectedProduct == null || orderPrice == 0)
            {
                var message = "All fields required!";
                var caption = "Error creating order!";

                var resultMessageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrderViewModel model = new OrderViewModel
                {
                    OrderNumber = orderNumber,
                    ProductId = selectedProduct.ProductId,
                    Price = orderPrice,
                    Status = (int)Enums.StatusTypes.Notpayed,
                    ClientId = _clientId
                };
                var result = this._repo.AddOrder(model);

                if (result)
                {
                    this.Close();
                }
                else
                {
                    var message = "Error creating order";
                    var caption = "Error!";

                    var resultMessageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductsInOrder_SelectionChanged(object sender, EventArgs e)
        {
            numericPrice.Maximum = decimal.MaxValue;
            numericPrice.Minimum = 0;
            numericPrice.Value = Convert.ToDecimal(dgvProductsInOrder.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
