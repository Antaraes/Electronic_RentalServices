using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; // for Database Connection
using System.Data.SqlClient;

namespace RentalService
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class frmMBTItemCreation : Form
    {

        int id;
        int catid;
        string itemName;
        string dimensions;
        string capacity;
        string colour;
        double rating;
        double monthlyFee;
        string minContractPeriod;
        string available;
        string constr;

        OleDbCommand mycmd;
        OleDbDataReader myreader;
        OleDbConnection conn;

        int iRowIndex;
        DataTable table;
        OleDbDataAdapter dataadapter;

        public frmMBTItemCreation()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\MBTRentalDB.mdb";

            conn = new OleDbConnection();
            conn.ConnectionString = constr;

            string query = "SELECT * FROM item order by ID ASC"; // SQL Query

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(query, conn);
            table = new DataTable("ItemTable");

            conn.Open();
            dataadapter.Fill(table);
            conn.Close();

            dataGridView1.DataSource = table;

        }

        void BtnExitClick(object sender, EventArgs e)
        {
            frmMBTadminchoice fr = new frmMBTadminchoice();
            fr.Show();
            this.Close();

        }

        void BtnNewClick(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDimensions.Text = "";
            txtCapacity.Text = "";
            txtColour.Text = "";
            txtRating.Text = "";
            txtMonthlyFee.Text = "";
            txtMinContractPeriod.Text = "";

            ShowGridView();
        }

        void ShowGridView()
        {

            string query = "SELECT * FROM item order by ID ASC;";

            conn = new OleDbConnection(constr);

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(query, conn);
            table = new DataTable("ItemTable");
            conn.Open();
            dataadapter.Fill(table);
            conn.Close();
            dataGridView1.DataSource = table;

        }

        void BindObject()
        {
       
            itemName = txtName.Text;
            dimensions = txtDimensions.Text;
            capacity = txtCapacity.Text;
            colour = txtColour.Text;
            rating = double.Parse(txtRating.Text);
            monthlyFee = double.Parse(txtMonthlyFee.Text);
            minContractPeriod = txtMinContractPeriod.Text;
            available = "yes";
        }

        void BtnInsertClick(object sender, EventArgs e)
        {
            catid = cboAppliances.SelectedIndex + 1;
            BindObject();

            if ( txtName.Text == "" || txtDimensions.Text == "" || txtCapacity.Text == "" || txtColour.Text == "" || txtRating.Text == "" || txtMonthlyFee.Text == "" || txtMinContractPeriod.Text == "")
            {
                MessageBox.Show("Please enter all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = 0;

            string query = "SELECT MAX(Id) FROM Item";
            mycmd = new OleDbCommand(query, conn);

            try
            {
                conn.Open();
                if (mycmd.ExecuteScalar() != DBNull.Value)
                    id = Convert.ToInt32(mycmd.ExecuteScalar().ToString());
                else
                    id = 0;
            }
            catch (OleDbException oex)
            {
                throw oex;
            }
            finally
            {
                conn.Close();
            }

            id = id + 1;
            lblID.Text = "ID= " + id.ToString();

            try
            {
                //query = "INSERT INTO item VALUES(" + id + ","+catid +","+ "','"+ itemName + "','" + dimensions + "','" + capacity + "','" + colour + "'," + rating + "," + monthlyFee + ",'" + minContractPeriod + "','" + available + "')";
                query = string.Format("INSERT INTO item VALUES({0},{1},'{2}','{3}','{4}','{5}',{6},{7},'{8}','{9}')", id, catid, itemName, dimensions, capacity, colour, rating, monthlyFee, minContractPeriod, available);

                MessageBox.Show("Please Inssert"+ query, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                conn.Open();
                mycmd = new OleDbCommand(query, conn);
                mycmd.ExecuteScalar();

                lblMessage.Text = "Record Saved!";
            }
            catch (Exception ee)
            {
                conn.Close();
            }

            conn.Close();
        }

        void BtnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                int rid = iRowIndex + 1;

                if (this.table.Rows.Count == this.iRowIndex)
                    return;
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this row?", "Confirm deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = "DELETE FROM item WHERE ID=" + rid;

                    conn = new OleDbConnection(constr);
                    conn.Open();
                    mycmd = new OleDbCommand(query, conn);
                    mycmd.ExecuteNonQuery();

                    lblMessage.Text = "Record Deleted!";
                }
            }
            catch (Exception ee)
            {
                conn.Close();
            }

            conn.Close();
        }

        void BtnUpdateClick(object sender, EventArgs e)
        {
            BindObject();

            try
            {
                int rid = iRowIndex + 1;

                if (this.table.Rows.Count == this.iRowIndex)
                    return;
                DialogResult dr = MessageBox.Show("Are you sure you want to update this row?", "Confirm updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = "UPDATE item SET ID=" + rid + ", Name='" + itemName + "', Dimensions='" + dimensions + "', Capacity='" + capacity + "', Colour='" + colour + "', Rating='" + rating + "', [Monthly Fee]=" + monthlyFee + ", [Minimum Contract Period]=" + minContractPeriod + ", Available='" + available + "' WHERE ID=" + rid;

                    conn = new OleDbConnection(constr);
                    conn.Open();
                    mycmd = new OleDbCommand(query, conn);
                    mycmd.ExecuteNonQuery();

                    lblMessage.Text = "Record Updated!";
                }
            }
            catch (Exception ee)
            {
                conn.Close();
            }

            conn.Close();

            ShowGridView();
        }

        void DataGridView1Click(object sender, EventArgs e)
        {
            iRowIndex = dataGridView1.CurrentRow.Index;
            databind();
        }

        void databind()
        {
            int id = iRowIndex;

            string query = "SELECT * FROM item WHERE ID=" + id;
            conn = new OleDbConnection(constr);
            conn.Open();
            mycmd = new OleDbCommand(query, conn);
            OleDbDataReader myreader;
            myreader = mycmd.ExecuteReader();
            while (myreader.Read())
            {
                string cid = myreader.GetValue(1).ToString();
                if (cid == "1")
                {
                    cboAppliances.SelectedIndex = 0;
                    catid = 1;
                }
                else
                {
                    cboAppliances.SelectedIndex = 1;
                    catid = 2;
                }
                txtName.Text = myreader.GetValue(2).ToString();
                txtDimensions.Text = myreader.GetValue(3).ToString();
                txtCapacity.Text = myreader.GetValue(4).ToString();
                txtColour.Text = myreader.GetValue(5).ToString();
                txtRating.Text = myreader.GetValue(6).ToString();
                txtMonthlyFee.Text = myreader.GetValue(7).ToString();
                txtMinContractPeriod.Text = myreader.GetValue(8).ToString();
                
                
            }
            myreader.Close();
            conn.Close();
        }



    }
}
