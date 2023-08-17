using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RentalService
{
    public partial class frmMBTCustomerview : Form
    {
        int id;
        string customerName;
        string password;
        string email;
        string phone;
        string address;
        string constr;
        OleDbCommand mycmd;
        OleDbDataReader myreader;
        OleDbConnection conn;

        int iRowIndex;
        DataTable table;
        OleDbDataAdapter dataAdapter;
        public frmMBTCustomerview()
        {
            InitializeComponent();
            
        }
        
        void ShowGridView()
        {
            string query = "SELECT * FROM Customer;"; // SQL Query

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(query, conn);
            table = new DataTable("CustomerTable");

            conn.Open();
            dataadapter.Fill(table);
            dataGridView1.DataSource = table;

            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iRowIndex = dataGridView1.CurrentRow.Index;
            ShowGridView();
        }

        private void frmMBTCustomerview_Load(object sender, EventArgs e)
        {
            constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\MBTRentalDB.mdb";

            conn = new OleDbConnection();
            conn.ConnectionString = constr;

            string query = "SELECT * FROM Customer;"; // SQL Query

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(query, conn);
            table = new DataTable("CustomerTable");

            conn.Open();
            dataadapter.Fill(table);
            dataGridView1.DataSource = table;

            conn.Close();
        }

        

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmMBTRegistration fcl = new frmMBTRegistration();
            fcl.Show();
            this.Hide();
        }
    }
}
