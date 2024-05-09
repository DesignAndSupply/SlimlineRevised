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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCutting = new System.Windows.Forms.RadioButton();
            this.rdoPrepping = new System.Windows.Forms.RadioButton();
            this.rdoAssembly = new System.Windows.Forms.RadioButton();
            this.rdoBuffing = new System.Windows.Forms.RadioButton();
            this.rdoPainting = new System.Windows.Forms.RadioButton();
            this.rdoPacking = new System.Windows.Forms.RadioButton();
            this.txtReason = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogRepaint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoOffice = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOffice);
            this.groupBox1.Controls.Add(this.rdoPacking);
            this.groupBox1.Controls.Add(this.rdoPainting);
            this.groupBox1.Controls.Add(this.rdoBuffing);
            this.groupBox1.Controls.Add(this.rdoAssembly);
            this.groupBox1.Controls.Add(this.rdoPrepping);
            this.groupBox1.Controls.Add(this.rdoCutting);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(32, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department at Fault";
            // 
            // rdoCutting
            // 
            this.rdoCutting.AutoSize = true;
            this.rdoCutting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoCutting.Location = new System.Drawing.Point(22, 35);
            this.rdoCutting.Name = "rdoCutting";
            this.rdoCutting.Size = new System.Drawing.Size(80, 24);
            this.rdoCutting.TabIndex = 1;
            this.rdoCutting.TabStop = true;
            this.rdoCutting.Text = "Cutting";
            this.rdoCutting.UseVisualStyleBackColor = true;
            this.rdoCutting.CheckedChanged += new System.EventHandler(this.rdoCutting_CheckedChanged);
            // 
            // rdoPrepping
            // 
            this.rdoPrepping.AutoSize = true;
            this.rdoPrepping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoPrepping.Location = new System.Drawing.Point(22, 74);
            this.rdoPrepping.Name = "rdoPrepping";
            this.rdoPrepping.Size = new System.Drawing.Size(93, 24);
            this.rdoPrepping.TabIndex = 2;
            this.rdoPrepping.TabStop = true;
            this.rdoPrepping.Text = "Prepping";
            this.rdoPrepping.UseVisualStyleBackColor = true;
            this.rdoPrepping.CheckedChanged += new System.EventHandler(this.rdoPrepping_CheckedChanged);
            // 
            // rdoAssembly
            // 
            this.rdoAssembly.AutoSize = true;
            this.rdoAssembly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoAssembly.Location = new System.Drawing.Point(22, 113);
            this.rdoAssembly.Name = "rdoAssembly";
            this.rdoAssembly.Size = new System.Drawing.Size(100, 24);
            this.rdoAssembly.TabIndex = 3;
            this.rdoAssembly.TabStop = true;
            this.rdoAssembly.Text = "Assembly";
            this.rdoAssembly.UseVisualStyleBackColor = true;
            this.rdoAssembly.CheckedChanged += new System.EventHandler(this.rdoAssembly_CheckedChanged);
            // 
            // rdoBuffing
            // 
            this.rdoBuffing.AutoSize = true;
            this.rdoBuffing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoBuffing.Location = new System.Drawing.Point(22, 152);
            this.rdoBuffing.Name = "rdoBuffing";
            this.rdoBuffing.Size = new System.Drawing.Size(84, 24);
            this.rdoBuffing.TabIndex = 4;
            this.rdoBuffing.TabStop = true;
            this.rdoBuffing.Text = "SL Buff";
            this.rdoBuffing.UseVisualStyleBackColor = true;
            this.rdoBuffing.CheckedChanged += new System.EventHandler(this.rdoBuffing_CheckedChanged);
            // 
            // rdoPainting
            // 
            this.rdoPainting.AutoSize = true;
            this.rdoPainting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoPainting.Location = new System.Drawing.Point(22, 191);
            this.rdoPainting.Name = "rdoPainting";
            this.rdoPainting.Size = new System.Drawing.Size(87, 24);
            this.rdoPainting.TabIndex = 5;
            this.rdoPainting.TabStop = true;
            this.rdoPainting.Text = "Painting";
            this.rdoPainting.UseVisualStyleBackColor = true;
            this.rdoPainting.CheckedChanged += new System.EventHandler(this.rdoPainting_CheckedChanged);
            // 
            // rdoPacking
            // 
            this.rdoPacking.AutoSize = true;
            this.rdoPacking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoPacking.Location = new System.Drawing.Point(22, 230);
            this.rdoPacking.Name = "rdoPacking";
            this.rdoPacking.Size = new System.Drawing.Size(86, 24);
            this.rdoPacking.TabIndex = 6;
            this.rdoPacking.TabStop = true;
            this.rdoPacking.Text = "Packing";
            this.rdoPacking.UseVisualStyleBackColor = true;
            this.rdoPacking.CheckedChanged += new System.EventHandler(this.rdoPacking_CheckedChanged);
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtReason.Location = new System.Drawing.Point(272, 84);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(435, 283);
            this.txtReason.TabIndex = 1;
            this.txtReason.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(413, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reason for Repaint";
            // 
            // btnLogRepaint
            // 
            this.btnLogRepaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLogRepaint.Location = new System.Drawing.Point(349, 384);
            this.btnLogRepaint.Name = "btnLogRepaint";
            this.btnLogRepaint.Size = new System.Drawing.Size(133, 32);
            this.btnLogRepaint.TabIndex = 3;
            this.btnLogRepaint.Text = "Log Repaint";
            this.btnLogRepaint.UseVisualStyleBackColor = true;
            this.btnLogRepaint.Click += new System.EventHandler(this.btnLogRepaint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCancel.Location = new System.Drawing.Point(238, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(271, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slimline Repaints";
            // 
            // rdoOffice
            // 
            this.rdoOffice.AutoSize = true;
            this.rdoOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rdoOffice.Location = new System.Drawing.Point(22, 266);
            this.rdoOffice.Name = "rdoOffice";
            this.rdoOffice.Size = new System.Drawing.Size(72, 24);
            this.rdoOffice.TabIndex = 7;
            this.rdoOffice.TabStop = true;
            this.rdoOffice.Text = "Office";
            this.rdoOffice.UseVisualStyleBackColor = true;
            this.rdoOffice.CheckedChanged += new System.EventHandler(this.rdoOffice_CheckedChanged);
            // 
            // frmRepaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 426);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogRepaint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Slimline Repaint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPacking;
        private System.Windows.Forms.RadioButton rdoPainting;
        private System.Windows.Forms.RadioButton rdoBuffing;
        private System.Windows.Forms.RadioButton rdoAssembly;
        private System.Windows.Forms.RadioButton rdoPrepping;
        private System.Windows.Forms.RadioButton rdoCutting;
        private System.Windows.Forms.RichTextBox txtReason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogRepaint;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoOffice;
    }
}