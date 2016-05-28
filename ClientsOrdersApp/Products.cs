using System;
using System.Collections.Generic;
using ClientsOrdersApp.DataAccess;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsOrdersApp
{
    public partial class Products : Form
    {
        private Repo _repo;
        public Products()
        {
            InitializeComponent();

            _repo = new Repo();

            dgvProducts.DataSource = this._repo.GetProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvProducts.SelectedRows)
            {
                dgvProducts.Rows.RemoveAt(row.Index);
            }
        }
    }
}
