using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SlimlineRevisedUI.Classes
{
    class Door
    {

        public double _doorID { get; set; }
        public string _customerName { get; set; }
        public string _doorType {get; set;}
        public string _orderNumber { get; set; }
        public string _ref { get; set; }
        public DateTime _packDate { get; set; }





        public Door(double doorID)
        {
            _doorID = doorID;

            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * from dbo.c_view_slimline_packing_labels WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", _doorID);


            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                _customerName = rdr["NAME"].ToString();
                _doorType = rdr["door_type_description"].ToString();
                _orderNumber = rdr["order_number"].ToString();
                _ref = rdr["order_ref"] + " / " + rdr["door_ref"];
                _packDate = Convert.ToDateTime(rdr["date_pack"]);
            }

            rdr.Close();
            conn.Close();
        }



    }
}
