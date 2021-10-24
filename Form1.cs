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

namespace Hospital_Management_System
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Con.Open();
            //string query = "insert into SiginTable values(" + name.Text + ",'" + name.Text + "')";

           // SqlCommand cmd = new SqlCommand(query,Con);
           // cmd.ExecuteNonQuery();
            
           // MessageBox.Show("Record  Successfully Added");

           // Con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")

                MessageBox.Show("Empty data");
            else
            {

                //put connection path - database connection
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

                // try to patch the data using adapter
                SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from AccountTable where username ='" + textBox1.Text + "' and Pass = '" + textBox2.Text + "'", Con);
                SqlCommand cmd = new SqlCommand();
                DataTable dt = new DataTable();
                //patching details into tabe result

                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    Home H = new Home();
                    H.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SigUp SU = new SigUp();
            SU.Show();

                
        }
    }
}
