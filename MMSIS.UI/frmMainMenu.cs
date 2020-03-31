using System;
using System.Windows.Forms;

namespace MMSIS.UI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        
        private frmAddContact AddContactInstance = null;
        private frmAdmin AdminInstance = null;



        /*
        private void btnSearchClient_Click_1(object sender, EventArgs e)
        {
            Form newForm = new ClientSearch();
            newForm.MdiParent = this;
            newForm.Show();
            //this.WindowState = FormWindowState.Normal;
        }
        */

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form newForm = new frmAddVessel();
            newForm.MdiParent = this;
            newForm.Show();
            //this.WindowState = FormWindowState.Normal;

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Form newForm = new frmAddContact();
            newForm.MdiParent = this;
            newForm.Show();
            //this.WindowState = FormWindowState.Normal;

        }
        /*
        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            Form newForm = new frmSearchClients();
            newForm.MdiParent = this;
            newForm.Show();
           // this.WindowState = FormWindowState.Normal;

        }
        */


        private void mnuAddClient_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuClientAdd_Click(object sender, EventArgs e)
        {

            if (AddContactInstance == null || !AddContactInstance.Visible)
            {
                AddContactInstance = new frmAddContact();
                AddContactInstance.Show();
            }
            AddContactInstance.BringToFront();

            //Form newForm = new frmAddContact();
            //newForm.Parent = this;
            //newForm.Show();
            //this.WindowState = FormWindowState.Normal;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AdminInstance == null || !AdminInstance.Visible)
            {
                AdminInstance = new frmAdmin();
                AdminInstance.Show();
            }
            AdminInstance.BringToFront();

        }
    }
}
