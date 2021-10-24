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
    public partial class Recived_Postal_view : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Recived_Postal_view()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Recived_Postal_view_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
