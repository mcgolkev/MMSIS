using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMSIS.DL;

namespace MMSIS.UI
{
    public partial class frmDeleteContactType : Form
    {
        public frmDeleteContactType()
        {
            InitializeComponent();
        }


        private void frmDeleteContactType_Load(object sender, EventArgs e)
        {
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //capture selected item of contact type highlighted to be deleted

            string  selectedContactType = "";
            selectedContactType = lstContactType.GetItemText(lstContactType.SelectedItem);
            if (selectedContactType == "")
            {
                MessageBox.Show("No Contact Type selected.");
                return;
            }

            //check to see if contact type is currently being used and, therefore, cannot be delelted
            try
            {
                CkContactTypeExits = ContactDb.GetContactTypes(selectedContactType);
                if (CkContactTypeExits != 0)
                    {
                    MessageBox.Show("Cannot delete '" + selectedContactType + "' contact type because " +
                        "it is currently assigned to a contact.");
                    return;
                    }
            }
            catch
            {
                MessageBox.Show("Database Error, contact types are not available.  " +
                    "Contact administrator");
                return;
            }

            //Attempt to delete contact type from database
            try
            {
                dbDeleteSuccessful = ContactDb.DeleteContactType(selectedContactType);

                if (dbDeleteSuccessful == 0)
                {
                    MessageBox.Show("Database exception, contact type has " +
                        "not been deleted. Contact administrator.");
                    return;
                }
                else
                {
                    MessageBox.Show("Contact Type Deleted.");
                    loadFormData();
                }
            }
            catch
            {
                MessageBox.Show("Database Error, contact types are not available.  " +
                    "Contact administrator");
                return;
            }
            

        }
        
        int dbDeleteSuccessful;
        int CkContactTypeExits;
    }
}
