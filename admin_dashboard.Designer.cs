
namespace WindowsFormsApp3
{
    partial class admin_dashboard
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
            this.showalldata = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.editprofile = new System.Windows.Forms.LinkLabel();
            this.frequent = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.deactivate = new System.Windows.Forms.LinkLabel();
            this.activateuser = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showalldata
            // 
            this.showalldata.AutoSize = true;
            this.showalldata.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showalldata.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.showalldata.Location = new System.Drawing.Point(12, 454);
            this.showalldata.Name = "showalldata";
            this.showalldata.Size = new System.Drawing.Size(287, 50);
            this.showalldata.TabIndex = 0;
            this.showalldata.TabStop = true;
            this.showalldata.Text = "Show all users";
            this.showalldata.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showalldata_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 62);
            this.label1.TabIndex = 34;
            this.label1.Text = "Welcome to LenaDena Bank";
            // 
            // editprofile
            // 
            this.editprofile.AutoSize = true;
            this.editprofile.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editprofile.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.editprofile.Location = new System.Drawing.Point(12, 696);
            this.editprofile.Name = "editprofile";
            this.editprofile.Size = new System.Drawing.Size(375, 50);
            this.editprofile.TabIndex = 35;
            this.editprofile.TabStop = true;
            this.editprofile.Text = "Edit profile of User";
            this.editprofile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editprofile_LinkClicked);
            // 
            // frequent
            // 
            this.frequent.AutoSize = true;
            this.frequent.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequent.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.frequent.Location = new System.Drawing.Point(509, 696);
            this.frequent.Name = "frequent";
            this.frequent.Size = new System.Drawing.Size(511, 50);
            this.frequent.TabIndex = 36;
            this.frequent.TabStop = true;
            this.frequent.Text = "Show most frequent users";
            this.frequent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frequent_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel7.Location = new System.Drawing.Point(509, 454);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(487, 50);
            this.linkLabel7.TabIndex = 37;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Show less frequent users";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // deactivate
            // 
            this.deactivate.AutoSize = true;
            this.deactivate.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivate.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.deactivate.Location = new System.Drawing.Point(1144, 696);
            this.deactivate.Name = "deactivate";
            this.deactivate.Size = new System.Drawing.Size(436, 50);
            this.deactivate.TabIndex = 38;
            this.deactivate.TabStop = true;
            this.deactivate.Text = "Show deactivate users";
            this.deactivate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deactivate_LinkClicked);
            // 
            // activateuser
            // 
            this.activateuser.AutoSize = true;
            this.activateuser.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateuser.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.activateuser.Location = new System.Drawing.Point(1144, 454);
            this.activateuser.Name = "activateuser";
            this.activateuser.Size = new System.Drawing.Size(400, 50);
            this.activateuser.TabIndex = 39;
            this.activateuser.TabStop = true;
            this.activateuser.Text = "Show  activate users";
            this.activateuser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.activateuser_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 62);
            this.label2.TabIndex = 40;
            this.label2.Text = "Admin Dashboard";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PapayaWhip;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(588, 1002);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(247, 90);
            this.submit.TabIndex = 41;
            this.submit.Text = "Close";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 1225);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activateuser);
            this.Controls.Add(this.deactivate);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.frequent);
            this.Controls.Add(this.editprofile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showalldata);
            this.Name = "admin_dashboard";
            this.Text = "admin_dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel showalldata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel editprofile;
        private System.Windows.Forms.LinkLabel frequent;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel deactivate;
        private System.Windows.Forms.LinkLabel activateuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
    }
}