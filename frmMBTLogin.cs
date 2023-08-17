using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalService
{
    public partial class frmMBTLogin : Form
    {
        public frmMBTLogin()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();
            GlobalData._UserId = db.checkRegCustomer(txtUsername.Text, txtPassword.Text);
            Admin admin = new Admin();

            if (admin.Login(txtUsername.Text, txtPassword.Text) == true)
            {
                MessageBox.Show("Log in Success by Admin");

                frmMBTadminchoice fic = new frmMBTadminchoice();
                fic.Show();
            }
            
            else if (GlobalData._UserId != 0)
            {
               
                MessageBox.Show("Login Success by" + txtUsername.Text);
                GlobalData._Username = txtUsername.Text;
                frmMBTRentalForm rental = new frmMBTRentalForm();
                rental.Show();

            }
            else
                MessageBox.Show("Login Failure");
        }

        private void chckShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShow.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            frmMBTRegistration fcl = new frmMBTRegistration();
            fcl.Show();
            this.Hide();
        }
    }
    
}
