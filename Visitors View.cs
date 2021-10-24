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
    public partial class Visitors_View : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Visitors_View()
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisitorsModule VM = new VisitorsModule();
            VM.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisitorsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void Visitors_View_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
