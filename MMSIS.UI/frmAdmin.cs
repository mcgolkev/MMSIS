using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMSIS.DL;

namespace MMSIS.UI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();

            }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            loadFormData();
            
        }

        private void addContactTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmAddContactType();  // open add contact type form
            newForm.MdiParent = this.ActiveMdiChild;
            newForm.ShowDialog();
            loadFormData();
        }

        private void loadFormData()
        {
            try
            {
                var dataTable = ContactDb.GetAllContactTypes();  // GET ALL CONTACTS
                var lst = new List<String>();
                foreach (DataRow row in dataTable.Rows)
                {
                    lst.Add(row["ContactType"].ToString());
                }
                lstContactType.DataSource = lst;

            }
            catch
            {
                MessageBox.Show("Database Error, contact types are not available.  " +
                    "Contact administrator");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteContactTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmDeleteContactType();  // open add contact type form
            newForm.MdiParent = this.ActiveMdiChild;
            newForm.ShowDialog();
            loadFormData();
        }
    }

}

