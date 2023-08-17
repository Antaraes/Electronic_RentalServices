/*
 * Created by SharpDevelop.
 * User: ohnma
 * Date: 02/01/2023
 * Time: 9:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentalService
{
	/// <summary>
	/// Description of frmAdminLogin.
	/// </summary>
	public partial class frmMBTAdminLogin : Form
	{
		public frmMBTAdminLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}



		void BtnLoginClick(object sender, EventArgs e)
		{

			Admin admin = new Admin();

			if (admin.Login(txtUserName.Text, txtPassword.Text) == true)
			{
				MessageBox.Show("Log in Success");

				frmMBTItemCreation fic = new frmMBTItemCreation();
				fic.Show();
			}
			else
				MessageBox.Show("Login Fail");

		}

		private void txtUserName_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

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

		private void txtRegister_Click(object sender, EventArgs e)
		{

		}

		private void frmNickyAdminLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
