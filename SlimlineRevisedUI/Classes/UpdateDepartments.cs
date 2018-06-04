using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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

                double returnValue=0;



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
                                returnValue= Convert.ToDouble(rdr["time_sl_stores"]) * Convert.ToInt32(rdr["quantity_same"]);
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
                                returnValue = Convert.ToDouble(rdr["time_sl_buff"]) * Convert.ToInt32(rdr["quantity_same"]);
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
                                returnValue = Convert.ToDouble(rdr["time_sl_buff"]);
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
                    returnValue= 0;
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
                case "Cutting":;
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

        public void updateDoor(double updateAmount , double updatePercentage)
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;


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
                    cmd.CommandText = "UPDATE dbo.door set complete_SL_buff = @opComp, date_SL_buff_complete = @dateComp, time_remaining_sl_buff = time_remaining_sl_buff - @amountToDeduct WHERE id = @doorID";
                    break;
                case "SL_Pack":
                    cmd.CommandText = "UPDATE dbo.door set complete_pack =@opComp, date_pack_complete = @dateComp, time_remaining_pack = time_remaining_pack - @amountToDeduct WHERE id = @doorID";
                    break;
                default:
                    
                    break;
            }



            if (updatePercentage == 100)
            {
                cmd.Parameters.AddWithValue("@amountToDeduct", updateAmount);
                cmd.Parameters.AddWithValue("@doorID", _doorId);
                cmd.Parameters.AddWithValue("@dateComp", DateTime.Now);
                cmd.Parameters.AddWithValue("@opComp", -1);
                cmd.ExecuteNonQuery();
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

        private void cleanUpTimeRemain()
        {
            SqlConnection connClean = new SqlConnection(SqlStatements.ConnectionString);
            connClean.Open();

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

            cmdClean.ExecuteNonQuery();

            connClean.Close();


        }



        public void calibrate()
        {
            var UpdateDate = DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000");
            double totalTime =0;


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

