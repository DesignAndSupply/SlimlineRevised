using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace SlimlineRevisedUI
{
    public partial class frmMultipleProvingSelection : Form
    {
        public List<int> provingSplitList { get; set; }
        public int cancel { get; set; }
        public frmMultipleProvingSelection()
        {
            InitializeComponent();

            cancel = 0;
            loadGrid();

        }


        private void loadGrid()
        {
            string sql = "select Fullname FROM [user_info].dbo.c_view_slimline_staff ";

            using (SqlConnection conn = new SqlConnection(Classes.SqlStatements.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStaff.DataSource = dt;

                    //add the button
                    DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                    button.Name = "Select Staff";
                    button.Text = "Select Staff";
                    button.UseColumnTextForButtonValue = true;
                    if (dgvStaff.Columns["Select Staff"] == null)
                        dgvStaff.Columns.Insert(dgvStaff.ColumnCount, button);

                    dgvStaff.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvStaff.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                }

                conn.Close();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? " +
                                                  "This will give all of the proving to the person who has this job allocated to them.",
                                                  "Cancel",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cancel = 1;
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dgvStaff.Columns["Select Staff"].Index)
            {
                if (dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.LightSkyBlue)
                    dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Empty;
                else
                    dgvStaff.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            }
            dgvStaff.ClearSelection();

        }

        private void frmMultipleProvingSelection_Shown(object sender, EventArgs e)
        {
            dgvStaff.ClearSelection();
        }

        private void btnSplitProving_Click(object sender, EventArgs e)
        {
            //there needs to be at least two people selected
            int staff_count = 0;
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightSkyBlue)
                {
                    staff_count++;
                }
            }

            if (staff_count < 2)
            {
                MessageBox.Show("You must select at least two people to split the proving between.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            provingSplitList = new List<int>();

            //get all the staff ids and place them into the list
            foreach (DataGridViewRow row in dgvStaff.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.LightSkyBlue)
                {
                    string sql = "SELECT id FROM [user_info].dbo.[user] WHERE forename + ' ' + surname = '" + row.Cells["FullName"].Value.ToString() + "'";

                    using (SqlConnection conn = new SqlConnection(Classes.SqlStatements.ConnectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            int staff_id = Convert.ToInt32(cmd.ExecuteScalar());

                            provingSplitList.Add(staff_id);
                        }

                            conn.Close();
                    }

                }

            }

            this.Close();


        }
    }
}
