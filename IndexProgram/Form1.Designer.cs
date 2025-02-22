namespace IndexProgram
{
    partial class Form1
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
            this.dgvDisks = new System.Windows.Forms.DataGridView();
            this.pvDiks = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvDiks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisks
            // 
            this.dgvDisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisks.Location = new System.Drawing.Point(49, 78);
            this.dgvDisks.Name = "dgvDisks";
            this.dgvDisks.Size = new System.Drawing.Size(401, 293);
            this.dgvDisks.TabIndex = 0;
            this.dgvDisks.SelectionChanged += new System.EventHandler(this.dgvDisks_SelectionChanged);
            // 
            // pvDiks
            // 
            this.pvDiks.Location = new System.Drawing.Point(599, 78);
            this.pvDiks.Name = "pvDiks";
            this.pvDiks.Size = new System.Drawing.Size(374, 305);
            this.pvDiks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pvDiks.TabIndex = 1;
            this.pvDiks.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "AddCd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 565);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pvDiks);
            this.Controls.Add(this.dgvDisks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pvDiks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisks;
        private System.Windows.Forms.PictureBox pvDiks;
        private System.Windows.Forms.Button btnAdd;
    }
}

