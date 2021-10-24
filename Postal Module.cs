using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Postal_Module : Form
    {
        public Postal_Module()
        {
            InitializeComponent();
        }

        private void receivedPostalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Received_Postal_Record RPR = new Received_Postal_Record();
            this.Show();
                 
        }

        private void dispatchPostalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Dispatch_Postal_Record DPR = new Dispatch_Postal_Record();
            this.Show();
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void receivedPostalRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            Received_Postal_Record RPR = new Received_Postal_Record();
            RPR.Show();
        }

        private void dispatchPostalRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            Dispatch_Postal_Record DPR = new Dispatch_Postal_Record();
            DPR.Show();
        }
    }
}
