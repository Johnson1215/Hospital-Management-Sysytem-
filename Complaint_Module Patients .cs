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
    public partial class Complaint_Module_Patients : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Complaint_Module_Patients()
        {
            InitializeComponent();
        }
        void Populate()
        {
            Con.Open();
            string query = "select * from Complain ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Complaint_Module_Patients_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString();
            Populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")

                MessageBox.Show("empty");
            else
            {

                Con.Open();

                string query = "insert into Complain values ('" + textBox7.Text + "','" + comboBox1.Text + "', '" + textBox1.Text + "' , '" + textBox2.Text + "', '" + textBox3.Text + "' , '" + richTextBox1.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "', '" + textBox6.Text + "')";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added");

                Con.Close();
                Populate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string name = ofd.FileName.ToString();
                textBox6.Text = name;
            }
        }
    }
}
