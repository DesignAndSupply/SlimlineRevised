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
    public partial class frmPrintLabelFromPO : Form
    {
        public frmPrintLabelFromPO()
        {
            InitializeComponent();
            dgvStock.CellClick += dgvStock_CellClick;
            fillGrid();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fillGrid();
        }


        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select id as ItemID ,stock_code, description , quantity, additional_info FROM dbo.po_item WHERE po_id = @POID; ";
            cmd.Parameters.AddWithValue("@POID", txtPO.Text);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            try
            {

                DataTable dt = new DataTable();
                adap.Fill(dt);
                dgvStock.DataSource = dt;

                DataGridViewButtonColumn selectButton = new DataGridViewButtonColumn();
                selectButton.Text = "Print Label";
                selectButton.Name = "Print Label";
                selectButton.UseColumnTextForButtonValue = true;
                int columnIndex = 4;

                if (dgvStock.Columns["Print Label"] == null)
                {
                    dgvStock.Columns.Insert(columnIndex, selectButton);
                }


            }
            catch (Exception)
            {
               
            }



        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sc = "0";
            string ai = "";
            int ii = 0;

            if (dgvStock.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvStock.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvStock.Rows[selectedrowindex];

                sc = selectedRow.Cells["stock_code"].Value.ToString();
                ai = selectedRow.Cells["additional_info"].Value.ToString();
                ii = Convert.ToInt32(selectedRow.Cells["ItemId"].Value);
            }


            if (e.ColumnIndex == dgvStock.Columns["Print Label"].Index)
            {
                Classes.Label lb = new Classes.Label(sc,ii);

                double n;
                bool isNumeric = double.TryParse(ai, out n);

                if (isNumeric)
                {
                    lb.printSmallStockLabelDoor(ai);
                }
                else

                
                {
                    if (ai == "STOCK" || ai =="Stk" || ai =="Stock" || ai=="STK")
                    {
                        lb.printSmallStockLabel();
                    }
                    else
                    {
                        lb.printSmallStockLabelDoor(ai);
                    }


                   
                }
                
                
            }
        }

        private void frmPrintLabelFromPO_Load(object sender, EventArgs e)
        {

        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
