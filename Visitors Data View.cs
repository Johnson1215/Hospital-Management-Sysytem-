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
    public partial class VData_View : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public VData_View()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from VisitorsModule";//[add database table name]
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];//[note – not text name properties add desing properties name]
            Con.Close();

        }
        private void Data_View_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Purpose1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            VName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Phone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            IDCardNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            // dateTimePicker1.Text = VisitorsView.SelectedRows[5].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Invalid Serial no");
            else
            {
                Con.Open();
                string query = "update VisitorsModule set Purpose1 ='" + Purpose1.Text + "', VName = ' " + VName.Text + " ',Phone = '" + Phone.Text + "',IDCardNo = '" + IDCardNo.Text + "', Date = '" + dateTimePicker1.Text + "' , InTime = '" + textBox1.Text + "' , OutTime = '" + textBox2.Text + "' , Note = '" + richTextBox1.Text + "' where Serialno = '" + textBox3.Text + "'  ";
                //[note – not text name properties add desing properties name], DocId = ' " + Docid.Text + "' [note – database colum name]");

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Updated");

                Con.Close();
                populate();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")//[note – database colum name]

                MessageBox.Show("Enter the Serial no");

            else

            {
                Con.Open();
                string query = "delete from VisitorsModule where Serialno = " + textBox5.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");

                Con.Close();
                populate();
            }
        }

        private void VName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" )
                MessageBox.Show("Invalid Serial no");
            else
            {
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Purpose1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                VName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Phone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                IDCardNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                // dateTimePicker1.Text = VisitorsView.SelectedRows[5].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
                MessageBox.Show("Invalid Serial no");
            else
            {
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Purpose1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                VName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Phone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                IDCardNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                // dateTimePicker1.Text = VisitorsView.SelectedRows[5].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                populate();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

