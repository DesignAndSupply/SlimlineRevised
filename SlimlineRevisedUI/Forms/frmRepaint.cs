using SlimlineRevisedUI.Classes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SlimlineRevisedUI.Forms
{
    public partial class frmRepaint : Form
    {
        public int doorID { get; set; }

        public frmRepaint(int _doorID)
        {
            InitializeComponent();
            doorID = _doorID;
            chkYes.Checked = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYes.Checked == true)
                chkNo.Checked = false;
            else
                chkNo.Checked = true;
        }

        private void chkNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNo.Checked == true)
                chkYes.Checked = false;
            else
                chkYes.Checked = true;
        }

        private void btnRepaint_Click(object sender, EventArgs e)
        {
            string sql = "";

            //get paint id

            int paint_id = 0;
            int staff_id = 0;
            int department = 0;

            if (chkYes.Checked == true)
                department = 5;
            else
                department = 0; //need to change this to a the correct number

            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                sql = "SELECT paint_id from dbo.paint_to_door where door_id = " + doorID.ToString() + "";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    paint_id = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
                sql = "select staff_id from dbo.door_allocation where door_id = " + doorID.ToString() + "";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    staff_id = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                }
                sql = " INSERT INTO dbo.repaints (date_logged,paint_id,amended,painter_name,department,door_id,reason_for_repaint,deduction_successful,repaint_complete,repaint_from_dept)" +
              "VALUES(GETDATE()," + paint_id.ToString() + ",0," + staff_id.ToString() + ",'" + department + "'," + doorID.ToString() + ",'" + txtReason.Text + "',0,0,'Slimline')";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Repaint successfully logged!");
                this.Close();
            }

            //sql = " INSERT INTO dbo.repaints (date_logged,paint_id,amended,painter_name,department,door_id,reason_for_repaint,deduction_successful,repaint_complete,repaint_from_dept)" +
            //    "VALUES(GETDATE()," + paint_id.ToString() + ",0," + staff_id.ToString() + ",'" + department + "'," + doorID.ToString() +",'" + txtReason.Text + "',0,0,'Slimline',";
        }
    }
}