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
    public partial class Appoinment_Module_Patient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Appoinment_Module_Patient()
        {
            InitializeComponent();
        }
        void Populate()
        {
            {
                Con.Open();
                string query = "Select * from Appoinmentmodule";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder SCB = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Con.Close();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox1.Text == "" || this.dateTimePicker2.Value.ToString("hh/mm/ss") == "" || this.dateTimePicker1.Value.ToString("dd/mm/yyyy") == "" || textBox1.Text == "" || comboBox2.Text == "")

                MessageBox.Show("empty");
            else
            {

                Con.Open();

                string query = "insert into Appoinmentmodule values ('" + textBox2.Text + "','" + comboBox1.Text + "','" + this.dateTimePicker2.Value.ToString("hh/mm/ss") + "', '" + this.dateTimePicker1.Value.ToString("dd/mm/yyyy") + "' , '" + textBox1.Text + "', '" + comboBox2.Text + "' )";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Added");

                Con.Close();
                Populate();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Appoinment_Module_Patient_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
