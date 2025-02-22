namespace IndexProgram
{
    partial class frmAddCd
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
            this.titleCD = new System.Windows.Forms.Label();
            this.btnRelease = new System.Windows.Forms.Label();
            this.btnMount = new System.Windows.Forms.Label();
            this.btnURL = new System.Windows.Forms.Label();
            this.txtitle = new System.Windows.Forms.TextBox();
            this.txrelease = new System.Windows.Forms.TextBox();
            this.txmount = new System.Windows.Forms.TextBox();
            this.txurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStyle = new System.Windows.Forms.Label();
            this.comboStyle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleCD
            // 
            this.titleCD.AutoSize = true;
            this.titleCD.Location = new System.Drawing.Point(76, 128);
            this.titleCD.Name = "titleCD";
            this.titleCD.Size = new System.Drawing.Size(30, 13);
            this.titleCD.TabIndex = 0;
            this.titleCD.Text = "Title:";
            // 
            // btnRelease
            // 
            this.btnRelease.AutoSize = true;
            this.btnRelease.Location = new System.Drawing.Point(57, 163);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(49, 13);
            this.btnRelease.TabIndex = 1;
            this.btnRelease.Text = "Release:";
            // 
            // btnMount
            // 
            this.btnMount.AutoSize = true;
            this.btnMount.Location = new System.Drawing.Point(16, 212);
            this.btnMount.Name = "btnMount";
            this.btnMount.Size = new System.Drawing.Size(90, 13);
            this.btnMount.TabIndex = 2;
            this.btnMount.Text = "how much songs:";
            // 
            // btnURL
            // 
            this.btnURL.AutoSize = true;
            this.btnURL.Location = new System.Drawing.Point(46, 318);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(60, 13);
            this.btnURL.TabIndex = 4;
            this.btnURL.Text = "Tape URL:";
            // 
            // txtitle
            // 
            this.txtitle.Location = new System.Drawing.Point(142, 125);
            this.txtitle.Name = "txtitle";
            this.txtitle.Size = new System.Drawing.Size(169, 20);
            this.txtitle.TabIndex = 5;
            // 
            // txrelease
            // 
            this.txrelease.Location = new System.Drawing.Point(142, 163);
            this.txrelease.Name = "txrelease";
            this.txrelease.Size = new System.Drawing.Size(169, 20);
            this.txrelease.TabIndex = 6;
            // 
            // txmount
            // 
            this.txmount.Location = new System.Drawing.Point(142, 205);
            this.txmount.Name = "txmount";
            this.txmount.Size = new System.Drawing.Size(169, 20);
            this.txmount.TabIndex = 7;
            // 
            // txurl
            // 
            this.txurl.Location = new System.Drawing.Point(142, 311);
            this.txurl.Name = "txurl";
            this.txurl.Size = new System.Drawing.Size(169, 20);
            this.txurl.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "   \r\nWELCOME \r\nADD A CD HERE";
            // 
            // btnaccept
            // 
            this.btnaccept.Location = new System.Drawing.Point(106, 458);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(75, 23);
            this.btnaccept.TabIndex = 11;
            this.btnaccept.Text = "Next";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(76, 269);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 3;
            this.lblStyle.Text = "Style";
            // 
            // comboStyle
            // 
            this.comboStyle.FormattingEnabled = true;
            this.comboStyle.Location = new System.Drawing.Point(142, 261);
            this.comboStyle.Name = "comboStyle";
            this.comboStyle.Size = new System.Drawing.Size(169, 21);
            this.comboStyle.TabIndex = 13;
            // 
            // frmAddCd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 511);
            this.Controls.Add(this.comboStyle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txurl);
            this.Controls.Add(this.txmount);
            this.Controls.Add(this.txrelease);
            this.Controls.Add(this.txtitle);
            this.Controls.Add(this.btnURL);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.btnMount);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.titleCD);
            this.Name = "frmAddCd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CD";
            this.Load += new System.EventHandler(this.frmAddCd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleCD;
        private System.Windows.Forms.Label btnRelease;
        private System.Windows.Forms.Label btnMount;
        private System.Windows.Forms.Label btnURL;
        private System.Windows.Forms.TextBox txtitle;
        private System.Windows.Forms.TextBox txrelease;
        private System.Windows.Forms.TextBox txmount;
        private System.Windows.Forms.TextBox txurl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox comboStyle;
    }
}