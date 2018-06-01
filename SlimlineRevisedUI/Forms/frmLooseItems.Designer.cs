namespace SlimlineRevisedUI.Forms
{
    partial class frmLooseItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLooseItems));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbGlassLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPallet = new System.Windows.Forms.ComboBox();
            this.cmbKeysInFrame = new System.Windows.Forms.ComboBox();
            this.cmbBoxes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstSelection = new System.Windows.Forms.ListBox();
            this.looseitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new SlimlineRevisedUI.order_databaseDataSet();
            this.dgvLooseItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDoorID = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.loose_itemsTableAdapter = new SlimlineRevisedUI.order_databaseDataSetTableAdapters.loose_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.looseitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLooseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "\\\\designsvr1\\apps\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(14, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbGlassLocation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPallet);
            this.groupBox1.Controls.Add(this.cmbKeysInFrame);
            this.groupBox1.Controls.Add(this.cmbBoxes);
            this.groupBox1.Location = new System.Drawing.Point(15, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Information";
            // 
            // cmbGlassLocation
            // 
            this.cmbGlassLocation.FormattingEnabled = true;
            this.cmbGlassLocation.Items.AddRange(new object[] {
            "",
            "None",
            "Loose",
            "In Door"});
            this.cmbGlassLocation.Location = new System.Drawing.Point(90, 100);
            this.cmbGlassLocation.Name = "cmbGlassLocation";
            this.cmbGlassLocation.Size = new System.Drawing.Size(118, 21);
            this.cmbGlassLocation.TabIndex = 7;
            this.cmbGlassLocation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Glass Location:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "On Pallet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Keys in frame";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boxes";
            // 
            // cmbPallet
            // 
            this.cmbPallet.FormattingEnabled = true;
            this.cmbPallet.Items.AddRange(new object[] {
            "",
            "Yes ",
            "No"});
            this.cmbPallet.Location = new System.Drawing.Point(90, 73);
            this.cmbPallet.Name = "cmbPallet";
            this.cmbPallet.Size = new System.Drawing.Size(118, 21);
            this.cmbPallet.TabIndex = 2;
            // 
            // cmbKeysInFrame
            // 
            this.cmbKeysInFrame.FormattingEnabled = true;
            this.cmbKeysInFrame.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.cmbKeysInFrame.Location = new System.Drawing.Point(90, 46);
            this.cmbKeysInFrame.Name = "cmbKeysInFrame";
            this.cmbKeysInFrame.Size = new System.Drawing.Size(118, 21);
            this.cmbKeysInFrame.TabIndex = 1;
            // 
            // cmbBoxes
            // 
            this.cmbBoxes.FormattingEnabled = true;
            this.cmbBoxes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBoxes.Location = new System.Drawing.Point(90, 19);
            this.cmbBoxes.Name = "cmbBoxes";
            this.cmbBoxes.Size = new System.Drawing.Size(118, 21);
            this.cmbBoxes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Location = new System.Drawing.Point(244, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loose Item Notes";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(7, 20);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(587, 104);
            this.txtNote.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstSelection);
            this.groupBox3.Controls.Add(this.dgvLooseItems);
            this.groupBox3.Location = new System.Drawing.Point(18, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 289);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loose Items";
            // 
            // lstSelection
            // 
            this.lstSelection.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.looseitemsBindingSource, "id", true));
            this.lstSelection.DataSource = this.looseitemsBindingSource;
            this.lstSelection.DisplayMember = "description";
            this.lstSelection.FormattingEnabled = true;
            this.lstSelection.Location = new System.Drawing.Point(6, 20);
            this.lstSelection.Name = "lstSelection";
            this.lstSelection.Size = new System.Drawing.Size(188, 251);
            this.lstSelection.TabIndex = 2;
            this.lstSelection.ValueMember = "id";
            this.lstSelection.SelectedIndexChanged += new System.EventHandler(this.lstSelection_SelectedIndexChanged);
            this.lstSelection.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSelection_MouseDoubleClick);
            // 
            // looseitemsBindingSource
            // 
            this.looseitemsBindingSource.DataMember = "loose_items";
            this.looseitemsBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvLooseItems
            // 
            this.dgvLooseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLooseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Description,
            this.Quantity,
            this.Note});
            this.dgvLooseItems.Location = new System.Drawing.Point(233, 20);
            this.dgvLooseItems.Name = "dgvLooseItems";
            this.dgvLooseItems.Size = new System.Drawing.Size(586, 251);
            this.dgvLooseItems.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
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
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // lblDoorID
            // 
            this.lblDoorID.AutoSize = true;
            this.lblDoorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoorID.Location = new System.Drawing.Point(492, 9);
            this.lblDoorID.Name = "lblDoorID";
            this.lblDoorID.Size = new System.Drawing.Size(288, 24);
            this.lblDoorID.TabIndex = 9;
            this.lblDoorID.Text = "Displaying information for door id:";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(752, 544);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(86, 29);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // loose_itemsTableAdapter
            // 
            this.loose_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // frmLooseItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 587);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblDoorID);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLooseItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loose Items";
            this.Load += new System.EventHandler(this.frmLooseItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.looseitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLooseItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPallet;
        private System.Windows.Forms.ComboBox cmbKeysInFrame;
        private System.Windows.Forms.ComboBox cmbBoxes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDoorID;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGlassLocation;
        private System.Windows.Forms.DataGridView dgvLooseItems;
        private System.Windows.Forms.ListBox lstSelection;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource looseitemsBindingSource;
        private order_databaseDataSetTableAdapters.loose_itemsTableAdapter loose_itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}