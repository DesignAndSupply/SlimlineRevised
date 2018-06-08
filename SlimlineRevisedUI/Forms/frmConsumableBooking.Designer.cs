namespace SlimlineRevisedUI.Forms
{
    partial class frmConsumableBooking
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
            this.lstStock = new System.Windows.Forms.ListBox();
            this.orderdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new SlimlineRevisedUI.order_databaseDataSet();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.user_infoDataSet = new SlimlineRevisedUI.user_infoDataSet();
            this.cviewslimlinestaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_slimline_staffTableAdapter = new SlimlineRevisedUI.user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter();
            this.cviewslimlinestaffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.StockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStock
            // 
            this.lstStock.DataSource = this.orderdatabaseDataSetBindingSource;
            this.lstStock.FormattingEnabled = true;
            this.lstStock.Location = new System.Drawing.Point(13, 57);
            this.lstStock.Name = "lstStock";
            this.lstStock.Size = new System.Drawing.Size(310, 446);
            this.lstStock.TabIndex = 0;
            this.lstStock.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstStock_MouseDoubleClick);
            // 
            // orderdatabaseDataSetBindingSource
            // 
            this.orderdatabaseDataSetBindingSource.DataSource = this.order_databaseDataSet;
            this.orderdatabaseDataSetBindingSource.Position = 0;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 31);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(311, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter List:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCode,
            this.Description,
            this.Quantity});
            this.dgvItems.Location = new System.Drawing.Point(339, 57);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(580, 444);
            this.dgvItems.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Allocate To:";
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
            // cviewslimlinestaffBindingSource1
            // 
            this.cviewslimlinestaffBindingSource1.DataMember = "c_view_slimline_staff";
            this.cviewslimlinestaffBindingSource1.DataSource = this.user_infoDataSet;
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cviewslimlinestaffBindingSource, "Fullname", true));
            this.cmbStaffID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cviewslimlinestaffBindingSource, "id", true));
            this.cmbStaffID.DataSource = this.cviewslimlinestaffBindingSource;
            this.cmbStaffID.DisplayMember = "Fullname";
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(741, 30);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(178, 21);
            this.cmbStaffID.TabIndex = 7;
            this.cmbStaffID.ValueMember = "id";
            // 
            // StockCode
            // 
            this.StockCode.HeaderText = "StockCode";
            this.StockCode.Name = "StockCode";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(844, 507);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmConsumableBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 547);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lstStock);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsumableBooking";
            this.Text = "Consumable Booking";
            this.Load += new System.EventHandler(this.frmConsumableBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewslimlinestaffBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource orderdatabaseDataSetBindingSource;
        private order_databaseDataSet order_databaseDataSet;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewslimlinestaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_slimline_staffTableAdapter c_view_slimline_staffTableAdapter;
        private System.Windows.Forms.BindingSource cviewslimlinestaffBindingSource1;
        private System.Windows.Forms.ComboBox cmbStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnSubmit;
    }
}