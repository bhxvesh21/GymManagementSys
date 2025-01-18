namespace GymManagementSys
{
    partial class UpdateDelete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDelete));
            this.TimeTb = new System.Windows.Forms.ComboBox();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AmountTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PNoTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MemberNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BacBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.MemberGgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.TimeTb.Location = new System.Drawing.Point(50, 657);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(192, 31);
            this.TimeTb.TabIndex = 33;
            // 
            // GenderCb
            // 
            this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCb.ForeColor = System.Drawing.Color.Crimson;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.GenderCb.Location = new System.Drawing.Point(51, 253);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(192, 31);
            this.GenderCb.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(47, 612);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "TIMING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(48, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "MONTHLY AMOUNT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // AmountTb
            // 
            this.AmountTb.BorderColor = System.Drawing.Color.Black;
            this.AmountTb.BorderRadius = 1;
            this.AmountTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTb.DefaultText = "";
            this.AmountTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AmountTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AmountTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AmountTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AmountTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.AmountTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AmountTb.ForeColor = System.Drawing.Color.Crimson;
            this.AmountTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.AmountTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.AmountTb.Location = new System.Drawing.Point(52, 545);
            this.AmountTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.PasswordChar = '\0';
            this.AmountTb.PlaceholderText = "";
            this.AmountTb.SelectedText = "";
            this.AmountTb.Size = new System.Drawing.Size(205, 41);
            this.AmountTb.TabIndex = 29;
            this.AmountTb.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(47, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "GENDER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(57, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "AGE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.AgeTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTb.ForeColor = System.Drawing.Color.Crimson;
            this.AgeTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.AgeTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.AgeTb.Location = new System.Drawing.Point(51, 436);
            this.AgeTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.PasswordChar = '\0';
            this.AgeTb.PlaceholderText = "";
            this.AgeTb.SelectedText = "";
            this.AgeTb.Size = new System.Drawing.Size(205, 40);
            this.AgeTb.TabIndex = 26;
            this.AgeTb.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(46, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "PHONE NUMBER";
            // 
            // PNoTb
            // 
            this.PNoTb.BorderColor = System.Drawing.Color.Black;
            this.PNoTb.BorderRadius = 1;
            this.PNoTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNoTb.DefaultText = "";
            this.PNoTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PNoTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PNoTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNoTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PNoTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.PNoTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PNoTb.ForeColor = System.Drawing.Color.Crimson;
            this.PNoTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.PNoTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.PNoTb.Location = new System.Drawing.Point(51, 342);
            this.PNoTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PNoTb.Name = "PNoTb";
            this.PNoTb.PasswordChar = '\0';
            this.PNoTb.PlaceholderText = "";
            this.PNoTb.SelectedText = "";
            this.PNoTb.Size = new System.Drawing.Size(205, 36);
            this.PNoTb.TabIndex = 24;
            this.PNoTb.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(46, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "MEMBER NAME";
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
            this.MemberNameTb.Location = new System.Drawing.Point(50, 166);
            this.MemberNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberNameTb.Name = "MemberNameTb";
            this.MemberNameTb.PasswordChar = '\0';
            this.MemberNameTb.PlaceholderText = "";
            this.MemberNameTb.SelectedText = "";
            this.MemberNameTb.Size = new System.Drawing.Size(205, 37);
            this.MemberNameTb.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(1458, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(585, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 51);
            this.label2.TabIndex = 20;
            this.label2.Text = "MY FITNESS CLUB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(555, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "UPDATE AND DELETE MEMBER";
            // 
            // BacBtn
            // 
            this.BacBtn.BackColor = System.Drawing.Color.Crimson;
            this.BacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BacBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BacBtn.ForeColor = System.Drawing.Color.White;
            this.BacBtn.Location = new System.Drawing.Point(113, 782);
            this.BacBtn.Name = "BacBtn";
            this.BacBtn.Size = new System.Drawing.Size(144, 33);
            this.BacBtn.TabIndex = 37;
            this.BacBtn.Text = "BACK";
            this.BacBtn.UseVisualStyleBackColor = false;
            this.BacBtn.Click += new System.EventHandler(this.BacBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Crimson;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(221, 722);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(88, 38);
            this.ResetBtn.TabIndex = 36;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(124, 722);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(91, 38);
            this.DeleteBtn.TabIndex = 35;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Crimson;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(22, 722);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(96, 38);
            this.UpdateBtn.TabIndex = 34;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(558, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(433, 23);
            this.label10.TabIndex = 39;
            this.label10.Text = "CLICK ON THE MEMBER NEED TO BE DELETED";
            // 
            // MemberGgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MemberGgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberGgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MemberGgv.ColumnHeadersHeight = 30;
            this.MemberGgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberGgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.MemberGgv.GridColor = System.Drawing.Color.Red;
            this.MemberGgv.Location = new System.Drawing.Point(283, 135);
            this.MemberGgv.Name = "MemberGgv";
            this.MemberGgv.RowHeadersVisible = false;
            this.MemberGgv.RowHeadersWidth = 51;
            this.MemberGgv.RowTemplate.Height = 25;
            this.MemberGgv.Size = new System.Drawing.Size(1195, 581);
            this.MemberGgv.TabIndex = 40;
            this.MemberGgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Crimson;
            this.MemberGgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MemberGgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MemberGgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MemberGgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MemberGgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MemberGgv.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.MemberGgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.MemberGgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MemberGgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberGgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Crimson;
            this.MemberGgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MemberGgv.ThemeStyle.HeaderStyle.Height = 30;
            this.MemberGgv.ThemeStyle.ReadOnly = false;
            this.MemberGgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Crimson;
            this.MemberGgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MemberGgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberGgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Indigo;
            this.MemberGgv.ThemeStyle.RowsStyle.Height = 25;
            this.MemberGgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.MemberGgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MemberGgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberGgv_CellContentClick);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(61, 19);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(103, 106);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 44;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // UpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 874);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.MemberGgv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BacBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.TimeTb);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PNoTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemberNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDelete";
            this.Load += new System.EventHandler(this.UpdateDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberGgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TimeTb;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox AmountTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox AgeTb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PNoTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox MemberNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BacBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView MemberGgv;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}