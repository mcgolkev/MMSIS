using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMSIS.UI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }


        private void btnSearchClient_Click_1(object sender, EventArgs e)
        {
            Form newForm = new ClientSearch();
            newForm.MdiParent = this;
            newForm.Show();
            //this.WindowState = FormWindowState.Normal;
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Form newForm = new frmAddVessel();
            newForm.MdiParent = this;
            newForm.Show();
            //this.WindowState = FormWindowState.Normal;

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Form newForm = new frmAddClient();
            newForm.MdiParent = this;
            newForm.Show();
            //this.WindowState = FormWindowState.Normal;

        }

        private void btnSearchClients_Click(object sender, EventArgs e)
        {
            Form newForm = new frmSearchClients();
            newForm.MdiParent = this;
            newForm.Show();
           // this.WindowState = FormWindowState.Normal;

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
