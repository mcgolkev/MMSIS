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
        
        private frmAddContact optionsInstance = null;


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

            if (optionsInstance == null || !optionsInstance.Visible)
            {
                optionsInstance = new frmAddContact();
                optionsInstance.Show();
            }
            optionsInstance.BringToFront();

            //Form newForm = new frmAddContact();
            //newForm.Parent = this;
            //newForm.Show();
            //this.WindowState = FormWindowState.Normal;
        }
    }
}
