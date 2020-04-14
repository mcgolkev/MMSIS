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
using MMSIS.UL;

namespace MMSIS.UI
{
    public partial class frmAddContactType : Form
    {
        public frmAddContactType()
        {
            InitializeComponent();
        }
        
        public event EventHandler ButtonClicked;

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void frmAddContactType_Load(object sender, EventArgs e)
        {
            txtContactType.Focus();
            AcceptButton = btnAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //If the data is valid, then initialize fields to string or int and instanciate Customer object
                    contactType = (txtContactType.Text.ToUpper());

                    try
                    {
                        DataTable dataTable = ContactDb.GetAllContactTypes();

                        // get list of all contact types
                        var lst = new List<String>();

                        foreach (DataRow row in dataTable.Rows)  // Check to see if the contact type entered already exists
                        {
                            if (row["ContactType"].ToString() == contactType)
                            {
                                MessageBox.Show("Contact Type " + contactType + " already exists, please re-enter.");
                                txtContactType.Text = "";
                                txtContactType.Focus();
                                return;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Database Error, contact types are not available.  " +
                            "Contact administrator");
                        txtContactType.Text = "";
                        txtContactType.Focus();
                    }

                    //Attempt to add new contact type to database
                    dbUpdateSuccessful = ContactDb.AddContactType(contactType);

                    if (dbUpdateSuccessful == 0)
                    {
                        txtContactType.Text = "";
                        txtContactType.Focus();
                        MessageBox.Show("Database exception, contact type has " +
                            "not been added. Contact administrator.");
                    }
                    else
                    {
                        txtContactType.Text = "";
                        txtContactType.Focus();
                        MessageBox.Show("Contact Type Added.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "/n" +
                    ex.StackTrace, "Exception");
            }




        }
            //============ FORM VALIDATION ===========================================================


            private bool IsValidData()
            {
                // check to see if int input fields are valid input

                return Validator.IsPresent(txtContactType, "Contact Type");
            }

        //===================================================================================



        string contactType;
            int dbUpdateSuccessful;
        
    }
}
