namespace DBFaculty__lab4_
{
    partial class FormAddGroup
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
            this.tbGrName = new System.Windows.Forms.TextBox();
            this.lblGrYear = new System.Windows.Forms.Label();
            this.lblGrName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGrCurator = new System.Windows.Forms.Label();
            this.cbGrCurator = new System.Windows.Forms.ComboBox();
            this.cbGrYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 295);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbGrName
            // 
            this.tbGrName.Location = new System.Drawing.Point(417, 113);
            this.tbGrName.Name = "tbGrName";
            this.tbGrName.Size = new System.Drawing.Size(100, 20);
            this.tbGrName.TabIndex = 24;
            // 
            // lblGrYear
            // 
            this.lblGrYear.AutoSize = true;
            this.lblGrYear.Location = new System.Drawing.Point(278, 159);
            this.lblGrYear.Name = "lblGrYear";
            this.lblGrYear.Size = new System.Drawing.Size(31, 13);
            this.lblGrYear.TabIndex = 23;
            this.lblGrYear.Text = "Курс";
            // 
            // lblGrName
            // 
            this.lblGrName.AutoSize = true;
            this.lblGrName.Location = new System.Drawing.Point(278, 116);
            this.lblGrName.Name = "lblGrName";
            this.lblGrName.Size = new System.Drawing.Size(70, 13);
            this.lblGrName.TabIndex = 22;
            this.lblGrName.Text = "Назва групи";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(253, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 158);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblGrCurator
            // 
            this.lblGrCurator.AutoSize = true;
            this.lblGrCurator.Location = new System.Drawing.Point(278, 212);
            this.lblGrCurator.Name = "lblGrCurator";
            this.lblGrCurator.Size = new System.Drawing.Size(48, 13);
            this.lblGrCurator.TabIndex = 29;
            this.lblGrCurator.Text = "Куратор";
            // 
            // cbGrCurator
            // 
            this.cbGrCurator.FormattingEnabled = true;
            this.cbGrCurator.Location = new System.Drawing.Point(417, 209);
            this.cbGrCurator.Name = "cbGrCurator";
            this.cbGrCurator.Size = new System.Drawing.Size(100, 21);
            this.cbGrCurator.TabIndex = 30;
            // 
            // cbGrYear
            // 
            this.cbGrYear.FormattingEnabled = true;
            this.cbGrYear.Location = new System.Drawing.Point(417, 159);
            this.cbGrYear.Name = "cbGrYear";
            this.cbGrYear.Size = new System.Drawing.Size(100, 21);
            this.cbGrYear.TabIndex = 31;
            // 
            // FormAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbGrYear);
            this.Controls.Add(this.cbGrCurator);
            this.Controls.Add(this.lblGrCurator);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbGrName);
            this.Controls.Add(this.lblGrYear);
            this.Controls.Add(this.lblGrName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddGroup";
            this.Text = "Додати групу";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbGrName;
        private System.Windows.Forms.Label lblGrYear;
        private System.Windows.Forms.Label lblGrName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGrCurator;
        private System.Windows.Forms.ComboBox cbGrCurator;
        private System.Windows.Forms.ComboBox cbGrYear;
    }
}