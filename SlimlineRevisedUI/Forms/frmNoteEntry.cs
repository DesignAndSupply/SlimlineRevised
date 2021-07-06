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
    public partial class frmNoteEntry : Form
    {
        public string _department { get; set; }
        public int _id { get; set; }
        public string _fullName { get; set; }
        public frmNoteEntry(string department, int id, int staff_id)
        {
            InitializeComponent();
            if (department == "SL_Pack")
                department = "packing";
            _department = department;
            _id = id;
            //cmd.CommandText = "UPDATE dbo.door SET sl_stores_note = @note where id = @id ";
            //cmd.CommandText = "UPDATE dbo.door SET cutting_note = @note where id = @id ";
            //cmd.CommandText = "UPDATE dbo.door SET prepping_note = @note where id = @id ";
            //cmd.CommandText = "UPDATE dbo.door SET assembly_note = @note where id = @id ";
            //cmd.CommandText = "UPDATE dbo.door SET sl_buff_note = @note where id = @id ";
            //cmd.CommandText = "UPDATE dbo.door SET packing_note = @note where id = @id ";
            string sql = "select  " + department + "_note FROM dbo.door WHERE id = " + id.ToString();
            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    string temp = "";
                    var getData = cmd.ExecuteScalar();
                    if (getData != null)
                        temp = getData.ToString();
                    else
                        temp = "";
                    txtNote.Text = getData.ToString();
                }
                sql = "SELECT forename + ' ' + surname from [user_info].dbo.[user] where id = " + staff_id.ToString();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                    _fullName = Convert.ToString(cmd.ExecuteScalar());

                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewNote.Text.Length > 0)
            {
                string temp = "";
                temp = txtNote.Text + " || " + txtNewNote.Text + " - " + _fullName + " - " + DateTime.Now;
                temp = temp.Replace("'", "");
                txtNote.Text = temp;
                string sql = "UPDATE dbo.door SET " + _department + "_note = '" + txtNote.Text + "' where id = " + _id;
                using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Note Updated!", "Complete", MessageBoxButtons.OK);
                        conn.Close();
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Please enter a note before saving!", "No text!", MessageBoxButtons.OK);
        }
    }
}
