using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMSIS.UI;
using MMSIS.DL;
using MMSIS.BL;

    

namespace MMSIS.UI
{
    public partial class frmFindContact : Form
    {
        public frmFindContact()
        {
            InitializeComponent();
        }
        private string srchLastName;
        private void btnFind_Click(object sender, EventArgs e)
        {
            srchLastName = txtSrchLastName.Text;

            try
            {
                var dataTable = ContactDb.GetContactXLastName(srchLastName);  // GET ALL CONTACTS
                var lst = new List<String>();
                foreach (DataRow row in dataTable.Rows)
                {
                    lst.Add(row["ContactFirstName"].ToString() + ", " +  row["ContactLastName"].ToString() +
                        row["ContactCoName"].ToString() + ", " + row["ContactJobTitle"].ToString() + ", " +
                        row["ContactType"].ToString());
                    
                }
                lstSrchResults.DataSource = lst;

            }
            catch
            {
                MessageBox.Show("Database Error, contact types are not available.  " +
                    "Contact administrator");
            }
        }
    }
}
