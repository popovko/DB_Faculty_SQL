namespace DBFaculty__lab4_
{
    partial class FormAddSubject
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
            this.tbSbName = new System.Windows.Forms.TextBox();
            this.lblSbName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSbInfo = new System.Windows.Forms.Label();
            this.tbSbInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(281, 295);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbSbName
            // 
            this.tbSbName.Location = new System.Drawing.Point(417, 151);
            this.tbSbName.Name = "tbSbName";
            this.tbSbName.Size = new System.Drawing.Size(100, 20);
            this.tbSbName.TabIndex = 17;
            // 
            // lblSbName
            // 
            this.lblSbName.AutoSize = true;
            this.lblSbName.Location = new System.Drawing.Point(278, 151);
            this.lblSbName.Name = "lblSbName";
            this.lblSbName.Size = new System.Drawing.Size(90, 13);
            this.lblSbName.TabIndex = 15;
            this.lblSbName.Text = "Назва предмету";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(253, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 121);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblSbInfo
            // 
            this.lblSbInfo.AutoSize = true;
            this.lblSbInfo.Location = new System.Drawing.Point(278, 212);
            this.lblSbInfo.Name = "lblSbInfo";
            this.lblSbInfo.Size = new System.Drawing.Size(32, 13);
            this.lblSbInfo.TabIndex = 16;
            this.lblSbInfo.Text = "INFO";
            // 
            // tbSbInfo
            // 
            this.tbSbInfo.Location = new System.Drawing.Point(417, 212);
            this.tbSbInfo.Name = "tbSbInfo";
            this.tbSbInfo.Size = new System.Drawing.Size(100, 20);
            this.tbSbInfo.TabIndex = 21;
            // 
            // FormAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSbInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbSbName);
            this.Controls.Add(this.lblSbInfo);
            this.Controls.Add(this.lblSbName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAddSubject";
            this.Text = "Додати предмет";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbSbName;
        private System.Windows.Forms.Label lblSbName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSbInfo;
        private System.Windows.Forms.TextBox tbSbInfo;
    }
}