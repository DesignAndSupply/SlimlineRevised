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

namespace SlimlineRevisedUI.Forms
{
    public partial class frmAllocateWork : Form
    {
        public frmAllocateWork()
        {
            InitializeComponent();
        }

        private void FrmAllocateWork_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_slimline_staff' table. You can move, or remove it, as needed.
            this.c_view_slimline_staffTableAdapter.Fill(this.user_infoDataSet.c_view_slimline_staff);

        }

        private void BtnAllocate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Classes.SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("usp_allocate_slimline_work", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@doorID", SqlDbType.Int).Value = txtDoorID.Text;
            cmd.Parameters.Add("@staffID", SqlDbType.Int).Value = cmbStaff.SelectedValue;
            cmd.Parameters.Add("@department", SqlDbType.VarChar).Value = cmbDepartment.Text;

            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();

        }
    }
}
