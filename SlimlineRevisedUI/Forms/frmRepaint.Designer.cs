namespace SlimlineRevisedUI.Forms
{
    partial class frmRepaint
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.btnRepaint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Did this problem happen in the paintshop?";
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYes.Location = new System.Drawing.Point(78, 45);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(52, 22);
            this.chkYes.TabIndex = 1;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            this.chkYes.CheckedChanged += new System.EventHandler(this.chkYes_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNo.Location = new System.Drawing.Point(206, 45);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(47, 22);
            this.chkNo.TabIndex = 2;
            this.chkNo.Text = "No";
            this.chkNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 106);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(307, 93);
            this.txtReason.TabIndex = 3;
            this.txtReason.Text = "";
            // 
            // btnRepaint
            // 
            this.btnRepaint.Location = new System.Drawing.Point(182, 205);
            this.btnRepaint.Name = "btnRepaint";
            this.btnRepaint.Size = new System.Drawing.Size(75, 23);
            this.btnRepaint.TabIndex = 4;
            this.btnRepaint.Text = "Log Repaint";
            this.btnRepaint.UseVisualStyleBackColor = true;
            this.btnRepaint.Click += new System.EventHandler(this.btnRepaint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(73, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Note:";
            // 
            // frmRepaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 239);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRepaint);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.label1);
            this.Name = "frmRepaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Repaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.Button btnRepaint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
    }
}