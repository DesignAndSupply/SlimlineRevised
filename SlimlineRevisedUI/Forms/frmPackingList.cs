using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimlineRevisedUI.Forms
{
    public partial class frmPackingList : Form
    {
        public frmPackingList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//close
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //open
        {

            if (txtDoorID.Text.Length > 0)
            {
                string temp = @"\\designsvr1\apps\Design and Supply MS ACCESS\Frontend\ShopFloorUpdate\SlimlineDelivery\Packing Lists\" + txtDoorID.Text + ".pdf";

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                process.StartInfo = startInfo;

                startInfo.FileName = temp;
                try
                {
                    process.Start();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("This door does not have a packing list, please check with management.", "404", MessageBoxButtons.OK);
                }
            }


        }
    }
}
