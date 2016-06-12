using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Co_operative_project
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        string str;
        SqlDataAdapter da;
        DataSet ds;


        private void Search_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Server=LAXMAN-PC\\SQLEXPRESS;Database=Cooperative_Login;Integrated Security=True");
                con.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.Show();
            this.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Member_Register reg = new Member_Register();
            reg.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login lout = new Login();
            lout.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewUser lreg = new NewUser();
            lreg.Show();
            this.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Member_Register reg = new Member_Register();
            reg.Show();
            this.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Login lout = new Login();
            lout.Show();
            this.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.Show();
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)      //this is used for validating i.e user can insert only character asID
            {
                MessageBox.Show("ID consist only number");
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false)      //this is used for validating i.e user can insert only character as first name
            {
                MessageBox.Show("Name consist only character");
                e.Handled = true;
            }
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

        private void button5_Click_2(object sender, EventArgs e)
        {
            Search srch = new Search();
            srch.Show();
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

        private void button4_Click_2(object sender, EventArgs e)
        {
            Member_Register reg = new Member_Register();
            reg.Show();
            this.Visible = false;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            NewUser lreg = new NewUser();
            lreg.Show();
            this.Visible = false;
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            Login lout = new Login();
            lout.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str="Select rid,name,middlename,dob,lastname,sex,nationality,address from regs where rid='"+sid.Text+"' and name='"+sname.Text+"'";
            cmd = new SqlCommand(str, con);
            da=new SqlDataAdapter(str,con);
            ds=new DataSet();
            da.Fill(ds,"regs");
            dataGridView1.DataSource=ds.Tables[0];
        
                
            }

        }


    }

