namespace DBFaculty__lab4_
{
    partial class FormAddStudent
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
            this.lblStndName = new System.Windows.Forms.Label();
            this.lblStdGroup = new System.Windows.Forms.Label();
            this.tbStName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbStGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStndName
            // 
            this.lblStndName.AutoSize = true;
            this.lblStndName.Location = new System.Drawing.Point(244, 147);
            this.lblStndName.Name = "lblStndName";
            this.lblStndName.Size = new System.Drawing.Size(74, 13);
            this.lblStndName.TabIndex = 0;
            this.lblStndName.Text = "Ім\'я студента";
            // 
            // lblStdGroup
            // 
            this.lblStdGroup.AutoSize = true;
            this.lblStdGroup.Location = new System.Drawing.Point(244, 208);
            this.lblStdGroup.Name = "lblStdGroup";
            this.lblStdGroup.Size = new System.Drawing.Size(36, 13);
            this.lblStdGroup.TabIndex = 1;
            this.lblStdGroup.Text = "Група";
            // 
            // tbStName
            // 
            this.tbStName.Location = new System.Drawing.Point(383, 147);
            this.tbStName.Name = "tbStName";
            this.tbStName.Size = new System.Drawing.Size(100, 20);
            this.tbStName.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(247, 291);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(219, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cbStGroup
            // 
            this.cbStGroup.FormattingEnabled = true;
            this.cbStGroup.Location = new System.Drawing.Point(383, 200);
            this.cbStGroup.Name = "cbStGroup";
            this.cbStGroup.Size = new System.Drawing.Size(100, 21);
            this.cbStGroup.TabIndex = 7;
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStGroup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbStName);
            this.Controls.Add(this.lblStdGroup);
            this.Controls.Add(this.lblStndName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddStudent";
            this.Text = "Додати студента";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStndName;
        private System.Windows.Forms.Label lblStdGroup;
        private System.Windows.Forms.TextBox tbStName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbStGroup;
    }
}