
namespace WindowsFormsApp3
{
    partial class admin_reg
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 873);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 90);
            this.button1.TabIndex = 40;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 38);
            this.label2.TabIndex = 39;
            this.label2.Text = "Enter Registration credentials";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PapayaWhip;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(567, 739);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(247, 90);
            this.submit.TabIndex = 38;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 38);
            this.label6.TabIndex = 37;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(608, 590);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(437, 47);
            this.password.TabIndex = 35;
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(608, 412);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(437, 47);
            this.user.TabIndex = 34;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 62);
            this.label1.TabIndex = 33;
            this.label1.Text = "Welcome to LenaDena Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 38);
            this.label3.TabIndex = 41;
            this.label3.Text = "PIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pin
            // 
            this.pin.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.Location = new System.Drawing.Point(608, 292);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(437, 47);
            this.pin.TabIndex = 42;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Lime;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(396, 1037);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(672, 38);
            this.linkLabel2.TabIndex = 43;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Already have an account ? Click here to login";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // admin_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 1143);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Name = "admin_reg";
            this.Text = "admin_reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}