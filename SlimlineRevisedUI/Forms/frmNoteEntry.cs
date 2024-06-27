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
using repaintWord = Microsoft.Office.Interop.Word;

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
            {
                department = "packing";
                //make repaints checkbox visible
                chkRepaint.Visible = true;
            }

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
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Note Updated!", "Complete", MessageBoxButtons.OK);


                        ////if this is a remake then log it then open a form to log it the same way traditional does
                        //if (chkRepaint.Checked == true)
                        //{
                        //    frmRepaint frm = new frmRepaint(_id);
                        //    frm.ShowDialog();
                        //}
                    }

                    if (chkRepaint.Checked == true)
                    {
                        //print out the repaint sheet
                        sql = "select rtrim(s.NAME),dt.door_type_description FROM dbo.door d " +
                            "left join dbo.door_type dt on d.door_type_id = dt.id " +
                            "left join dbo.SALES_LEDGER s on d.customer_acc_ref = s.ACCOUNT_REF " +
                            "where d.id = " + _id.ToString();
                        DataTable dt = new DataTable();

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }



                        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                        repaintWord.Document wordDoc = wordApp.Documents.Open(@"\\designsvr1\apps\Design and Supply CSharp\REPAINT_REQUEST_FORM.docx");

                        repaintWord.Bookmark bmDoorNumber = wordDoc.Bookmarks["Door_Number"];
                        repaintWord.Range range = bmDoorNumber.Range;
                        range.Text = _id.ToString();

                        repaintWord.Bookmark bmCustomer = wordDoc.Bookmarks["Customer"];
                        range = bmCustomer.Range;
                        range.Text = dt.Rows[0][0].ToString();

                        repaintWord.Bookmark bmDoorType = wordDoc.Bookmarks["Door_Type"];
                        range = bmDoorType.Range;
                        range.Text = dt.Rows[0][1].ToString();


                        wordApp.Options.PrintBackground = false; // this forces the app to print before closing

                        wordDoc.PrintOut();

                        //release word objects
                        wordDoc.Close(false);
                        wordApp.Quit(false);

                        releaseObject(wordDoc);
                        releaseObject(wordApp);

                    }


                    conn.Close();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Please enter a note before saving!", "No text!", MessageBoxButtons.OK);
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Error releasing object: " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
