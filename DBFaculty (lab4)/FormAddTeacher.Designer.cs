namespace DBFaculty__lab4_
{
    partial class FormAddTeacher
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbTchName = new System.Windows.Forms.TextBox();
            this.lblTchDepartment = new System.Windows.Forms.Label();
            this.lblTchName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTchDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 295);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbTchName
            // 
            this.tbTchName.Location = new System.Drawing.Point(417, 151);
            this.tbTchName.Name = "tbTchName";
            this.tbTchName.Size = new System.Drawing.Size(100, 20);
            this.tbTchName.TabIndex = 9;
            // 
            // lblTchDepartment
            // 
            this.lblTchDepartment.AutoSize = true;
            this.lblTchDepartment.Location = new System.Drawing.Point(278, 212);
            this.lblTchDepartment.Name = "lblTchDepartment";
            this.lblTchDepartment.Size = new System.Drawing.Size(52, 13);
            this.lblTchDepartment.TabIndex = 8;
            this.lblTchDepartment.Text = "Кафедра";
            // 
            // lblTchName
            // 
            this.lblTchName.AutoSize = true;
            this.lblTchName.Location = new System.Drawing.Point(278, 151);
            this.lblTchName.Name = "lblTchName";
            this.lblTchName.Size = new System.Drawing.Size(82, 13);
            this.lblTchName.TabIndex = 7;
            this.lblTchName.Text = "Ім\'я викладача";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(253, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 121);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbTchDepartment
            // 
            this.cbTchDepartment.FormattingEnabled = true;
            this.cbTchDepartment.Location = new System.Drawing.Point(417, 203);
            this.cbTchDepartment.Name = "cbTchDepartment";
            this.cbTchDepartment.Size = new System.Drawing.Size(100, 21);
            this.cbTchDepartment.TabIndex = 14;
            // 
            // FormAddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTchDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbTchName);
            this.Controls.Add(this.lblTchDepartment);
            this.Controls.Add(this.lblTchName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddTeacher";
            this.Text = "Додати викладача";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbTchName;
        private System.Windows.Forms.Label lblTchDepartment;
        private System.Windows.Forms.Label lblTchName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbTchDepartment;
    }
}