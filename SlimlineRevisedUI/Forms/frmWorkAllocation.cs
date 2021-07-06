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
            this.dgvAllocation.CellFormatting += dgvAllocation_CellFormatting;
           
        }

        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            try
            {
                dgvAllocation.Columns.Remove("Pause / Resume");
            }
            catch
            {
            }
            try
            {
                dgvAllocation.Columns.Remove("Print Label");
            }
            catch
            {
            }
            try
            {
                dgvAllocation.Columns.Remove("Take Job");
            }
            catch
            {
            }
            dgvAllocation.DataSource = null;
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PROGRESS DATAGRID
            SqlCommand sqlAllocation = new SqlCommand();
            sqlAllocation.Connection = con;
            sqlAllocation.CommandText = "select a.id, section, [Op Date], [Allocated To], [Started op],[action] from c_view_slimline_allocation a left join " +
                " (Select a.id, b.maxID, action, a.door_id, a.department from dbo.door_stoppages a inner join (" +
                " select max(id) as maxID, door_id, department from dbo.door_stoppages  group by door_id, department) as b on a.id = b.maxID ) b on a.id = b.door_id and a.Section = b.department   WHERE [Allocated to] = @allo order by [Op Date],a.id";
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

                //start/pause job
                DataGridViewButtonColumn startPauseButton = new DataGridViewButtonColumn();
                //startPauseButton.Text = " ";
                startPauseButton.Name = "Pause / Resume";
                startPauseButton.UseColumnTextForButtonValue = true;
                columnIndex = 7;

                if (dgvAllocation.Columns["Pause / Resume"] == null)
                {
                    dgvAllocation.Columns.Insert(columnIndex, startPauseButton);
                }

            }
            catch
            {

            }
            dgvAllocation.Columns[dgvAllocation.Columns.Count - 1].Visible = false;
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

            if (e.ColumnIndex == dgvAllocation.Columns["Pause / Resume"].Index)
            {
                int actionIndex = 0;
                int sectionIndex = 0;
                int doorIDIndex = 0;
                doorIDIndex = dgvAllocation.Columns["id"].Index;
                sectionIndex = dgvAllocation.Columns["section"].Index;
                int door_id = 0;
                string section = "";
                section = Convert.ToString(dgvAllocation.Rows[e.RowIndex].Cells[sectionIndex].Value.ToString());
                door_id = Convert.ToInt32(dgvAllocation.Rows[e.RowIndex].Cells[actionIndex].Value.ToString());
                int staff_id = 0;
                string sql = "";
                actionIndex = dgvAllocation.Columns["action"].Index;
                string temp = dgvAllocation.Rows[e.RowIndex].Cells[actionIndex].Value.ToString();
                if (String.IsNullOrWhiteSpace(temp))
                    temp = "Live";
                //check what the last action is and insert into dbo.door_stoppages
                using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
                {
                    conn.Open();
                    //get the staff id
                    sql = "Select id FROM [user_info].dbo.[user] where forename + ' ' + surname = '" + cmbStaffID.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        staff_id = Convert.ToInt32(cmd.ExecuteScalar());

                    //add the note
                    frmNoteEntry frm = new frmNoteEntry(section, door_id,staff_id);
                    frm.ShowDialog();
                    

                    if (temp == "Live")
                        sql = "INSERT INTO dbo.door_stoppages (action,action_time,department,door_id,staff_id) VALUES ('Paused',GETDATE(),'" + section + "'," + door_id + "," + staff_id + ")";
                    else
                        sql = "INSERT INTO dbo.door_stoppages (action,action_time,department,door_id,staff_id) VALUES ('Live',GETDATE(),'" + section + "'," + door_id + "," + staff_id + ")";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                        cmd.ExecuteNonQuery();
                    conn.Close();
                    
                }
            }

            if (e.ColumnIndex == dgvAllocation.Columns["Print Label"].Index)
            {

                PackingLabel pl = new PackingLabel();

                pl.printSmallPackingLabel(doorID.ToString());
                pl.printLargePackingLabel(doorID.ToString());

            }




            btnUpdate.PerformClick();
        }

        private void dgvAllocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmWorkAllocation_Shown(object sender, EventArgs e)
        {

        }

        private void dgvAllocation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int actionIndex = 0;
            actionIndex = dgvAllocation.Columns["action"].Index;
            int pauseButton = 0;
            pauseButton = 7;// dgvAllocation.Columns["Pause / Resume"].Index;
            //// If this is a new header row or row, do nothing
            if (e.RowIndex < 0 || e.RowIndex == this.dgvAllocation.NewRowIndex)
                return;

            //If your column type button is 0, you must validate this
            if (e.ColumnIndex == pauseButton)
            {
                string status = dgvAllocation.Rows[e.RowIndex].Cells["action"].Value.ToString();
                if (string.IsNullOrEmpty(status) || status == "Live" )
                    status = "Pause";
                else
                    status = "Resume";
                e.Value = status;
            }
        }
    }
}

