namespace SlimlineRevisedUI.Forms
{
    partial class frmAllocateWork
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
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.user_infoDataSet = new SlimlineRevisedUI.user_infoDataSet();
            this.cviewslimlinestaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_slimline_staffTableAdapter = new SlimlineRevisedUI.user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStaff
            // 
            this.cmbStaff.DataSource = this.cviewslimlinestaffBindingSource;
            this.cmbStaff.DisplayMember = "Fullname";
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(12, 89);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(178, 21);
            this.cmbStaff.TabIndex = 0;
            this.cmbStaff.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Staff:";
            // 
            // txtDoorID
            // 
            this.txtDoorID.Location = new System.Drawing.Point(12, 37);
            this.txtDoorID.Name = "txtDoorID";
            this.txtDoorID.Size = new System.Drawing.Size(100, 20);
            this.txtDoorID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Door No:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Cutting",
            "Prepping",
            "Assembly",
            "SL Buff",
            "Packing"});
            this.cmbDepartment.Location = new System.Drawing.Point(12, 147);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(178, 21);
            this.cmbDepartment.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Department:";
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(15, 198);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(75, 23);
            this.btnAllocate.TabIndex = 6;
            this.btnAllocate.Text = "Allocate";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.BtnAllocate_Click);
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cviewslimlinestaffBindingSource
            // 
            this.cviewslimlinestaffBindingSource.DataMember = "c_view_slimline_staff";
            this.cviewslimlinestaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // c_view_slimline_staffTableAdapter
            // 
            this.c_view_slimline_staffTableAdapter.ClearBeforeFill = true;
            // 
            // frmAllocateWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 255);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDoorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStaff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllocateWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allocate Work";
            this.Load += new System.EventHandler(this.FrmAllocateWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllocate;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewslimlinestaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter c_view_slimline_staffTableAdapter;
    }
}