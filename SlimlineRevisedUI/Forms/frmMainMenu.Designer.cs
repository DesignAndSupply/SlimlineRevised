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
            this.viewAllocationToolStripMenuItem});
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
    }
}