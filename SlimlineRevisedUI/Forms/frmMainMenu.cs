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
    public partial class frmMainMenu : Form
    {

        private double doorID;
        private string operation;




        public frmMainMenu()
        {
            InitializeComponent();
            dgvSections.CellClick += dgvSections_CellClick;

        }

        private void btnLoadDoor_Click(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = Double.TryParse(txtDoorIDSearch.Text, out n);
            if (isNumeric == true)
            {
                fillGrid();
            }
            else
            {
                MessageBox.Show("Please enter a numerical value before searching", "Data type incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand sqlSectionList = new SqlCommand();
            sqlSectionList.Connection = con;
            sqlSectionList.CommandText = "Select [Door ID:],Section,[Planned Operation Date], [Date Operation Complete] From c_view_slimline_Sections WHERE [Door ID:]=@doorID order by op_order";
            sqlSectionList.Parameters.AddWithValue("@doorID", txtDoorIDSearch.Text);
            SqlDataAdapter sqlPaintAdap = new SqlDataAdapter(sqlSectionList);



            try
            {

                DataTable dtSection = new DataTable();
                sqlPaintAdap.Fill(dtSection);
                dgvSections.DataSource = dtSection;

                DataGridViewButtonColumn selectButton = new DataGridViewButtonColumn();
                selectButton.Text = "Update Department";
                selectButton.Name = "Update Department";
                selectButton.UseColumnTextForButtonValue = true;
                int columnIndex = 4;

                if (dgvSections.Columns["Update Department"] == null)
                {
                    dgvSections.Columns.Insert(columnIndex, selectButton);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Please ensure you enter a valid door number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void dgvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSections.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvSections.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvSections.Rows[selectedrowindex];

                doorID = Convert.ToInt32(selectedRow.Cells["Door ID:"].Value);
                operation = selectedRow.Cells["Section"].Value.ToString();

            }



            if (e.ColumnIndex == dgvSections.Columns["Update Department"].Index)
            {
                frmUpdateSection frmUS = new frmUpdateSection(doorID,operation);
                frmUS.ShowDialog();
                fillGrid();
            }





        }

        private void btnLooseItems_Click(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = Double.TryParse(txtDoorIDSearch.Text, out n);
            if (isNumeric == true)
            {
                frmLooseItems frmLI = new frmLooseItems(Convert.ToDouble(txtDoorIDSearch.Text));
                frmLI.Show();
            }
            else
            {
                MessageBox.Show("Please enter a numerical value before searching", "Data type incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                

        }

        private void viewAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorkAllocation frmWA = new frmWorkAllocation();
            frmWA.ShowDialog();
        }

        private void dgvSections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printLabelFromStockCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLabelFromSC frml = new frmLabelFromSC();
            frml.ShowDialog();
        }

        private void printLabelFromPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintLabelFromPO frml = new frmPrintLabelFromPO();
            frml.ShowDialog();
        }
    }
}
