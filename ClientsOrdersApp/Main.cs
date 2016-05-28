using ClientsOrdersApp.DataAccess;
using ClientsOrdersApp.Models;
using ClientsOrdersApp.ViewModels;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsOrdersApp
{
    public partial class Main : Form
    {
        private Repo _repo;
        private EditClient addClient;
        private Products addProduct;
        private OrderForm addOrder;
        private ChangeStatus changeStatus;

        public Main()
        {
            InitializeComponent();

            _repo = new Repo();

            var clients = this._repo.GetClients();
            lbClients.DataSource = clients; 
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            addClient = new EditClient(this);
            addClient.ShowDialog(this);
            addClient.Dispose();
        }

        private void lbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelClienName.Text = (lbClients.SelectedItem as Client).Name;
            var orders = this._repo.GetOrders();
            dgvOrders.DataSource = orders;
            dgvOrders.Refresh();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var selectedClientId = (lbClients.SelectedItem as Client).ClientId;
            addOrder = new OrderForm(selectedClientId);
            addOrder.ShowDialog(this);
            addOrder.Dispose();
        }

        private void editProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addProduct = new Products();
            addProduct.ShowDialog(this);
            addProduct.Dispose();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            var selectedClient = lbClients.SelectedItem as Client;
            addClient = new EditClient(selectedClient, this);
            addClient.ShowDialog(this);
            addClient.Dispose();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            var orderSelected = (OrderViewModel)dgvOrders.CurrentRow.DataBoundItem;

            changeStatus = new ChangeStatus(orderSelected);
            changeStatus.ShowDialog(this);
            changeStatus.Dispose();
        }

        public void RefreshClients()
        {
            lbClients.Refresh();
            lbClients.DataSource = this._repo.GetClients();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var orders = (lbClients.SelectedItem as Client).Orders;
            var orders = this._repo.GetOrders();
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook wb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            Excel.Range aRange = ws.get_Range("C1", "C7");
            Object[] args = new Object[1];
            args[0] = 6;
            aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, args);
           
        }
    }
}
