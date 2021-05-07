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

        public string _sectionNote
        {
            get
            {

                SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
                sqlconn.Open();

                string returnValue = "";



                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlconn;
                cmd.CommandText = "SELECT sl_stores_note, cutting_note, prepping_note, assembly_note, sl_buff_note , packing_note from dbo.door WHERE id=@doorid;";
                cmd.Parameters.AddWithValue("@doorid", _doorID);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {

                    while (rdr.Read())
                    {
                        switch (_dept)
                        {
                            case "SL_Stores":
                                returnValue = rdr["sl_stores_note"].ToString();
                                break;
                            case "Cutting":
                                returnValue = rdr["cutting_note"].ToString();
                                break;
                            case "Prepping":
                                returnValue = rdr["prepping_note"].ToString();
                                break;
                            case "Assembly":
                                returnValue = rdr["assembly_note"].ToString();
                                break;
                            case "SL_Buff":
                                returnValue = rdr["sl_buff_note"].ToString();
                                break;
                            case "SL_Pack":
                                returnValue = rdr["packing_note"].ToString();
                                break;
                            default:

                                break;
                        }
                    }

                }
                else
                {
                    return "";
                }

                sqlconn.Close();

                return returnValue;


            }
        }


        public frmUpdateSection(double doorID, string dept)
        {
            InitializeComponent();
            _doorID = doorID;
            _dept = dept;

            lblDoorID.Text = "Door ID: " + _doorID.ToString();
            lblDept.Text = _dept + " Department";
            lblNote.Text = _dept + " Note";
            txtNote.Text = _sectionNote;


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
            UpdateDepartments ud = new UpdateDepartments(_doorID, _dept);

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

                                // here we are going to ask them if this job is signed off
                                int door_id = Convert.ToInt32(_doorID);
                                DialogResult result = MessageBox.Show("Has this job been signed off?", "Slimline", MessageBoxButtons.YesNo);
                                if (result == DialogResult.No)
                                {
                                    //timestamp + email
                                    using (SqlConnection connStamp = new SqlConnection(SqlStatements.ConnectionString))
                                    {
                                        connStamp.Open();
                                        using (SqlCommand cmdStamp = new SqlCommand("usp_slimline_packing", connStamp))
                                        {
                                            cmdStamp.CommandType = CommandType.StoredProcedure;
                                            cmdStamp.Parameters.Add("@door_id", SqlDbType.Int).Value = door_id;
                                            cmdStamp.Parameters.Add("@pressed", SqlDbType.VarChar).Value = "No";
                                            cmdStamp.ExecuteNonQuery();
                                            return;
                                        }
                                    }
                                }
                                else
                                {
                                    using (SqlConnection connStamp = new SqlConnection(SqlStatements.ConnectionString))
                                    {
                                        connStamp.Open();
                                        using (SqlCommand cmdStamp = new SqlCommand("usp_slimline_packing", connStamp))
                                        {
                                            cmdStamp.CommandType = CommandType.StoredProcedure;
                                            cmdStamp.Parameters.Add("@door_id", SqlDbType.Int).Value = door_id;
                                            cmdStamp.Parameters.Add("@pressed", SqlDbType.VarChar).Value = "Yes";
                                            cmdStamp.ExecuteNonQuery();
                                        }
                                    }
                                }


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

                                if (n == 100 && _dept == "SL_Pack")
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

            private void btnSaveNote_Click(object sender, EventArgs e)
            {
                SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                try
                {
                    switch (_dept)
                    {
                        case "SL_Stores":
                            cmd.CommandText = "UPDATE dbo.door SET sl_stores_note = @note where id = @id ";
                            break;
                        case "Cutting":
                            cmd.CommandText = "UPDATE dbo.door SET cutting_note = @note where id = @id ";
                            break;
                        case "Prepping":
                            cmd.CommandText = "UPDATE dbo.door SET prepping_note = @note where id = @id ";
                            break;
                        case "Assembly":
                            cmd.CommandText = "UPDATE dbo.door SET assembly_note = @note where id = @id ";
                            break;
                        case "SL_Buff":
                            cmd.CommandText = "UPDATE dbo.door SET sl_buff_note = @note where id = @id ";
                            break;
                        case "SL_Pack":
                            cmd.CommandText = "UPDATE dbo.door SET packing_note = @note where id = @id ";
                            break;
                        default:

                            break;
                    }


                    cmd.Parameters.AddWithValue("@note", txtNote.Text);
                    cmd.Parameters.AddWithValue("@id", _doorID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Note saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error occured saving the note. If this error persists please contact IT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
