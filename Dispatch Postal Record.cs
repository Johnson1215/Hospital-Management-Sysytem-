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
    public partial class Dispatch_Postal_Record : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Dispatch_Postal_Record()
        {
            InitializeComponent();
        }
        void Populate ()
        {
            Con.Open();
            string query = "select * from DispathPostalRecord ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataset = new DataSet();
            sda.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];

            
            Con.Close();
        
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dname.Text == "" || DReferenceNumber.Text == "" || DFromAddress.Text == "" || DNote1.Text == "" || FromName.Text=="" || DDate.Text =="" )
                MessageBox.Show("Empty record");
            else
            {
                Con.Open();
                string query = "insert into DispathPostalRecord values ('" + Dname.Text + "','" + DReferenceNumber.Text + "','" + DFromAddress.Text + "','" + DNote1.Text + "','" + FromName.Text + "','" + DDate.Text + "','" + DAttach.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                
                Con.Close();
                Populate();
            }
        }

        private void DDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dispatch_Postal_Record_Load(object sender, EventArgs e)
        {
            DDate.Text = DateTime.Now.ToLongDateString();
            Populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog ()== DialogResult.OK)
            {
                string name = ofd.FileName.ToString();
                DAttach.Text = name; 

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (DReferenceNumber.Text == "")//[note – database colum name]

                MessageBox.Show("Shoud be Enter Referencce No");

            else

            {
                Con.Open();
                string query = "delete from DispathPostalRecord where Referenceno =" + DReferenceNumber.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");
                Con.Close();
                Populate();
            }
                
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            
            if (Dname.Text == "" || DReferenceNumber.Text == "" || DFromAddress.Text == "" || DNote1.Text == "" || FromName.Text == "" || DDate.Text == "" || DAttach.Text == "")
                MessageBox.Show("select record");
            else
            {
                Con.Open();
                string query = "update DispathPostalRecord set ToName ='"+Dname.Text+"' , Address = '"+DFromAddress.Text+"' , Note '"+DNote1.Text+"', FromName = '"+Dname.Text+"' ,Date = '"+DDate.Text+"', Attachment = '"+DAttach.Text+"' where = "+DReferenceNumber.Text+" ";
                MessageBox.Show("Updated");


                Con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DReferenceNumber.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Dname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DFromAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            DNote1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            FromName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            DDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            DAttach.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void DFromAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
