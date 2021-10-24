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
    public partial class Users_Module : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lostm\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Users_Module()
        {
            InitializeComponent();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from Usersmodule";//[add database table name]
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];//[note – not text name properties add desing properties name]
            Con.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Users_Module_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text== "" || textBox7.Text == "" || comboBox2.Text == "" )

                MessageBox.Show("Empty Record");
           else
            {

                Con.Open();
                string query = "insert into Usersmodule values('" + textBox1.Text + "','" + textBox2.Text + "', '" + comboBox1.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox2.Text + "')";

                SqlCommand Cmd = new SqlCommand(query, Con);

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Added");

                Con.Close();
                populate();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")//[note – database colum name]

                MessageBox.Show("Enter ID Card No");

            else

            {
                Con.Open();
                string query = "delete from Usersmodule where Idcardno =" + textBox3.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox2.Text == "")
                MessageBox.Show("selected Empty data");
            else
            {
                Con.Open();
                string query = "update Usermodule set Usersname ='" + textBox1.Text + "', Name = ' " + textBox2.Text + " ',Gender = '" + comboBox1.Text + "',Phoneno = '" + textBox4.Text + "', Dob= '" + textBox6.Text + "' , Address = '" + textBox7.Text + "' , Marriedstatus = '" + comboBox2.Text + "' where Idcardno = ' + textBox3.Text + '  ";
                //[note – not text name properties add desing properties name], DocId = ' " + Docid.Text + "' [note – database colum name]");

                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record  Successfully Updated");

                Con.Close();
                populate();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            

        }
    }
}
