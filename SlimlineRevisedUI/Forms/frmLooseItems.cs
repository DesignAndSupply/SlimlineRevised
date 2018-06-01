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
    public partial class frmLooseItems : Form
    {

        public double _doorID { get; set; }

        public frmLooseItems(double doorID)
        {
            InitializeComponent();
            _doorID = doorID;
            lblDoorID.Text = "Displaying information for Door ID: " + _doorID;
        }

        private void frmLooseItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'order_databaseDataSet.loose_items' table. You can move, or remove it, as needed.
            this.loose_itemsTableAdapter.Fill(this.order_databaseDataSet.loose_items);

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(cmbBoxes.Text) || string.IsNullOrWhiteSpace(cmbKeysInFrame.Text) || string.IsNullOrWhiteSpace(cmbPallet.Text))
            {
                MessageBox.Show("Please ensure all combo boxes are filled before proceeding!", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int keysInFrame;
                int weldedFrame = -1;
                int boxCount = Convert.ToInt32(cmbBoxes.Text);
                int onPallet;

                //UPDATES TRANSPORT INFORMATION

                if (cmbKeysInFrame.Text == "Yes")
                {
                    keysInFrame = -1;
                }
                else
                {
                    keysInFrame = 0;
                }

                if (cmbPallet.Text == "Yes")
                {
                    onPallet = -1;
                }
                else
                {
                    onPallet = 0;
                }

                SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE dbo.door_transport SET keys_in_frame =@kif ,welded_frame =@wf, boxes = @boxes, on_pallet = @onPallet WHERE door_id = @doorID", conn);
                cmd.Parameters.AddWithValue("@kif", keysInFrame);
                cmd.Parameters.AddWithValue("@wf", weldedFrame);
                cmd.Parameters.AddWithValue("@boxes", boxCount);
                cmd.Parameters.AddWithValue("@onPallet", onPallet);
                cmd.Parameters.AddWithValue("@doorID", _doorID);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                ///////


                //UPDATES THE NOTES

                SqlCommand cmd2 = new SqlCommand("UPDATE dbo.door set packing_note_loose_items = @note where id=@doorID", conn);
                cmd2.Parameters.AddWithValue("@note", txtNote.Text);
                cmd2.Parameters.AddWithValue("@doorID", _doorID);

                cmd2.ExecuteNonQuery();


                /////// DELETES ALL EXISTING LOOSE ITEMS BEFORE ADDING NEW ONES
                SqlCommand cmd3 = new SqlCommand("DELETE FROM dbo.loose_item_to_door where door_id=@doorID;", conn);
                cmd3.Parameters.AddWithValue("@doorId", _doorID);

                cmd3.ExecuteNonQuery();

                //ADDS NEW LOOSE ITEMS

                SqlCommand cmd4 = new SqlCommand("INSERT INTO dbo.loose_item_to_door (door_id,loose_item_id,quantity,note,[date]) VALUES (@doorID,@itemID,@qty,@note,@date); ", conn);

               


                foreach (DataGridViewRow row in dgvLooseItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cmd4.Parameters.Clear();
                        cmd4.Parameters.AddWithValue("@doorID", _doorID);
                        cmd4.Parameters.AddWithValue("@itemID", row.Cells[0].Value);
                        cmd4.Parameters.AddWithValue("@qty", row.Cells[2].Value);
                        cmd4.Parameters.AddWithValue("@note", row.Cells[3].Value);
                        cmd4.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd4.ExecuteNonQuery();
                        
                    }
                   
                }



                this.Close();


            }

        }

       

        private void lstSelection_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.dgvLooseItems.Rows.Add(lstSelection.SelectedValue, (lstSelection.SelectedItem as DataRowView)["Description"].ToString(), 1, "");
        }

        private void lstSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
