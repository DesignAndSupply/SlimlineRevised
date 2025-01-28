using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SlimlineRevisedUI.Classes
{
    public class UpdateDepartments
    {

        //property list
        public string _sectionName { get; set; }
        public double _doorId { get; set; }

        public double _SectionTime
        {
            get
            {

                SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
                sqlconn.Open();

                double returnValue = 0;

                double proving_time = 0;

                string sqlProving = "select addition_time_SL_buff * addition_quantity " +
                                    "FROM dbo.door_addition where addition_id = 88 and door_id = " + _doorId;
                //remove the time for addition 88 here
                using (SqlCommand cmdProving = new SqlCommand(sqlProving, sqlconn))
                {
                    var fuga = cmdProving.ExecuteScalar();
                    if (fuga != null)
                    {
                        proving_time = Convert.ToDouble(fuga);
                    }
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlconn;
                cmd.CommandText = "SELECT quantity_same, time_SL_stores,time_cutting,time_prep, time_assembly,time_SL_buff,time_pack from dbo.door where id=@doorid;";
                cmd.Parameters.AddWithValue("@doorid", _doorId);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {

                    while (rdr.Read())
                    {
                        switch (_sectionName)
                        {
                            case "SL_Stores":
                                returnValue = Convert.ToDouble(rdr["time_sl_stores"]);
                                break;
                            case "Cutting":
                                returnValue = Convert.ToDouble(rdr["time_cutting"]) * Convert.ToInt32(rdr["quantity_same"]);
                                break;
                            case "Prepping":
                                returnValue = Convert.ToDouble(rdr["time_prep"]) * Convert.ToInt32(rdr["quantity_same"]);
                                break;
                            case "Assembly":
                                returnValue = Convert.ToDouble(rdr["time_assembly"]) * Convert.ToInt32(rdr["quantity_same"]);
                                break;
                            case "SL_Buff":

                                if (SqlStatements.proving == 0)
                                {
                                    returnValue = (Convert.ToDouble(rdr["time_sl_buff"]) * Convert.ToInt32(rdr["quantity_same"])) - proving_time;
                                }
                                else
                                {
                                    returnValue = proving_time;
                                }
                                break;
                            case "SL_Pack":
                                returnValue = Convert.ToDouble(rdr["time_pack"]) * Convert.ToInt32(rdr["quantity_same"]);
                                break;
                            default:
                                returnValue = Convert.ToDouble(rdr["time_sl_stores"]) * Convert.ToInt32(rdr["quantity_same"]);
                                break;
                        }
                    }

                }
                else
                {
                    return 0;
                }

                sqlconn.Close();

                return returnValue;


            }
        }


        public double _SectionTimeSingular
        {
            get
            {

                SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
                sqlconn.Open();

                double returnValue = 0;
                double proving = 0;
                string sqlProving = "select addition_time_SL_buff * addition_quantity " +
                             "FROM dbo.door_addition where addition_id = 88 and door_id = " + _doorId;
                //remove the time for addition 88 here
                using (SqlCommand cmdProving = new SqlCommand(sqlProving, sqlconn))
                {
                    var fuga = cmdProving.ExecuteScalar();
                    if (fuga != null)
                    {
                        proving = Convert.ToDouble(fuga);
                    }
                }


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlconn;
                cmd.CommandText = "SELECT quantity_same, time_SL_stores,time_cutting,time_prep, time_assembly,time_SL_buff,time_pack from dbo.door where id=@doorid;";
                cmd.Parameters.AddWithValue("@doorid", _doorId);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {

                    while (rdr.Read())
                    {
                        switch (_sectionName)
                        {
                            case "SL_Stores":
                                returnValue = Convert.ToDouble(rdr["time_sl_stores"]);
                                break;
                            case "Cutting":
                                returnValue = Convert.ToDouble(rdr["time_cutting"]);
                                break;
                            case "Prepping":
                                returnValue = Convert.ToDouble(rdr["time_prep"]);
                                break;
                            case "Assembly":
                                returnValue = Convert.ToDouble(rdr["time_assembly"]);
                                break;
                            case "SL_Buff":
                                if (SqlStatements.proving == -1)
                                {
                                    returnValue = proving;
                                }
                                else
                                {
                                    returnValue = Convert.ToDouble(rdr["time_sl_buff"]) - proving;
                                }
                                break;
                            case "SL_Pack":
                                returnValue = Convert.ToDouble(rdr["time_pack"]);
                                break;
                            default:
                                returnValue = Convert.ToDouble(rdr["time_sl_stores"]);
                                break;
                        }
                    }

                }
                else
                {
                    return 0;
                }

                sqlconn.Close();

                return returnValue;


            }
        }

        public double _SectionCompleteAmount
        {
            get
            {

                SqlConnection sqlconn = new SqlConnection(SqlStatements.ConnectionString);
                sqlconn.Open();

                double returnValue = 0;

                if (SqlStatements.proving == -1)
                {
                    //check if slimline proving has been clicked before
                    string sql = "SELECT id FROM dbo.door_part_completion_log WHERE op = 'SL Proving' and door_id = " + _doorId;
                    using (SqlCommand cmd = new SqlCommand(sql, sqlconn))
                    {
                        var fuga = cmd.ExecuteScalar();

                        if (fuga == null)
                            returnValue = 0;
                        else
                            returnValue = Convert.ToDouble(fuga);
                    }
                }
                else
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlconn;
                    cmd.CommandText = "SELECT * FROM c_view_slimline_summed_progress WHERE door_id=@doorid and op=@op";
                    cmd.Parameters.AddWithValue("@doorid", _doorId);
                    cmd.Parameters.AddWithValue("@op", _sectionName);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {

                        while (rdr.Read())
                        {
                            returnValue = Convert.ToDouble(rdr["SumPartPercent"]);
                        }

                    }
                    else
                    {
                        returnValue = 0;
                    }
                }

                sqlconn.Close();

                return returnValue;


            }
        }


        // End of property list





        public UpdateDepartments(double doorID, string section)
        {
            _sectionName = section;
            _doorId = doorID;

        }

        public void updateStarted(bool toggleMode)
        {


            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;


            switch (_sectionName)
            {
                case "SL_Stores":

                    break;
                case "Cutting":
                    ;
                    cmd.CommandText = "UPDATE dbo.door_allocation set started_cut = @now where door_id = @doorID";
                    break;
                case "Prepping":
                    cmd.CommandText = "UPDATE dbo.door_allocation set started_prep = @now where door_id = @doorID";
                    break;
                case "Assembly":
                    cmd.CommandText = "UPDATE dbo.door_allocation set started_assembly = @now where door_id = @doorID";
                    break;
                case "SL_Buff":
                    cmd.CommandText = "UPDATE dbo.door_allocation set started_sl_buff = @now where door_id = @doorID";
                    break;
                case "SL_Pack":
                    cmd.CommandText = "UPDATE dbo.door_allocation set started_pack = @now where door_id = @doorID";
                    break;
                default:

                    break;
            }

            if (toggleMode == false)
            {

                cmd.Parameters.AddWithValue("@now", DateTime.Now);
                cmd.Parameters.AddWithValue("@doorID", _doorId);
            }
            else
            {

                cmd.Parameters.AddWithValue("@now", DBNull.Value);
                cmd.Parameters.AddWithValue("@doorID", _doorId);
            }




            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void updateDoor(double updateAmount, double updatePercentage)
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            double proving_time = 0;

            string sqlProving = "select addition_time_SL_buff * addition_quantity " +
                                "FROM dbo.door_addition where addition_id = 88 and door_id = " + _doorId;
            //remove the time for addition 88 here
            using (SqlCommand cmdProving = new SqlCommand(sqlProving, conn))
            {
                var fuga = cmdProving.ExecuteScalar();
                if (fuga != null)
                {
                    proving_time = Convert.ToDouble(fuga);
                }
            }


            switch (_sectionName)
            {
                case "SL_Stores":
                    cmd.CommandText = "UPDATE dbo.door set complete_SL_stores = @opComp, date_sl_stores_complete = @dateComp,  time_reamining_sl_stores = time_reamining_sl_stores - @amountToDeduct WHERE id = @doorID";
                    break;
                case "Cutting":
                    cmd.CommandText = "UPDATE dbo.door set complete_cutting = @opComp, date_cutting_complete = @dateComp, time_remaining_cutting = time_remaining_cutting - @amountToDeduct WHERE id = @doorID";
                    break;
                case "Prepping":
                    cmd.CommandText = "UPDATE dbo.door set complete_prep = @opComp, date_prepping_complete = @dateComp, time_remaining_prepping = time_remaining_prepping - @amountToDeduct WHERE id = @doorID";
                    break;
                case "Assembly":
                    cmd.CommandText = "UPDATE dbo.door set complete_assembly = @opComp, date_assembly_complete = @dateComp, time_remianing_assembly = time_remianing_assembly - @amountToDeduct WHERE id = @doorID";
                    break;
                case "SL_Buff":

                    cmd.CommandText = "UPDATE dbo.door set complete_SL_buff = @opComp, date_SL_buff_complete = @dateComp, " +
                        "time_remaining_sl_buff = time_remaining_sl_buff - @amountToDeduct WHERE id = @doorID";
                    break;
                case "SL_Pack":
                    cmd.CommandText = "UPDATE dbo.door set complete_pack =@opComp, date_pack_complete = @dateComp, time_remaining_pack = time_remaining_pack - @amountToDeduct WHERE id = @doorID";
                    break;
                default:

                    break;
            }



            if (updatePercentage == 100)
            {
                //check if it has the proving addon -- 88

                string sql = "SELECT addition_id FROM dbo.door_addition where door_id = " + _doorId + " AND addition_id = 88";
                int hasProving = 0;
                using (SqlConnection connProving = new SqlConnection(SqlStatements.ConnectionString))
                {
                    connProving.Open();

                    using (SqlCommand cmdProving = new SqlCommand(sql, connProving))
                    {
                        var getAddition = cmdProving.ExecuteScalar();
                        if (getAddition != null)
                            hasProving = -1;
                    }
                    connProving.Close();
                }

                if (_sectionName == "SL_Buff" && hasProving == -1)
                {
                    checkIFSRAddon();

                    cmd.Parameters.AddWithValue("@amountToDeduct", updateAmount);
                    cmd.Parameters.AddWithValue("@doorID", _doorId);
                    cmd.Parameters.AddWithValue("@dateComp", DateTime.Now);
                    cmd.Parameters.AddWithValue("@opComp", SqlStatements.proving);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@amountToDeduct", updateAmount);
                    cmd.Parameters.AddWithValue("@doorID", _doorId);
                    cmd.Parameters.AddWithValue("@dateComp", DateTime.Now);
                    cmd.Parameters.AddWithValue("@opComp", -1);
                    cmd.ExecuteNonQuery();
                }


                cleanUpTimeRemain();
            }
            else
            {
                cmd.Parameters.AddWithValue("@amountToDeduct", updateAmount);
                cmd.Parameters.AddWithValue("@doorID", _doorId);
                cmd.Parameters.AddWithValue("@dateComp", DBNull.Value);
                cmd.Parameters.AddWithValue("@opComp", 0);
                cmd.ExecuteNonQuery();
            }









        }

        private void checkIFSRAddon()
        {
            SqlConnection conn2 = new SqlConnection(SqlStatements.ConnectionString);
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("usp_notify_sr_addons_complete", conn2);
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;


            cmd2.Parameters.AddWithValue("@doorID", SqlDbType.Int).Value = _doorId;

            cmd2.ExecuteNonQuery();


        }

        private void cleanUpTimeRemain()
        {
            SqlConnection connClean = new SqlConnection(SqlStatements.ConnectionString);
            connClean.Open();
            int proving = 0;
            string sql = "SELECT id FROM dbo.door_part_completion_log WHERE op = 'SL Proving' and door_id = " + _doorId;
            using (SqlCommand cmd = new SqlCommand(sql, connClean))
            {
                var fuga = cmd.ExecuteScalar();

                if (fuga == null)
                    proving = 0;
                else
                    proving = Convert.ToInt32(fuga);
            }

            SqlCommand cmdClean = new SqlCommand();
            cmdClean.Connection = connClean;

            switch (_sectionName)
            {
                case "SL_Stores":
                    cmdClean.CommandText = "UPDATE dbo.door set  time_reamining_sl_stores = 0 WHERE id = @doorID";
                    break;
                case "Cutting":
                    cmdClean.CommandText = "UPDATE dbo.door set time_remaining_cutting = 0 WHERE id = @doorID";
                    break;
                case "Prepping":
                    cmdClean.CommandText = "UPDATE dbo.door set time_remaining_prepping = 0 WHERE id = @doorID";
                    break;
                case "Assembly":
                    cmdClean.CommandText = "UPDATE dbo.door set  time_remianing_assembly = 0 WHERE id = @doorID";
                    break;
                case "SL_Buff":
                    cmdClean.CommandText = "UPDATE dbo.door set time_remaining_sl_buff = 0 WHERE id = @doorID";
                    break;
                case "SL_Pack":
                    cmdClean.CommandText = "UPDATE dbo.door set time_remaining_pack = 0 WHERE id = @doorID";
                    break;
                default:

                    break;
            }


            cmdClean.Parameters.AddWithValue("@doorID", _doorId);

            if (proving == 0 && _sectionName == "SL_Buff")
            { }
            else
                cmdClean.ExecuteNonQuery();

            connClean.Close();


        }



        public void calibrate()
        {
            var UpdateDate = DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000");
            double totalTime = 0;


            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from c_view_total_slimline_daily_output where output_date = @outputDate;";
            cmd.Parameters.AddWithValue("@outputDate", UpdateDate);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows == true)
            {
                while (rdr.Read())
                {
                    totalTime = Convert.ToDouble(rdr["TotalTime"]);
                }
            }
            else
            {
                totalTime = 0;
            }

            rdr.Close();
            //USE TOTAL TIME TO UPDATE DAILY GOALS


            SqlCommand sqlwrt = new SqlCommand();
            sqlwrt.Connection = conn;
            sqlwrt.CommandText = "UPDATE dbo.daily_department_goal SET actual_hours_slimline =@actualHours WHERE date_goal=@dateGoal;";
            sqlwrt.Parameters.AddWithValue("@actualHours", totalTime);
            sqlwrt.Parameters.AddWithValue("@dateGoal", UpdateDate);

            sqlwrt.ExecuteNonQuery();

            conn.Close();


        }




    }
}

