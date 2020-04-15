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
            //capture index of contact type highlighted to be deleted

            var selectedContactType = "Broker";

            //check to see if contact type is currently being used and, therefore, cannot be delelted
            try
            {
                CkContactTypeExits = ContactDb.GetContactTypes(selectedContactType);
            }
            catch
            {
                MessageBox.Show("Database Error, contact types are not available.  " +
                    "Contact administrator");
            }

            //Attempt to delete contact type from database
            try
            {
                dbDeleteSuccessful = ContactDb.DeleteContactType(contactType);

                if (dbDeleteSuccessful == 0)
                {
                    MessageBox.Show("Database exception, contact type has " +
                        "not been deleted. Contact administrator.");
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
            }
            

        }
        
        int dbDeleteSuccessful;
        int CkContactTypeExits;
        string SelctedContactType;
        string contactType;

    }
}
