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

namespace ClientsOrdersApp
{
    public partial class Registration : Form
    {
        private Repo _repo;

        public Registration()
        {
            InitializeComponent();

            _repo = new Repo();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var userName = tbUserName.Text;
            var password = tbPassword.Text;

            var result = _repo.Register(userName, password);

            if (result)
            {
                string message = "User registered successfully";
                string caption = "Register ok";

                var resultMessageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                string message = "Failed to register user. User name is already exist!";
                string caption = "Register error";

                var resultMessageBox = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCanceRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
