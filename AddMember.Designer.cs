namespace GymManagementSys
{
    partial class AddMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseLb = new System.Windows.Forms.Label();
            this.MemberNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MAmountTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.TimeTb = new System.Windows.Forms.ComboBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.BackkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(490, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD NEW MEMBERS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(448, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "MY FITNESS CLUB";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CloseLb
            // 
            this.CloseLb.AutoSize = true;
            this.CloseLb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLb.ForeColor = System.Drawing.Color.Crimson;
            this.CloseLb.Location = new System.Drawing.Point(1161, 9);
            this.CloseLb.Name = "CloseLb";
            this.CloseLb.Size = new System.Drawing.Size(34, 34);
            this.CloseLb.TabIndex = 4;
            this.CloseLb.Text = "X";
            this.CloseLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // MemberNameTb
            // 
            this.MemberNameTb.BorderColor = System.Drawing.Color.Black;
            this.MemberNameTb.BorderRadius = 1;
            this.MemberNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MemberNameTb.DefaultText = "";
            this.MemberNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MemberNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MemberNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MemberNameTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.MemberNameTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MemberNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.MemberNameTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.MemberNameTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.MemberNameTb.Location = new System.Drawing.Point(130, 254);
            this.MemberNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberNameTb.Name = "MemberNameTb";
            this.MemberNameTb.PasswordChar = '\0';
            this.MemberNameTb.PlaceholderText = "";
            this.MemberNameTb.SelectedText = "";
            this.MemberNameTb.Size = new System.Drawing.Size(205, 55);
            this.MemberNameTb.TabIndex = 5;
            this.MemberNameTb.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(148, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "MEMBER NAME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(539, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "PHONE NUMBER";
            // 
            // PNumberTb
            // 
            this.PNumberTb.BorderColor = System.Drawing.Color.Black;
            this.PNumberTb.BorderRadius = 1;
            this.PNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNumberTb.DefaultText = "";
            this.PNumberTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNumberTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNumberTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNumberTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNumberTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.PNumberTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PNumberTb.ForeColor = System.Drawing.Color.Crimson;
            this.PNumberTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.PNumberTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.PNumberTb.Location = new System.Drawing.Point(531, 254);
            this.PNumberTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNumberTb.Name = "PNumberTb";
            this.PNumberTb.PasswordChar = '\0';
            this.PNumberTb.PlaceholderText = "";
            this.PNumberTb.SelectedText = "";
            this.PNumberTb.Size = new System.Drawing.Size(205, 55);
            this.PNumberTb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(917, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "AGE";
            // 
            // AgeTb
            // 
            this.AgeTb.BorderColor = System.Drawing.Color.Black;
            this.AgeTb.BorderRadius = 1;
            this.AgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTb.DefaultText = "";
            this.AgeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.AgeTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AgeTb.ForeColor = System.Drawing.Color.Crimson;
            this.AgeTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.AgeTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.AgeTb.Location = new System.Drawing.Point(892, 254);
            this.AgeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.PasswordChar = '\0';
            this.AgeTb.PlaceholderText = "";
            this.AgeTb.SelectedText = "";
            this.AgeTb.Size = new System.Drawing.Size(205, 55);
            this.AgeTb.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(138, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "GENDER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(526, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "MONTHLY AMOUNT";
            // 
            // MAmountTb
            // 
            this.MAmountTb.BorderColor = System.Drawing.Color.Black;
            this.MAmountTb.BorderRadius = 1;
            this.MAmountTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MAmountTb.DefaultText = "";
            this.MAmountTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MAmountTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MAmountTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAmountTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MAmountTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.MAmountTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MAmountTb.ForeColor = System.Drawing.Color.Crimson;
            this.MAmountTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.MAmountTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.MAmountTb.Location = new System.Drawing.Point(531, 442);
            this.MAmountTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MAmountTb.Name = "MAmountTb";
            this.MAmountTb.PasswordChar = '\0';
            this.MAmountTb.PlaceholderText = "";
            this.MAmountTb.SelectedText = "";
            this.MAmountTb.Size = new System.Drawing.Size(205, 55);
            this.MAmountTb.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(900, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 27);
            this.label9.TabIndex = 16;
            this.label9.Text = "TIMING";
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCb.ForeColor = System.Drawing.Color.Crimson;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GenderCb.Location = new System.Drawing.Point(143, 442);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(192, 31);
            this.GenderCb.TabIndex = 17;
            // 
            // TimeTb
            // 
            this.TimeTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTb.ForeColor = System.Drawing.Color.Crimson;
            this.TimeTb.FormattingEnabled = true;
            this.TimeTb.Items.AddRange(new object[] {
            "5AM-7AM",
            "7AM-9AM",
            "9AM-11AM",
            "4PM-6PM",
            "6PM-9PM",
            "9PM-12PM"});
            this.TimeTb.Location = new System.Drawing.Point(905, 442);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(192, 31);
            this.TimeTb.TabIndex = 18;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Crimson;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(397, 581);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(123, 51);
            this.Addbtn.TabIndex = 19;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Crimson;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(574, 581);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(127, 51);
            this.ResetBtn.TabIndex = 20;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Crimson;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(745, 581);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 51);
            this.BackBtn.TabIndex = 21;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // BackkBtn
            // 
            this.BackkBtn.BackColor = System.Drawing.Color.Crimson;
            this.BackkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackkBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackkBtn.ForeColor = System.Drawing.Color.White;
            this.BackkBtn.Location = new System.Drawing.Point(554, 675);
            this.BackkBtn.Name = "BackkBtn";
            this.BackkBtn.Size = new System.Drawing.Size(171, 33);
            this.BackkBtn.TabIndex = 22;
            this.BackkBtn.Text = "BACK";
            this.BackkBtn.UseVisualStyleBackColor = false;
            this.BackkBtn.Click += new System.EventHandler(this.BackkBtn_Click);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 776);
            this.Controls.Add(this.BackkBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.TimeTb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MAmountTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PNumberTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemberNameTb);
            this.Controls.Add(this.CloseLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMember";
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CloseLb;
        private Guna.UI2.WinForms.Guna2TextBox MemberNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PNumberTb;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox AgeTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox MAmountTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox TimeTb;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button BackkBtn;
    }
}