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

        private double doorID;
        private string operation;
        private string timeStarted;



        public frmWorkAllocation()
        {
            InitializeComponent();
            dgvAllocation.CellClick += dgvAllocation_CellClick;

        }

        private void frmWorkAllocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_slimline_staff' table. You can move, or remove it, as needed.
            this.c_view_slimline_staffTableAdapter.Fill(this.user_infoDataSet.c_view_slimline_staff);
            cmbStaffID.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PROGRESS DATAGRID
            SqlCommand sqlAllocation = new SqlCommand();
            sqlAllocation.Connection = con;
            sqlAllocation.CommandText = "Select id, section, [Op Date], [Allocated To], [Started op] from c_view_slimline_allocation WHERE [Allocated to] = @allo order by [Op Date]";
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
                columnIndex = 6;

                if (dgvAllocation.Columns["Print Label"] == null)
                {
                    dgvAllocation.Columns.Insert(columnIndex, LabelButton);
                }

            }
            catch
            {

            }
        }

        private void dgvAllocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllocation.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvAllocation.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvAllocation.Rows[selectedrowindex];

                doorID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                operation = selectedRow.Cells["section"].Value.ToString();
                timeStarted = selectedRow.Cells["Started Op"].Value.ToString();

            }



            if (e.ColumnIndex == dgvAllocation.Columns["Take Job"].Index)
            {
                UpdateDepartments ud = new UpdateDepartments(doorID, operation);

                if (string.IsNullOrWhiteSpace(timeStarted))
                {
                    ud.updateStarted(false);
                }
                else
                {
                    ud.updateStarted(true);
                }

                
                fillGrid();
            }





        }

        private void dgvAllocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

