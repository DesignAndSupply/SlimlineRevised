namespace SlimlineRevisedUI.Forms
{
    partial class frmWorkAllocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblOperator = new System.Windows.Forms.Label();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.cviewslimlinestaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new SlimlineRevisedUI.user_infoDataSet();
            this.c_view_slimline_staffTableAdapter = new SlimlineRevisedUI.user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter();
            this.dgvAllocation = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(12, 112);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(82, 13);
            this.lblOperator.TabIndex = 8;
            this.lblOperator.Text = "Operator Name:";
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cviewslimlinestaffBindingSource, "Fullname", true));
            this.cmbStaffID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cviewslimlinestaffBindingSource, "id", true));
            this.cmbStaffID.DataSource = this.cviewslimlinestaffBindingSource;
            this.cmbStaffID.DisplayMember = "Fullname";
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(100, 109);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(166, 21);
            this.cmbStaffID.TabIndex = 7;
            this.cmbStaffID.ValueMember = "id";
            // 
            // cviewslimlinestaffBindingSource
            // 
            this.cviewslimlinestaffBindingSource.DataMember = "c_view_slimline_staff";
            this.cviewslimlinestaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // c_view_slimline_staffTableAdapter
            // 
            this.c_view_slimline_staffTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAllocation
            // 
            this.dgvAllocation.AllowUserToAddRows = false;
            this.dgvAllocation.AllowUserToDeleteRows = false;
            this.dgvAllocation.AllowUserToOrderColumns = true;
            this.dgvAllocation.AllowUserToResizeColumns = false;
            this.dgvAllocation.AllowUserToResizeRows = false;
            this.dgvAllocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocation.Location = new System.Drawing.Point(15, 136);
            this.dgvAllocation.Name = "dgvAllocation";
            this.dgvAllocation.RowHeadersVisible = false;
            this.dgvAllocation.Size = new System.Drawing.Size(773, 302);
            this.dgvAllocation.TabIndex = 9;
            this.dgvAllocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllocation_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(272, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "View";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "\\\\designsvr1\\apps\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(15, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "STILL UNDER DEVELOPMENT ALLOCATION WORKS BUT THE TAKEN AND LABEL BUTTONS DONT";
            // 
            // frmWorkAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvAllocation);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.cmbStaffID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorkAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Allocation";
            this.Load += new System.EventHandler(this.frmWorkAllocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewslimlinestaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter c_view_slimline_staffTableAdapter;
        private System.Windows.Forms.DataGridView dgvAllocation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}