namespace DBFaculty__lab4_
{
    partial class FormChange
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
            this.cbCurators = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblNewLeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.cbNewLeader = new System.Windows.Forms.ComboBox();
            this.lblNewCurator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCurators
            // 
            this.cbCurators.FormattingEnabled = true;
            this.cbCurators.Location = new System.Drawing.Point(417, 204);
            this.cbCurators.Name = "cbCurators";
            this.cbCurators.Size = new System.Drawing.Size(100, 21);
            this.cbCurators.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(278, 99);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 9;
            this.lblGroup.Text = "Група";
            // 
            // lblNewLeader
            // 
            this.lblNewLeader.AutoSize = true;
            this.lblNewLeader.Location = new System.Drawing.Point(278, 151);
            this.lblNewLeader.Name = "lblNewLeader";
            this.lblNewLeader.Size = new System.Drawing.Size(88, 13);
            this.lblNewLeader.TabIndex = 8;
            this.lblNewLeader.Text = "Новий староста";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(253, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 183);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // cbGroups
            // 
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(417, 96);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(100, 21);
            this.cbGroups.TabIndex = 15;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // cbNewLeader
            // 
            this.cbNewLeader.FormattingEnabled = true;
            this.cbNewLeader.Location = new System.Drawing.Point(417, 151);
            this.cbNewLeader.Name = "cbNewLeader";
            this.cbNewLeader.Size = new System.Drawing.Size(100, 21);
            this.cbNewLeader.TabIndex = 16;
            // 
            // lblNewCurator
            // 
            this.lblNewCurator.AutoSize = true;
            this.lblNewCurator.Location = new System.Drawing.Point(278, 207);
            this.lblNewCurator.Name = "lblNewCurator";
            this.lblNewCurator.Size = new System.Drawing.Size(82, 13);
            this.lblNewCurator.TabIndex = 17;
            this.lblNewCurator.Text = "Новий куратор";
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewCurator);
            this.Controls.Add(this.cbNewLeader);
            this.Controls.Add(this.cbGroups);
            this.Controls.Add(this.cbCurators);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblNewLeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormChange";
            this.Text = "Змінити групу";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurators;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblNewLeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.ComboBox cbNewLeader;
        private System.Windows.Forms.Label lblNewCurator;
    }
}