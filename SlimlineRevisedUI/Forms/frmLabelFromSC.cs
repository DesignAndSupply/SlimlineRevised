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

namespace SlimlineRevisedUI
{
    public partial class frmLabelFromSC : Form
    {
        public frmLabelFromSC()
        {
            InitializeComponent();
            dgvStock.CellClick += dgvStock_CellClick;
            fillGrid();
        }

        private void frmLabelFromSC_Load(object sender, EventArgs e)
        {

        }


        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select stock_code, description, amount_in_stock from dbo.stock where slimline_stock_yn = -1 and description like @desc order by stock_code";
            cmd.Parameters.AddWithValue("@desc","%" +  txtDescription.Text + "%");
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
                int columnIndex = 3;

                if (dgvStock.Columns["Print Label"] == null)
                {
                    dgvStock.Columns.Insert(columnIndex, selectButton);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Please ensure you enter a valid description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sc="0";
            int ii = 0;
            if (dgvStock.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvStock.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvStock.Rows[selectedrowindex];

                sc = selectedRow.Cells["stock_code"].Value.ToString();
                

            }


            if (e.ColumnIndex == dgvStock.Columns["Print Label"].Index)
            {
                Classes.Label lb = new Classes.Label(sc,ii);
                lb.printSmallStockLabel();
            }
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
