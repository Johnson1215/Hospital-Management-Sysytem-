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
    public partial class Complain_Module_Admin : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Complain_Module_Admin()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void Complain_Module_Admin_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToLongDateString();
            Populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")//[note – database colum name]

                MessageBox.Show("Shoud be Enter Complain no");

            else

            {
                Con.Open();
                string query = "delete from Complain where ComplainId =" + textBox7.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");
                Con.Close();
                Populate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update Complain set ComplainType ='" + comboBox1.Text + "', ComplainBy = ' " + textBox1.Text + " ',Phoneno = '" + textBox2.Text + "',Date = '" + textBox3.Text + "', Description = '" + richTextBox1.Text + "' , ActionTake = '" + textBox4.Text + "' , Note = '" + textBox5.Text + "' , Attachment = '" + textBox6 + "' where ComplainId = " + textBox7.Text + "  ";
            //[note – not text name properties add desing properties name], DocId = ' " + Docid.Text + "' [note – database colum name]");

            SqlCommand cmd = new SqlCommand(query, Con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record  Successfully Updated");

            Con.Close();
            Populate();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
