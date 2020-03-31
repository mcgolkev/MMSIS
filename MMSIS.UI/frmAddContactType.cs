using MMSIS.DL;
using MMSIS.UL;
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
    public partial class frmAddContactType : Form
    {
        public frmAddContactType()
        {
            InitializeComponent();
            this.ActiveControl = btnAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //If the data is valid, then initialize fields to string or int and instanciate Customer object
                    contactType = (txtContactType.Text);

                    //Invoke AddContact Db stored procedure and pass in contact object
                    dbUpdateSuccessful = ContactDb.AddContactType(contactType);

                    if (dbUpdateSuccessful == 0)
                    {
                        txtContactType.Text = "";
                        MessageBox.Show("Database exception, contact administrator.");
                    }
                    else
                    {
                        txtContactType.Text = "";
                        MessageBox.Show("Contact TYpe Added.");
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

            return Validator.IsPresent(txtContactType, "Contact First Name");                
        }

        //===================================================================================
        string contactType;
        int dbUpdateSuccessful;

    }
}
