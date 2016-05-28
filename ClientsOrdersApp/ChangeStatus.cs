using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientsOrdersApp.DataAccess;
using ClientsOrdersApp.Models;
using ClientsOrdersApp.ViewModels;
using Enums = ClientsOrdersApp.DataAccess.Enumerables;

namespace ClientsOrdersApp
{
    public partial class ChangeStatus : Form
    {
        private Repo _repo;
        private OrderViewModel _order;

        public ChangeStatus()
        {
            InitializeComponent();

            this._repo = new Repo();
        }

        public ChangeStatus(OrderViewModel order)
        {
            InitializeComponent();

            this._repo = new Repo();

            this._order = order;
            labelOrderNumber.Text = order.OrderNumber.ToString();
            cbStatusTypes.DataSource = Enum.GetValues(typeof(Enums.StatusTypes));
        }

        private void btnSetOrderStatus_Click(object sender, EventArgs e)
        {
            Enums.StatusTypes status;
            Enum.TryParse<Enums.StatusTypes>(cbStatusTypes.SelectedValue.ToString(), out status);

            //var changedStatus = cbStatusTypes.SelectedItem;

            var result = this._repo.ChangeOrderState(_order.OrderId, status);
        }
    }
}
