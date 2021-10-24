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
    public partial class SigUp : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");
            
        public SigUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Pass.Text == "" || Username.Text == "" || Email.Text == "")
                MessageBox.Show("Empty Record");
            else
            {

                Con.Open();
                string query = "insert into AccountTable values('" + Pass.Text + "','" + Username.Text + "','" + Email.Text + "')";

                SqlCommand Cmd = new SqlCommand(query, Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Added");

                Con.Close();
            }
        }
    }
}
