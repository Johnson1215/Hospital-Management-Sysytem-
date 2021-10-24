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
    public partial class VisitorsModule : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public VisitorsModule()
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
            VisitorsView.DataSource = ds.Tables[0];//[note – not text name properties add desing properties name]
            Con.Close();

        }

        private void VisitorsModule_Load(object sender, EventArgs e)
        {

            textBox1.Text = DateTime.Now.ToLongTimeString();
            textBox2.Text = DateTime.Now.ToLongTimeString();

            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || Purpose1.Text == "" || VName.Text == "" || Phone.Text == ""||IDCardNo.Text == ""|| this.dateTimePicker1.Value.ToString("dd/mm/yyyy") == ""|| textBox1.Text == "" || textBox2.Text == ""|| richTextBox1.Text == "")
                MessageBox.Show("Empty Record");
           else
            {

                Con.Open();
                string query = "insert into VisitorsModule values('"+textBox3.Text+"','" + Purpose1.Text + "', '"+VName.Text+"', '"+Phone.Text+"','"+IDCardNo.Text+"','"+this.dateTimePicker1.Value.ToString("dd/mm/yyyy")+ "','" + textBox1.Text + "','" + textBox2.Text+"','"+richTextBox1.Text+"','"+Attachment1.Text+"')";

                SqlCommand Cmd = new SqlCommand(query, Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Added");

                Con.Close();
                populate();


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")//[note – database colum name]

                MessageBox.Show("Shoud be Enter Serial No");

            else

            {
                Con.Open();
                string query = "delete from VisitorsModule where Serialno =" + textBox3.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");
                Con.Close();
                populate();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || Purpose1.Text == "" || VName.Text == "" || Phone.Text == "" || IDCardNo.Text == "" || dateTimePicker1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
               MessageBox.Show("selected Empty data");
            else
            {
                Con.Open();
                string query = "update VisitorsModule set Purpose1 ='" + Purpose1.Text + "', VName = ' " + VName.Text + " ',Phone = '" + Phone.Text + "',IDCardNo = '" + IDCardNo.Text + "', Date = '" + dateTimePicker1.Text + "' , InTime = '" + textBox1.Text + "' , OutTime = '" + textBox2.Text + "' , Note = '" + richTextBox1.Text + "' where Serialno = " + textBox3.Text + "  ";
                //[note – not text name properties add desing properties name], DocId = ' " + Docid.Text + "' [note – database colum name]");

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Updated");

                Con.Close();
                populate();
            }
        }

       // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            //Purpose.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //VName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
            Visitors_View VV = new Visitors_View();
            VV.Show();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            textBox3.Text = VisitorsView.SelectedRows[0].Cells[0].Value.ToString();
            Purpose1.Text = VisitorsView.SelectedRows[0].Cells[1].Value.ToString();
            VName.Text = VisitorsView.SelectedRows[0].Cells[2].Value.ToString();
            Phone.Text = VisitorsView.SelectedRows[0].Cells[3].Value.ToString();
            IDCardNo.Text = VisitorsView.SelectedRows[0].Cells[4].Value.ToString();
           // dateTimePicker1.Text = VisitorsView.SelectedRows[5].Cells[0].Value.ToString();
            textBox1.Text = VisitorsView.SelectedRows[0].Cells[6].Value.ToString();
            textBox2.Text = VisitorsView.SelectedRows[0].Cells[7].Value.ToString();
            richTextBox1.Text = VisitorsView.SelectedRows[0].Cells[8].Value.ToString();
            Attachment1.Text = VisitorsView.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void Note_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            if(dig.ShowDialog() == DialogResult.OK)
            {

                string picpath = dig.FileName.ToString();
                Attachment1.Text = picpath;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Attachment1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
