using MMSIS.DL;
using MMSIS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSIS.UI
{
    public partial class frmContactDetail : Form
    {
        Contact contact;

        public frmContactDetail(Guid ContactId)
        {
            InitializeComponent();
            contactId = ContactId;
        }

        private void frmClientDetail_Load(object sender, EventArgs e)
        {
            try
            {
                    contact = ContactDb.GetContact(contactId);

                    DisplayCustomer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n No Client found \n\n" +
                    ex.GetType().ToString() + "/n" +
                    ex.StackTrace, "Exception");
            }

        }

        public void DisplayCustomer()
        {
            txtContactFirstName.Text = contact.ContactFirstName;
            txtContactLastName.Text = contact.ContactLastName;
            //txtClientLastActivity.Text = customer.ClientLastActivity.ToString();
            txtContactId.Text = contact.ContactId.ToString();
            txtContactCreateDate.Text = contact.ContactCreateDate.ToString();
           // txtInputClientId.Text = "";
        }

        Guid contactId;
    }
}
