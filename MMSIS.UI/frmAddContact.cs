// ===============================
// AUTHOR     :Kevin McGoldrick
// CREATE DATE     :2017
// PURPOSE     :This form accepts input to add a new contact
// SPECIAL NOTES:  Only contact First Name and Client Last Name are required to 
//                  create a new client.
// ===============================
// Change History:
// 03/25/20 - Changed concept of client to contact all references
//==================================


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMSIS.DL;
using MMSIS.UL;

namespace MMSIS.UI
{
    public partial class frmAddContact : Form
    {
        public frmAddContact()
        {
            InitializeComponent();
        }
//=====================================================================================

//=========== ON SUBMIT BUTTON CLICKED =====================================================
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //If the data is valid, then initialize fields to string or int and instanciate Customer object
                    contactFirstName = (txtContactFirstName.Text);
                    contactLastName = (txtContactLastName.Text);

                    //Instantiate Contact Object
                    Contact contact = new Contact(contactFirstName,contactFirstName);

                    //Invoke AddContact Db stored procedure and pass in contact object
                    dbUpdateSuccessful = CustomerDb.AddContact(contact);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "/n" +
                    ex.StackTrace, "Exception");
            }

        } // end btn click
//=============================================================================


//================ ON FORM LOAD EVENT =======================================================

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            /* 
              
            Loads all clients into the form when the form first opens

            dataTable = CustomerDb.GetAllUSStates();
            System.Diagnostics.Debug.WriteLine(dataTable.Columns);

            //allows user input to list states that begin wtih the input
            cboState.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboState.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            // fill state combo box with state names from database
            var lst = new List<String>();
            foreach (DataRow row in dataTable.Rows)
            {
                lst.Add(row["LongStateName"].ToString());
            }
            cboState.Items.Clear();
            cboState.DataSource = lst;
            //sets intial values of state combo box and state SP pararamter to "" so defalut
            // value is null if no state is selected by the user.
            cboState.Text = "";
            clientState = "";

    */
        }
        
 //========================================================================================

 //============ FORM VALIDATION ===========================================================


        private bool IsValidData()
        {
            // check to see if int input fields are valid input

            return Validator.IsPresent(txtContactFirstName, "Client First Name") &&
                Validator.IsPresent(txtContactLastName, "Client Last Name");
        }

        //===================================================================================

        //===============================On State Combo Box Selection Changed ============================

            /*
        //  changes the value of the state code SP parameter when/and  if the user selects a state
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object StateAbbreviation = dataTable.Rows[cboState.SelectedIndex]["StateAbbr"];
            var stateAbbreviation = (StateAbbreviation.ToString());
            clientState = stateAbbreviation;
        }

        
        */
        //========================================================================================
        
        DataTable dataTable;
        private string contactFirstName;
        private string contactLastName;
        private int dbUpdateSuccessful;
    }
}

