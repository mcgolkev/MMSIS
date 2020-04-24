using System;
using MMSIS.BL;
using System.Windows.Forms;

namespace MMSIS.UI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        private void mnuAddClient_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuClientAdd_Click(object sender, EventArgs e)
        {
            {
                Form newForm = new frmAddContact();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form newForm = new frmAdmin();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form newForm = new frmAddVessel();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
