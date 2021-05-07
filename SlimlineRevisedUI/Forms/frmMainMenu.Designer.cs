namespace SlimlineRevisedUI.Forms
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.dgvSections = new System.Windows.Forms.DataGridView();
            this.txtDoorIDSearch = new System.Windows.Forms.TextBox();
            this.btnLoadDoor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLooseItems = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewAllocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLabelFromStockCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printLabelFromPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOutConsumableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allocateWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packingListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSections
            // 
            this.dgvSections.AllowUserToAddRows = false;
            this.dgvSections.AllowUserToDeleteRows = false;
            this.dgvSections.AllowUserToOrderColumns = true;
            this.dgvSections.AllowUserToResizeColumns = false;
            this.dgvSections.AllowUserToResizeRows = false;
            this.dgvSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSections.Location = new System.Drawing.Point(13, 193);
            this.dgvSections.Name = "dgvSections";
            this.dgvSections.RowHeadersVisible = false;
            this.dgvSections.Size = new System.Drawing.Size(791, 384);
            this.dgvSections.TabIndex = 0;
            this.dgvSections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSections_CellContentClick);
            // 
            // txtDoorIDSearch
            // 
            this.txtDoorIDSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoorIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoorIDSearch.Location = new System.Drawing.Point(731, 138);
            this.txtDoorIDSearch.Name = "txtDoorIDSearch";
            this.txtDoorIDSearch.Size = new System.Drawing.Size(73, 20);
            this.txtDoorIDSearch.TabIndex = 1;
            // 
            // btnLoadDoor
            // 
            this.btnLoadDoor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDoor.Location = new System.Drawing.Point(731, 164);
            this.btnLoadDoor.Name = "btnLoadDoor";
            this.btnLoadDoor.Size = new System.Drawing.Size(73, 23);
            this.btnLoadDoor.TabIndex = 2;
            this.btnLoadDoor.Text = "Load Door";
            this.btnLoadDoor.UseVisualStyleBackColor = true;
            this.btnLoadDoor.Click += new System.EventHandler(this.btnLoadDoor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "\\\\designsvr1\\apps\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(319, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLooseItems
            // 
            this.btnLooseItems.Location = new System.Drawing.Point(650, 164);
            this.btnLooseItems.Name = "btnLooseItems";
            this.btnLooseItems.Size = new System.Drawing.Size(75, 23);
            this.btnLooseItems.TabIndex = 10;
            this.btnLooseItems.Text = "Loose Items";
            this.btnLooseItems.UseVisualStyleBackColor = true;
            this.btnLooseItems.Click += new System.EventHandler(this.btnLooseItems_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllocationToolStripMenuItem,
            this.stockManagementToolStripMenuItem,
            this.allocateWorkToolStripMenuItem,
            this.packingListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewAllocationToolStripMenuItem
            // 
            this.viewAllocationToolStripMenuItem.Name = "viewAllocationToolStripMenuItem";
            this.viewAllocationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.viewAllocationToolStripMenuItem.Text = "View Allocation";
            this.viewAllocationToolStripMenuItem.Click += new System.EventHandler(this.viewAllocationToolStripMenuItem_Click);
            // 
            // stockManagementToolStripMenuItem
            // 
            this.stockManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printLabelToolStripMenuItem,
            this.bookOutConsumableToolStripMenuItem});
            this.stockManagementToolStripMenuItem.Name = "stockManagementToolStripMenuItem";
            this.stockManagementToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.stockManagementToolStripMenuItem.Text = "Stock Management";
            // 
            // printLabelToolStripMenuItem
            // 
            this.printLabelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printLabelFromStockCodeToolStripMenuItem,
            this.printLabelFromPurchaseOrderToolStripMenuItem});
            this.printLabelToolStripMenuItem.Name = "printLabelToolStripMenuItem";
            this.printLabelToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.printLabelToolStripMenuItem.Text = "Print Label";
            // 
            // printLabelFromStockCodeToolStripMenuItem
            // 
            this.printLabelFromStockCodeToolStripMenuItem.Name = "printLabelFromStockCodeToolStripMenuItem";
            this.printLabelFromStockCodeToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.printLabelFromStockCodeToolStripMenuItem.Text = "Print Label from description";
            this.printLabelFromStockCodeToolStripMenuItem.Click += new System.EventHandler(this.printLabelFromStockCodeToolStripMenuItem_Click);
            // 
            // printLabelFromPurchaseOrderToolStripMenuItem
            // 
            this.printLabelFromPurchaseOrderToolStripMenuItem.Name = "printLabelFromPurchaseOrderToolStripMenuItem";
            this.printLabelFromPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.printLabelFromPurchaseOrderToolStripMenuItem.Text = "Print Label from purchase order";
            this.printLabelFromPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.printLabelFromPurchaseOrderToolStripMenuItem_Click);
            // 
            // bookOutConsumableToolStripMenuItem
            // 
            this.bookOutConsumableToolStripMenuItem.Name = "bookOutConsumableToolStripMenuItem";
            this.bookOutConsumableToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.bookOutConsumableToolStripMenuItem.Text = "Book out consumable";
            this.bookOutConsumableToolStripMenuItem.Click += new System.EventHandler(this.bookOutConsumableToolStripMenuItem_Click);
            // 
            // allocateWorkToolStripMenuItem
            // 
            this.allocateWorkToolStripMenuItem.Name = "allocateWorkToolStripMenuItem";
            this.allocateWorkToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.allocateWorkToolStripMenuItem.Text = "Allocate Work";
            this.allocateWorkToolStripMenuItem.Click += new System.EventHandler(this.AllocateWorkToolStripMenuItem_Click);
            // 
            // packingListToolStripMenuItem
            // 
            this.packingListToolStripMenuItem.Name = "packingListToolStripMenuItem";
            this.packingListToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.packingListToolStripMenuItem.Text = "Packing List";
            this.packingListToolStripMenuItem.Click += new System.EventHandler(this.packingListToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 589);
            this.Controls.Add(this.btnLooseItems);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadDoor);
            this.Controls.Add(this.txtDoorIDSearch);
            this.Controls.Add(this.dgvSections);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.Text = "Slimline Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSections;
        private System.Windows.Forms.TextBox txtDoorIDSearch;
        private System.Windows.Forms.Button btnLoadDoor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLooseItems;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewAllocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLabelFromStockCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printLabelFromPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOutConsumableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allocateWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packingListToolStripMenuItem;
    }
}