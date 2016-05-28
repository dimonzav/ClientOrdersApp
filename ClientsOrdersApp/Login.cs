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
    public partial class Login : Form
    {
        private Main main;
        private Registration registerForm;
        private Repo _repo;

        public Login()
        {
            InitializeComponent();

            _repo = new Repo();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            registerForm = new Registration();
            registerForm.ShowDialog(this);
            registerForm.Dispose();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var userName = tbLogin.Text;
            var password = tbPassword.Text;

            var result = this._repo.Login(userName, password);

            if (result == "Success")
            {
                this.Hide();
                main = new Main();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
            else
            {
                string caption = "Login";

                var resultMessageBox = MessageBox.Show(result, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
