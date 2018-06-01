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
    public partial class frmUpdateSection : Form
    {

        private double _doorID;
        private string _dept;




        public frmUpdateSection(double doorID, string dept)
        {
            InitializeComponent();
            _doorID = doorID;
            _dept = dept;

            lblDoorID.Text = "Door ID: " + _doorID.ToString();
            lblDept.Text = _dept + " Department";
            
            

            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PROGRESS DATAGRID
            SqlCommand sqlProgress = new SqlCommand();
            sqlProgress.Connection = con;
            sqlProgress.CommandText = "Select * from c_view_slimline_department_progress  WHERE door_id=@doorID and op=@op order by part_complete_date";
            sqlProgress.Parameters.AddWithValue("@doorID", _doorID);
            sqlProgress.Parameters.AddWithValue("@op", _dept);
            SqlDataAdapter sqlProgAdap = new SqlDataAdapter(sqlProgress);



            try
            {

                DataTable dtProgress = new DataTable();
                sqlProgAdap.Fill(dtProgress);
                dgvProgress.DataSource = dtProgress;
            }
            catch
            {

            }


        }

        private void frmUpdateSection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_slimline_staff' table. You can move, or remove it, as needed.
            this.c_view_slimline_staffTableAdapter.Fill(this.user_infoDataSet.c_view_slimline_staff);
            cmbStaffID.SelectedIndex = -1;
        }

       

        private void btnComplete_Click(object sender, EventArgs e)
        {
            UpdateDepartments ud = new UpdateDepartments(_doorID,_dept);

            double n;
            bool isNumeric = Double.TryParse(txtPercentage.Text, out n);

            if (cmbStaffID.SelectedIndex > -1)
            {

                if (isNumeric == true)
                {
                    if (n <= 100)
                    {
                        if (ud._SectionCompleteAmount < (n / 100))
                        {
                            try
                            {
                                double percentageToInsert = (n / 100) - ud._SectionCompleteAmount;
                                double valueTimeToInsert = percentageToInsert * ud._SectionTime;
                                double valueToUpdateDoor = percentageToInsert * ud._SectionTimeSingular;

                                SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                                conn.Open();
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandText = "INSERT INTO dbo.door_part_completion_log(door_id, part_complete_date,time_for_part,part,part_status,staff_id,op,part_percent_complete)" +
                                                  "values (@doorID,@completeDate,@timeForPart,@part,'Complete',@staffID,@op,@partPercentComplete)";
                                cmd.Parameters.AddWithValue("@doorID", _doorID);
                                cmd.Parameters.AddWithValue("@completeDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@timeForPart", valueTimeToInsert);
                                cmd.Parameters.AddWithValue("@part", "Part " + _dept);
                                cmd.Parameters.AddWithValue("@staffID", cmbStaffID.SelectedValue);
                                cmd.Parameters.AddWithValue("@op", _dept);
                                cmd.Parameters.AddWithValue("@partPercentComplete", percentageToInsert);

                                cmd.ExecuteNonQuery();
                                conn.Close();


                                ud.updateDoor(valueToUpdateDoor, n);
                                ud.calibrate();
                                MessageBox.Show("Section successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if(n == 100 && _dept == "SL_Pack")
                                {
                                    frmLooseItems frmLI = new frmLooseItems(_doorID);
                                    frmLI.ShowDialog();
                                }

                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Ann error has occured. Please contact IT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else
                        {
                            MessageBox.Show("The value you have entered is less or equal to the current progress on the job (" + ud._SectionCompleteAmount * 100 + "%)", "Value lower than current progress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Value must be less than or equal to 100!", "Value too high!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                else
                {
                    MessageBox.Show("Only whole number percentages 1-100 can be used. No decimals allowed!", "Whole numbers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a staff member before attempting to continue", "Select staff member", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }









            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.c_view_slimline_staffTableAdapter.FillBy(this.user_infoDataSet.c_view_slimline_staff);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
