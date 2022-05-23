using MediaBazaarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApplication
{
    public partial class LoginForm : Form
    {
        private LoginManager loginManager;

        public LoginForm()
        {
            InitializeComponent();

            this.loginManager = new LoginManager(new LoginApplicationSQL());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text != string.Empty && txbPassword.Text != string.Empty)
            {
                if (loginManager.Login(new Employee(txbUsername.Text, txbPassword.Text)) != null)
                {
                    frmMain mainform = new frmMain();
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
            else
            {
                MessageBox.Show("Username/password is not given");
            }
        }
    }
}