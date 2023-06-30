
namespace WindowsFormsApp3
{
    partial class Datashow
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
            this.label9 = new System.Windows.Forms.Label();
            this.accnum = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.submit = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(468, 961);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 38);
            this.label9.TabIndex = 41;
            this.label9.Text = "Acc number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // accnum
            // 
            this.accnum.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnum.Location = new System.Drawing.Point(711, 951);
            this.accnum.Name = "accnum";
            this.accnum.Size = new System.Drawing.Size(436, 47);
            this.accnum.TabIndex = 40;
            this.accnum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gender
            // 
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender.Location = new System.Drawing.Point(711, 1048);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(436, 45);
            this.gender.TabIndex = 39;
            this.gender.Text = "Select";
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(480, 1055);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 38);
            this.label8.TabIndex = 38;
            this.label8.Text = "Gender";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 851);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 38);
            this.label7.TabIndex = 37;
            this.label7.Text = "Phone ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 38);
            this.label6.TabIndex = 36;
            this.label6.Text = "Balance";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 38);
            this.label5.TabIndex = 35;
            this.label5.Text = "Username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 38);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mail Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 32;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(711, 851);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(436, 47);
            this.phone.TabIndex = 31;
            this.phone.TextChanged += new System.EventHandler(this.add_TextChanged);
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(711, 695);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(436, 47);
            this.balance.TabIndex = 30;
            this.balance.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(711, 561);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(436, 47);
            this.user.TabIndex = 29;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(711, 421);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(436, 47);
            this.id.TabIndex = 28;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // lname
            // 
            this.lname.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(711, 305);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(436, 47);
            this.lname.TabIndex = 27;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 62);
            this.label1.TabIndex = 26;
            this.label1.Text = "Welcome to LenaDena Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fname
            // 
            this.fname.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(711, 193);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(436, 47);
            this.fname.TabIndex = 25;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(468, 1243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(724, 38);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Something Went wrong ? click here to edit profile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PapayaWhip;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(664, 1124);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(246, 90);
            this.submit.TabIndex = 43;
            this.submit.Text = "Close";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.PapayaWhip;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(1218, 658);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(425, 90);
            this.deposit.TabIndex = 44;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.PapayaWhip;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.Location = new System.Drawing.Point(1218, 561);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(425, 90);
            this.withdraw.TabIndex = 45;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PapayaWhip;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1218, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(425, 90);
            this.button1.TabIndex = 46;
            this.button1.Text = "Show History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datashow
            // 
            this.AccessibleDescription = "";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1669, 1330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.accnum);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.user);
            this.Controls.Add(this.id);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fname);
            this.Name = "Datashow";
            this.Text = "Datashow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox accnum;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button button1;
    }
}