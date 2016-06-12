using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Co_operative_project
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        string str;

        private void button9_Click(object sender, EventArgs e)
        {

            str = "Insert into aregs values(@RegisterID,@Date,@DepositAmount,@InterestRate,@Total)";
           // str = "Insert into aregs values('" + arid.Text + "','" + datedpt.Value.Date + "','" + damt.Text + "','"+null+"','"+null+"')";
            cmd = new SqlCommand(str, con);
          

             cmd.Parameters.AddWithValue("@RegisterID", arid.Text);
             cmd.Parameters.AddWithValue("@Date", datedpt.Value.Date);
             cmd.Parameters.AddWithValue("@DepositAmount", damt.Text);
             cmd.Parameters.AddWithValue("@InterestRate",1);
             cmd.Parameters.AddWithValue("@Total", 1);
            cmd.ExecuteNonQuery();
             MessageBox.Show("Inserted successfully");
           arid.Text="";
           
           damt.Text = "";



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            con = new SqlConnection("Server=LAXMAN-PC\\SQLEXPRESS;Database=Cooperative_Login;Integrated Security=True");
            con.Open();
        }

        private void datedpt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void arid_TextChanged(object sender, EventArgs e)
        {

        }

        private void damt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_WorkingPage mw = new Main_WorkingPage();
            mw.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detail det = new Detail();
            det.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loan lo = new Loan();
            lo.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Member_Register reg = new Member_Register();
            reg.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewUser lreg = new NewUser();
            lreg.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login lout = new Login();
            lout.Show();
            this.Visible = false;
        }
    }
}
