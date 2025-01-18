using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace GymManagementSys
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kodam\Documents\GyymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddMember_Load(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (MemberNameTb.Text == "" || PNumberTb.Text == "" || AgeTb.Text == "" || MAmountTb.Text == "")
            {
                MessageBox.Show("Please Enter Requried Information");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "insert into MemberTbl values ('" + MemberNameTb.Text + "','" + PNumberTb.Text + "','" + GenderCb.SelectedItem.ToString() + "'," + AgeTb.Text + "," + MAmountTb.Text + ",'" + TimeTb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    con.Close();
                    MAmountTb.Text = "";
                    AgeTb.Text = "";
                    GenderCb.Text = "";
                    MemberNameTb.Text = "";
                    TimeTb.Text = "";
                    PNumberTb.Text = "";


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);    
                }
            }



        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MAmountTb.Text = "";
            AgeTb.Text = "";
            GenderCb.Text = "";
            MemberNameTb.Text = "";
            TimeTb.Text = "";
            PNumberTb.Text = "";

        }

        private void BackkBtn_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
