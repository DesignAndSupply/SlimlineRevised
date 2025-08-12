namespace SlimlineRevisedUI
{
    partial class frmMultipleProvingSelection
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSplitProving = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(12, 42);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.Size = new System.Drawing.Size(403, 302);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select at least 2 staff members to split the proving between!";
            // 
            // btnSplitProving
            // 
            this.btnSplitProving.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSplitProving.Location = new System.Drawing.Point(216, 350);
            this.btnSplitProving.Name = "btnSplitProving";
            this.btnSplitProving.Size = new System.Drawing.Size(97, 25);
            this.btnSplitProving.TabIndex = 2;
            this.btnSplitProving.Text = "Split Proving";
            this.btnSplitProving.UseVisualStyleBackColor = true;
            this.btnSplitProving.Click += new System.EventHandler(this.btnSplitProving_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancel.Location = new System.Drawing.Point(113, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMultipleProvingSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 383);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSplitProving);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStaff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMultipleProvingSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multiple Proving Split";
            this.Shown += new System.EventHandler(this.frmMultipleProvingSelection_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSplitProving;
        private System.Windows.Forms.Button btnCancel;
    }
}