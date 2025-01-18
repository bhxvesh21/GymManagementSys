using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagementSys
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kodam\Documents\GyymDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            con.Open();
            String query = "Select * From Membertbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberGgv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            Populate();
        }
        int key = 0;
        private void MemberGgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MemberGgv.SelectedRows[0].Cells[0].Value.ToString());
            MemberNameTb.Text = MemberGgv.SelectedRows[0].Cells[1].Value.ToString();
            GenderCb.Text = MemberGgv.SelectedRows[0].Cells[2].Value.ToString();
                PNoTb.Text = MemberGgv.SelectedRows[0].Cells[3].Value.ToString(); 
            AgeTb.Text = MemberGgv.SelectedRows[0].Cells[4].Value.ToString(); 
            AmountTb.Text = MemberGgv.SelectedRows[0].Cells[5].Value.ToString(); 
            TimeTb.Text = MemberGgv.SelectedRows[0].Cells[6].Value.ToString(); 
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        { 

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (key == 0 )
            {
                MessageBox.Show(" Select The Member Need To Be Deleted/Updated");
            }
            else 
            {
                try 
                {
                    con.Open();
                    String query = "Delete From MemberTbl where MId=" + key + " ;";
                    SqlCommand cmd = new SqlCommand(query , con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Successfully ");
                    con.Close();
                    Populate();
                
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MemberNameTb.Text = "";
            GenderCb.Text = "";
            PNoTb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            TimeTb.Text = "";
        }

        private void BacBtn_Click(object sender, EventArgs e)
        {
           MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || MemberNameTb.Text == "" || GenderCb.Text == "" || PNoTb.Text == "" || AgeTb.Text == "" || TimeTb.Text == "" || AmountTb.Text == "") 
            {
                MessageBox.Show(" Select The Member Need To Be Deleted/Updated");
            }
            else
            {
                try
                {
                    con.Open();
                    String query = "Update MemberTbl  set MName='" + MemberNameTb.Text + "',MPhone='" + PNoTb.Text + "',MGen='" + GenderCb.Text + "',MAge=" + AgeTb.Text + ",MAmount=" + AmountTb.Text + ",MTiming='" + TimeTb.Text + "'Where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Successfully ");
                    con.Close();
                    Populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
    }
}
