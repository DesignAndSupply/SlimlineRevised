using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlimlineRevisedUI.Classes;

namespace SlimlineRevisedUI.Forms
{
    public partial class frmConsumableBooking : Form
    {
        public frmConsumableBooking()
        {
            InitializeComponent();
           
            fillList();
        }

        


        private void fillList()
        {

            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select stock_code,description, amount_in_stock from dbo.stock where slimline_stock_yn = -1 and consumable_identifier = -1 and (stock_code like @filter or description like @filter order by description)";
            cmd.Parameters.AddWithValue("@filter", "%" + txtFilter.Text + "%");
            DataSet ds = new DataSet();

            


            SqlDataAdapter adapter = new SqlDataAdapter(
            cmd);
            adapter.Fill(ds);
            this.lstStock.DataSource = ds.Tables[0];
            this.lstStock.ValueMember = "stock_code";
            this.lstStock.DisplayMember = "description";



        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            fillList();
        }

        private void frmConsumableBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_slimline_staff' table. You can move, or remove it, as needed.
            this.c_view_slimline_staffTableAdapter.Fill(this.user_infoDataSet.c_view_slimline_staff);
            cmbStaffID.SelectedIndex = -1;
        }

        private void lstStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.dgvItems.Rows.Add(lstStock.SelectedValue, (lstStock.SelectedItem as DataRowView)["Description"].ToString(), 1, "");
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check for 0 Values

            bool zeroValueFound = false;
            int emptyGridCheck = dgvItems.Rows.Count;
            int selectedOperator = cmbStaffID.SelectedIndex;



            foreach (DataGridViewRow row in dgvItems.Rows) { 


                string qtyCheck = row.Cells["Quantity"].Value.ToString();


                if (qtyCheck == "0" || qtyCheck == "")
                {
                    zeroValueFound = true;
                }
               
            }

            if (zeroValueFound == true)
            {
                MessageBox.Show("One or more items in the list have either a null or zero value quantity assigned. Please check.", "Zero or null detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (emptyGridCheck == 0)
                {
                    MessageBox.Show("Data grid is empty, please select atleast one item", "No items selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (selectedOperator == -1)
                    {
                        MessageBox.Show("Please Select an staff member to assign this item to.", "No Staff member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        updateStock();
                    }
                }
            }


        }


        private void updateStock()
        {

            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();
            cmd.Connection = conn;
            cmd2.Connection = conn;

            foreach(DataGridViewRow row in dgvItems.Rows)
            {

                cmd.Parameters.Clear();
                cmd2.Parameters.Clear();

                cmd.CommandText = "update dbo.stock set amount_in_stock = amount_in_stock - @qty where stock_code = @sc;";
                cmd.Parameters.AddWithValue("@qty", Convert.ToDouble(row.Cells["Quantity"].Value));
                cmd.Parameters.AddWithValue("@sc", row.Cells["StockCode"].Value.ToString());
                cmd.ExecuteNonQuery();




                cmd2.CommandText = "INSERT INTO dbo.stock_log(item_name, quantity,staff_name,transaction_date, stock_code) " +
                                    "VALUES(@itemName,@qty,@staffName,@transactionDate,@sc);";
                cmd2.Parameters.AddWithValue("@qty", Convert.ToDouble(row.Cells["Quantity"].Value));
                cmd2.Parameters.AddWithValue("@sc", row.Cells["StockCode"].Value.ToString());
                cmd2.Parameters.AddWithValue("@itemName", row.Cells["Description"].Value.ToString());
                cmd2.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                cmd2.Parameters.AddWithValue("@staffName", cmbStaffID.Text);
                cmd2.ExecuteNonQuery();


            }



            conn.Close();
        }



    }
}
