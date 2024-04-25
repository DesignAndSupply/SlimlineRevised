using SlimlineRevisedUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimlineRevisedUI.Forms
{
    public partial class frmProvingSelection : Form
    {
        public frmProvingSelection()
        {
            InitializeComponent();
        }

        private void btnProving_Click(object sender, EventArgs e)
        {
            SqlStatements.proving = -1;
            this.Close();
        }

        private void btnBuffing_Click(object sender, EventArgs e)
        {
            SqlStatements.proving = 0;
            this.Close();
        }
    }
}
