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
    public partial class frmMBTRegistration : Form
    {
        public frmMBTRegistration()
        {
            InitializeComponent();
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text.Trim();

            // Validate the fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields (username, email, and password).");
                return;
            }

            // Validate the username using a regular expression
            string usernamePattern = "^[a-zA-Z0-9]+$";
            bool isUsernameValid = System.Text.RegularExpressions.Regex.IsMatch(username, usernamePattern);

            if (!isUsernameValid)
            {
                MessageBox.Show("Invalid username. Usernames can only contain letters and numbers.");
                return;
            }

            // Validate the email format using a regular expression
            string emailPattern = @"^[A-Za-z0-9]+[A-Za-z0-9._-]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isEmailValid = System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);

            if (!isEmailValid)
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.");
                return;
            }

            // Validate the password requirements
            if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Password must be between 8 and 16 characters in length.");
                return;
            }

            bool hasLowercase = false;
            bool hasUppercase = false;

            foreach (char i in password)
            {
                if (char.IsLower(i))
                {
                    hasLowercase = true;
                }
                else if (char.IsUpper(i))
                {
                    hasUppercase = true;
                }

                if (hasLowercase && hasUppercase)
                {
                    break;
                }
            }

            if (!hasLowercase || !hasUppercase)
            {
                MessageBox.Show("Password must contain at least one lowercase and one uppercase letter.");
                return;
            }

            // Validate if the email already exists
            DBClass dbc = new DBClass();
            if (dbc.checkExistingCustomer(username) != 0)
            {
                MessageBox.Show("Customer name already exists.");
                return;
            }

            if (dbc.checkExistingEmail(email))
            {
                MessageBox.Show("Email already exists.");
                return;
            }

            // If all validations pass, proceed with creating the account
            Customer c = new Customer
            {
                Name = username,
                Password = password,
                Phone = phone,
                Email = email
            };

            dbc.CreateAccount(c);
            MessageBox.Show("Registration Successfully Completed");
 
            frmMBTLogin fcl = new frmMBTLogin();
            fcl.Show();
            this.Hide();
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            frmMBTLogin fcl = new frmMBTLogin();
            fcl.Show();
            this.Hide();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
