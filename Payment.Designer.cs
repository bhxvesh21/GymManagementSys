namespace GymManagementSys
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PaymntDt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.PayBtn = new System.Windows.Forms.Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.NameTb = new System.Windows.Forms.ComboBox();
            this.PaymentGsv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SeachNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGsv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(1289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(473, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "MY FITNESS CLUB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(605, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAYMENTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(33, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "MEMBER NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(38, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "AMOUNT";
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
            this.AmountTb.Location = new System.Drawing.Point(37, 509);
            this.AmountTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.PasswordChar = '\0';
            this.AmountTb.PlaceholderText = "";
            this.AmountTb.SelectedText = "";
            this.AmountTb.Size = new System.Drawing.Size(205, 38);
            this.AmountTb.TabIndex = 26;
            // 
            // PaymntDt
            // 
            this.PaymntDt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymntDt.Location = new System.Drawing.Point(37, 342);
            this.PaymntDt.Name = "PaymntDt";
            this.PaymntDt.Size = new System.Drawing.Size(200, 32);
            this.PaymntDt.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(38, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "PAYMENT MONTH";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Crimson;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(61, 652);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(144, 34);
            this.BackBtn.TabIndex = 41;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Crimson;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(149, 592);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(88, 39);
            this.ResetBtn.TabIndex = 40;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Crimson;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.ForeColor = System.Drawing.Color.White;
            this.PayBtn.Location = new System.Drawing.Point(38, 592);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(96, 39);
            this.PayBtn.TabIndex = 38;
            this.PayBtn.Text = "PAY";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(460, 72);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(112, 121);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 43;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTb.ForeColor = System.Drawing.Color.Crimson;
            this.NameTb.FormattingEnabled = true;
            this.NameTb.Items.AddRange(new object[] {
            "5AM-7AM",
            "7AM-9AM",
            "9AM-11AM",
            "4PM-6PM",
            "6PM-9PM",
            "9PM-12PM"});
            this.NameTb.Location = new System.Drawing.Point(37, 425);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(192, 31);
            this.NameTb.TabIndex = 44;
            // 
            // PaymentGsv
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PaymentGsv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentGsv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PaymentGsv.ColumnHeadersHeight = 30;
            this.PaymentGsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PaymentGsv.DefaultCellStyle = dataGridViewCellStyle6;
            this.PaymentGsv.GridColor = System.Drawing.Color.Red;
            this.PaymentGsv.Location = new System.Drawing.Point(256, 214);
            this.PaymentGsv.Name = "PaymentGsv";
            this.PaymentGsv.RowHeadersVisible = false;
            this.PaymentGsv.RowHeadersWidth = 51;
            this.PaymentGsv.RowTemplate.Height = 25;
            this.PaymentGsv.Size = new System.Drawing.Size(1067, 570);
            this.PaymentGsv.TabIndex = 45;
            this.PaymentGsv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Crimson;
            this.PaymentGsv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PaymentGsv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PaymentGsv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PaymentGsv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PaymentGsv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PaymentGsv.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.PaymentGsv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.PaymentGsv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PaymentGsv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGsv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Crimson;
            this.PaymentGsv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PaymentGsv.ThemeStyle.HeaderStyle.Height = 30;
            this.PaymentGsv.ThemeStyle.ReadOnly = false;
            this.PaymentGsv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Crimson;
            this.PaymentGsv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentGsv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGsv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Indigo;
            this.PaymentGsv.ThemeStyle.RowsStyle.Height = 25;
            this.PaymentGsv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.PaymentGsv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // SeachNameTb
            // 
            this.SeachNameTb.BorderColor = System.Drawing.Color.Black;
            this.SeachNameTb.BorderRadius = 1;
            this.SeachNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SeachNameTb.DefaultText = "";
            this.SeachNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SeachNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SeachNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SeachNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SeachNameTb.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.SeachNameTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SeachNameTb.ForeColor = System.Drawing.Color.Crimson;
            this.SeachNameTb.HoverState.BorderColor = System.Drawing.Color.Red;
            this.SeachNameTb.HoverState.PlaceholderForeColor = System.Drawing.Color.Crimson;
            this.SeachNameTb.Location = new System.Drawing.Point(598, 159);
            this.SeachNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeachNameTb.Name = "SeachNameTb";
            this.SeachNameTb.PasswordChar = '\0';
            this.SeachNameTb.PlaceholderText = "";
            this.SeachNameTb.SelectedText = "";
            this.SeachNameTb.Size = new System.Drawing.Size(205, 38);
            this.SeachNameTb.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(810, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(921, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 39);
            this.button2.TabIndex = 49;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 847);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SeachNameTb);
            this.Controls.Add(this.PaymentGsv);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PaymntDt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentGsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox AmountTb;
        private System.Windows.Forms.DateTimePicker PaymntDt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button PayBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.ComboBox NameTb;
        private Guna.UI2.WinForms.Guna2DataGridView PaymentGsv;
        private Guna.UI2.WinForms.Guna2TextBox SeachNameTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}