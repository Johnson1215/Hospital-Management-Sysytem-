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
    public partial class Received_Postal_Record : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Received_Postal_Record()
        {
            InitializeComponent();
        }
    
    void populate()
    {
        Con.Open();
        string query = "select * from ReceivedPostalRecords";//[add database table name]
        SqlDataAdapter da = new SqlDataAdapter(query, Con);
        SqlCommandBuilder builder = new SqlCommandBuilder(da);
        var ds = new DataSet();
        da.Fill(ds);
        dataGridView1.DataSource = ds.Tables[0];//[note – not text name properties add desing properties name]
        Con.Close();
    }

        private void RDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Received_Postal_Record_Load(object sender, EventArgs e)
        {
            RDate.Text = DateTime.Now.ToLongTimeString();
            populate();
        }

        private void RAttach_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog rdig = new OpenFileDialog();
            if (rdig.ShowDialog() == DialogResult.OK)
            {

                string name = rdig.FileName.ToString();
                RAttach.Text = name;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
            Recived_Postal_view RPV = new Recived_Postal_view();
            RPV.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (From1.Text == "" || ReferenceNumber.Text == "" || FromAddress.Text == "" || Note1.Text == "" || ToName.Text == "" || RDate.Text == "" || RAttach.Text == "")
                MessageBox.Show("Empty Record");
            else
            {

                Con.Open();
                string query = "insert into ReceivedPostalRecords values('" + From1.Text + "','" + ReferenceNumber.Text + "', '" + FromAddress.Text + "', '" + Note1.Text + "','" + ToName.Text + "','" + RDate + "','" +RAttach.Text + "')";

                SqlCommand Cmd = new SqlCommand(query, Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Added");

                Con.Close();
                populate();
                


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            From1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ReferenceNumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            FromAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Note1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ToName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            //RDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            RAttach.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (From1.Text == "" || ReferenceNumber.Text == "" || FromAddress.Text == "" || Note1.Text == "" || ToName.Text == "" || RDate.Text == "" || RAttach.Text == "")
            
            MessageBox.Show("Enter Reference no");
            else
            {

                Con.Open();
               string query = "update ReceivedPostalRecords set From1 = '" + From1.Text + "', FromAddress = ' " + FromAddress.Text + " ',Note = '" + Note1.Text + "', ToName= '" + ToName.Text + "', Date = '" + RDate.Text+ "' , Attachment = '" + RAttach.Text + "'  where Referenceno = "+ ReferenceNumber.Text + " ";
                //[note – not text name properties add desing properties name], DocId = ' " + Docid.Text + "' [note – database colum name]");

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Updated");

                Con.Close();
                populate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // if (ReferenceNumber.Text == "")
               // MessageBox.Show("Enter the value");
            
              //  else

           // { 

                //    From1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
              //  ReferenceNumber.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
              //  FromAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
              //  Note1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
              //  ToName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                //RDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
              //  RAttach.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
               
           // }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ReferenceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ReferenceNumber.Text == "")//[note – database colum name]

                MessageBox.Show("Shoud be Enter Referencce No");

            else

            {
                Con.Open();
                string query = "delete from ReceivedPostalRecords where Referenceno =" + ReferenceNumber.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");
                Con.Close();
                populate();
            }
        }
    }
}
