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
    public partial class Appoinment_Module_View : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Appoinment_Module_View()
        {
            InitializeComponent();
        }
        void Populate()
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Con.Open();
            // string query = "update Appoinmentmodule ";
            //[note – not text name properties add desing properties name], DocId = ' " + Docid.Text + "' [note – database colum name]");

            // SqlCommand cmd = new SqlCommand(query, Con);

            // cmd.ExecuteNonQuery();

            // MessageBox.Show("Record  Successfully Updated");

            // Con.Close();
            // Populate();
            { 
        }
    }

        private void Appoinment_Module_View_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
