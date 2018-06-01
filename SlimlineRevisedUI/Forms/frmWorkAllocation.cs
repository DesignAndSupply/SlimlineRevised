using SlimlineRevisedUI.Classes;
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

namespace SlimlineRevisedUI.Forms
{
    public partial class frmWorkAllocation : Form
    {
        public frmWorkAllocation()
        {
            InitializeComponent();

        }

        private void frmWorkAllocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_slimline_staff' table. You can move, or remove it, as needed.
            this.c_view_slimline_staffTableAdapter.Fill(this.user_infoDataSet.c_view_slimline_staff);
            cmbStaffID.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PROGRESS DATAGRID
            SqlCommand sqlAllocation = new SqlCommand();
            sqlAllocation.Connection = con;
            sqlAllocation.CommandText = "Select id, section, [Op Date], [Allocated To] from c_view_slimline_allocation WHERE [Allocated to] = @allo order by [Op Date]";
            sqlAllocation.Parameters.AddWithValue("@allo", cmbStaffID.Text);

            SqlDataAdapter sqlAlloAdap = new SqlDataAdapter(sqlAllocation);



            try
           {

                DataTable dtAllo = new DataTable();
                sqlAlloAdap.Fill(dtAllo);
                dgvAllocation.DataSource = dtAllo;

                DataGridViewButtonColumn takeButton = new DataGridViewButtonColumn();
                takeButton.Text = "Take Job";
                takeButton.Name = "Take Job";
                takeButton.UseColumnTextForButtonValue = true;
                int columnIndex = 4;

                if (dgvAllocation.Columns["Take Job"] == null)
                {
                    dgvAllocation.Columns.Insert(columnIndex, takeButton);
                }

                DataGridViewButtonColumn LabelButton = new DataGridViewButtonColumn();
                LabelButton.Text = "Print Label";
                LabelButton.Name = "Print Label";
                LabelButton.UseColumnTextForButtonValue = true;
                columnIndex = 5;

                if (dgvAllocation.Columns["Print Label"] == null)
                {
                    dgvAllocation.Columns.Insert(columnIndex, LabelButton);
                }

            }
            catch
            {

            }
        }
    }
}

