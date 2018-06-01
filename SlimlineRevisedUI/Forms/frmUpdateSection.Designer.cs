namespace SlimlineRevisedUI.Forms
{
    partial class frmUpdateSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateSection));
            this.lblDoorID = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.cviewslimlinestaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new SlimlineRevisedUI.user_infoDataSet();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_view_slimline_staffTableAdapter = new SlimlineRevisedUI.user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnSaveNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoorID
            // 
            this.lblDoorID.AutoSize = true;
            this.lblDoorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoorID.Location = new System.Drawing.Point(13, 13);
            this.lblDoorID.Name = "lblDoorID";
            this.lblDoorID.Size = new System.Drawing.Size(60, 24);
            this.lblDoorID.TabIndex = 0;
            this.lblDoorID.Text = "label1";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(14, 37);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(46, 17);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department History";
            // 
            // dgvProgress
            // 
            this.dgvProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgress.Location = new System.Drawing.Point(17, 105);
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.RowHeadersVisible = false;
            this.dgvProgress.Size = new System.Drawing.Size(715, 311);
            this.dgvProgress.TabIndex = 3;
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cviewslimlinestaffBindingSource, "Fullname", true));
            this.cmbStaffID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cviewslimlinestaffBindingSource, "id", true));
            this.cmbStaffID.DataSource = this.cviewslimlinestaffBindingSource;
            this.cmbStaffID.DisplayMember = "Fullname";
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(564, 16);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(166, 21);
            this.cmbStaffID.TabIndex = 4;
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
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(668, 43);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(62, 20);
            this.txtPercentage.TabIndex = 5;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(476, 19);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(82, 13);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Operator Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Percentage Complete";
            // 
            // c_view_slimline_staffTableAdapter
            // 
            this.c_view_slimline_staffTableAdapter.ClearBeforeFill = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(668, 69);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(62, 23);
            this.btnComplete.TabIndex = 8;
            this.btnComplete.Text = "Update";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtNote
            // 
            this.txtNote.ForeColor = System.Drawing.Color.Red;
            this.txtNote.Location = new System.Drawing.Point(17, 450);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(713, 47);
            this.txtNote.TabIndex = 9;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(17, 431);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(35, 13);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "label3";
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(655, 503);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNote.TabIndex = 11;
            this.btnSaveNote.Text = "Save Note";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // frmUpdateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 531);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.dgvProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblDoorID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateSection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Section";
            this.Load += new System.EventHandler(this.frmUpdateSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoorID;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProgress;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label2;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewslimlinestaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter c_view_slimline_staffTableAdapter;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnSaveNote;
    }
}