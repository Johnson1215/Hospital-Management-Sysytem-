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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void receptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pathologyDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visitorsModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            VData_View VDV = new VData_View();
            VDV.Show();



        }

        private void visitorsModuleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            VisitorsModule VM = new VisitorsModule();
            VM.Show();
        }

        private void hospitalInformationManagementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void postalModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Postal_Module PM = new Postal_Module();
            PM.Show();
        }

        private void postalModuleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void complaintsModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Complaints_Module CM = new Complaints_Module();
            CM.Show();


        }

        private void complaintModulePatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Complaint_Module_Patients CMP = new Complaint_Module_Patients();
            CMP.Show();
        }

        private void complaintsModuleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            Complain_Module_Admin CMA = new Complain_Module_Admin();
            CMA.Show();
        }

        private void appoinmentModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Appointments_Module AM = new Appointments_Module();
            AM.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appoinmentModuleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            Appoinment_Module_Patient AMP = new Appoinment_Module_Patient();
            AMP.Show();
                
                
        }

        private void appoinmentModuleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Show();
            Appoinment_Record_Admin AMA = new Appoinment_Record_Admin();
            AMA.Show();
        }

        private void userModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Users_Module UM = new Users_Module();
            UM.Show();
        }

        private void reportModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            Reports R = new Reports();
            R.Show();
        }
    }
}
