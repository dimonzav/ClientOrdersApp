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

namespace ClientsOrdersApp
{
    public partial class EditClient : Form
    {
        private Main _main;
        private Repo _repo;
        private Client _client;

        public EditClient()
        {
            InitializeComponent();

            _repo = new Repo();
        }

        public EditClient(Client client, Main main)
        {
            InitializeComponent();

            _client = client;
            tbClientName.Text = client.Name;
            dtClientBirth.Text = client.Birthday.ToString();
            tbPhoneClient.Text = client.Phone;

            this._main = main;
            this.FormClosing += new FormClosingEventHandler(this.Main_RefreshClients);

            _repo = new Repo();
        }

        public EditClient(Main main)
        {
            InitializeComponent();

            this._main = main;
            this.FormClosing += new FormClosingEventHandler(this.Main_RefreshClients);

            _repo = new Repo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var clientName = tbClientName.Text;
            var clientBirth = Convert.ToDateTime(dtClientBirth.Text);
            var clientPhone = tbPhoneClient.Text;

            if (clientName == "" || clientPhone == "")
            {
                var message = "All field are required!";
                var caption = "Error!";

                var resultMessageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var result = false;
                if (_client != null)
                {
                    result = this._repo.updateClient(_client.ClientId, clientName, clientBirth, clientPhone);
                }
                else if(_main != null)
                {
                    result = this._repo.AddClient(clientName, clientBirth, clientPhone);
                }

                if (result)
                {
                    this.Close();
                }
                else
                {
                    var message = "Client already exist!";
                    var caption = "Error!";

                    var resultMessageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Main_RefreshClients(object sender, FormClosingEventArgs e)
        {
            this._main.RefreshClients();
        }
    }
}
