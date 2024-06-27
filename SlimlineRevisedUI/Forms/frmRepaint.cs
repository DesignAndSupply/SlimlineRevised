using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimlineRevisedUI.Classes;
using repaintWord = Microsoft.Office.Interop.Word;

namespace SlimlineRevisedUI.Forms
{
    public partial class frmRepaint : Form
    {

        public string department { get; set; }
        public int department_id { get; set; }
        public int door_id { get; set; }
        public frmRepaint(int door_id)
        {
            InitializeComponent();
            this.door_id = door_id;
            department = "Cutting";
            department_id = 22;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnLogRepaint_Click(object sender, EventArgs e)
        {

            if (txtReason.Text.Length < 5)
            {
                MessageBox.Show("Please enter a reason for repaint.", "Missing Reason", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "";
            int staff_id = 24;
            //get the staff allocation 
            sql = "select staff_id FROM dbo.door_allocation da where department = '" + department + "' and door_id = " + door_id.ToString();

            using (SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString))
            {
                conn.Open();
                if (department == "Office")
                {
                    //apparently it can only be sarah
                    staff_id = 24;
                }
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        var getStaff = cmd.ExecuteScalar();
                        if (getStaff != null)
                            staff_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    }
                }

                //paint id
                int paint_id = 0;
                sql = "select max(paint_id) FROM dbo.paint_to_door where door_id = " + door_id.ToString();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    var getPaintID = cmd.ExecuteScalar();
                    if (getPaintID != null)
                        paint_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }

                //MessageBox.Show(paint_id.ToString());

                //log the repaint
                sql = "INSERT INTO dbo.repaints (date_logged,paint_id,amended,painter_name,department,door_id,reason_for_repaint,deduction_successful," +
                    "repaint_complete,repaint_from_dept) " +
                    "VALUES (GETDATE()," + paint_id + ",0," + staff_id + "," + department_id + "," + door_id.ToString() + ",'" + txtReason.Text + "',0,0,'Packing')";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                //print out the repaint sheet
                sql = "select rtrim(s.NAME),dt.door_type_description FROM dbo.door d " +
                    "left join dbo.door_type dt on d.door_type_id = dt.id " +
                    "left join dbo.SALES_LEDGER s on d.customer_acc_ref = s.ACCOUNT_REF " +
                    "where d.id = " + door_id.ToString();
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
                range.Text = door_id.ToString();

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


                conn.Close();
            }
            this.Close();

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

        private void rdoCutting_CheckedChanged(object sender, EventArgs e)
        {
            department = "Cutting";
            department_id = 22;
        }

        private void rdoPrepping_CheckedChanged(object sender, EventArgs e)
        {
            department = "Prepping";
            department_id = 23;
        }

        private void rdoAssembly_CheckedChanged(object sender, EventArgs e)
        {
            department = "Assembly";
            department_id = 24;
        }

        private void rdoBuffing_CheckedChanged(object sender, EventArgs e)
        {
            department = "SL Buff";
            department_id = 25;
        }

        private void rdoPainting_CheckedChanged(object sender, EventArgs e)
        {
            department = "Painting";
            department_id = 4;
        }

        private void rdoPacking_CheckedChanged(object sender, EventArgs e)
        {
            department = "Packing";
            department_id = 6;
        }

        private void rdoOffice_CheckedChanged(object sender, EventArgs e)
        {
            department = "Office";
            department_id = 8;
        }
    }
}
