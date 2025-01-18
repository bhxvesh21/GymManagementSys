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

namespace GymManagementSys
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kodam\Documents\GyymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            con.Open();
            SqlCommand  cmd = new SqlCommand("Select MName from  MemberTbl ",con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
            NameTb.ValueMember = "MName";
            NameTb.DataSource = dt;
            con.Close();
        }
        private void filterByName()
        {
            con.Open();
            String query = "Select * From PaymentTbl where PMember='"+SeachNameTb.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentGsv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Populate()
        {
            con.Open();
            String query = "Select * From PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentGsv.DataSource = ds.Tables[0];
            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //NameTb.Text = "";
            AmountTb.Text = "";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else 
            {
                String Paymnt = PaymntDt.Value.Month.ToString() + PaymntDt.Value.Year.ToString();
                con.Open();
                SqlDataAdapter  sda = new SqlDataAdapter("select count(*) from PaymentTbl Where PMember='"+NameTb.SelectedValue.ToString()+"' and PMonth='"+PaymntDt+"'",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid For This Month");
                }
                else 
                {
                    string query = "insert into PaymentTbl values('"+PaymntDt+ "','"+NameTb.SelectedValue.ToString()+"',"+AmountTb.Text+")";
                    SqlCommand cmd = new SqlCommand(query,con); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }
                con.Close();
                Populate();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            Populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            filterByName();
            SeachNameTb.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
