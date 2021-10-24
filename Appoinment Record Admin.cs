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
    public partial class Appoinment_Record_Admin : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Appoinment_Record_Admin()
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
            if (textBox2.Text == "")//[note – database colum name]

                MessageBox.Show("Shoud be Enter Serial No");

            else

            {
                Con.Open();
                string query = "delete from Appoinmentmodule where PatientId =" + textBox2.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");
                Con.Close();
                Populate();
            }
        }

        private void Appoinment_Record_Admin_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
