namespace SlimlineRevisedUI.Forms
{
    partial class frmProvingSelection
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
            this.btnProving = new System.Windows.Forms.Button();
            this.btnBuffing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProving
            // 
            this.btnProving.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F);
            this.btnProving.Location = new System.Drawing.Point(57, 191);
            this.btnProving.Name = "btnProving";
            this.btnProving.Size = new System.Drawing.Size(323, 184);
            this.btnProving.TabIndex = 0;
            this.btnProving.Text = "PROVING";
            this.btnProving.UseVisualStyleBackColor = true;
            this.btnProving.Click += new System.EventHandler(this.btnProving_Click);
            // 
            // btnBuffing
            // 
            this.btnBuffing.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F);
            this.btnBuffing.Location = new System.Drawing.Point(420, 191);
            this.btnBuffing.Name = "btnBuffing";
            this.btnBuffing.Size = new System.Drawing.Size(323, 184);
            this.btnBuffing.TabIndex = 1;
            this.btnBuffing.Text = "BUFFING";
            this.btnBuffing.UseVisualStyleBackColor = true;
            this.btnBuffing.Click += new System.EventHandler(this.btnBuffing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(-4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROVING OR BUFFING?";
            // 
            // frmProvingSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuffing);
            this.Controls.Add(this.btnProving);
            this.Name = "frmProvingSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proving or Buffing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProving;
        private System.Windows.Forms.Button btnBuffing;
        private System.Windows.Forms.Label label1;
    }
}