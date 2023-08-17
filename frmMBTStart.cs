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
    public partial class frmMBTStart : Form
    {
        public frmMBTStart()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmMBTAdminLogin adm = new frmMBTAdminLogin();
            adm.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmMBTRegistration reg = new frmMBTRegistration();
            reg.Show();
        }

        private void frmNickyStart_Load(object sender, EventArgs e)
        {

        }
    }
}
