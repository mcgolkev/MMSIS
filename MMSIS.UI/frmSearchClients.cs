// ===============================
// AUTHOR     :Kevin McGoldrick
// CREATE DATE     :2017
// PURPOSE     :This form initially lists all clients in a list box.  The user
//              can then double click on a listed client and will be brought
//              to a modal client detail screen where the record and can be
//              updated or deleted.
//              User can also input last name search parameter to limit search
//              results for fasting record location.
// SPECIAL NOTES:
// ===============================
// Change History:
//
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
    public partial class frmSearchClients : Form
    {
        public frmSearchClients()
        {
            InitializeComponent();
        }
        //======================== Properties ============================================================
        string searchArg;
        public DataTable dataTable;
        //=================================================================================================

            //============================== User has entered data to search for client record ======================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(lstCustomerResults.SelectedIndex);
            System.Diagnostics.Debug.WriteLine(lstCustomerResults.SelectedItem);
            System.Diagnostics.Debug.WriteLine(lstCustomerResults.SelectedValue);

            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchArg.Text)) // Returns ALL CLIENTS if no search arg or space input to search arg
                {
                    dataTable = CustomerDb.GetAllCustomers();  // GET ALL CLIENTS

                    var lst = new List<String>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        lst.Add(row["ClientLn"].ToString() + ", " + row["ClientFn"].ToString() +
                            ", " + row["ClientCreateDate"].ToString());
                    }

                    lstCustomerResults.DataSource = null; // reset list box data source
                    lstCustomerResults.Items.Clear();  // clear listbox items in display
                    txtSearchArg.Text = "";  //
                    lstCustomerResults.DataSource = lst;  // set list box data source
                    txtSearchArg.Focus();  //  set focus to search argument input field

                }

                else // returns search results based on VALID SEARCH INPUT parameter
                {
                    searchArg = txtSearchArg.Text.ToString();
                    dataTable = CustomerDb.GetCustomerXLastName(searchArg); // Get clients BASED SEARCH PARAMETER INPUT BY USER 

                    var lst = new List<String>();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        lst.Add(row["ClientLn"].ToString() + ", " + row["ClientFn"].ToString() +
                            ", " + row["ClientCity"].ToString() + ", " + row["ClientState"].ToString());
                    }

                    lstCustomerResults.DataSource = null;
                    lstCustomerResults.Items.Clear();
                    lstCustomerResults.DataSource = lst;
                    txtSearchArg.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "/n" +
                ex.StackTrace, "Exception");
            }
        }
//==============================================================================================================================


//=======================  ON FORM LOAD...  =====================================================================================
        private void frmSearchClients_Load(object sender, EventArgs e)
        {
            // Loads all clients into the form when the form first opens

            dataTable = CustomerDb.GetAllCustomers();  // GET ALL CLIENTS

            var lst = new List<String>();  // create list to hold data table results
            foreach (DataRow row in dataTable.Rows)  // fill list from data table
            {
                lst.Add(row["ClientLn"].ToString() + ", " + row["ClientFn"].ToString() +
                    ", " + row["ClientCreateDate"].ToString());
            }
            lstCustomerResults.Items.Clear();
            lstCustomerResults.DataSource = lst;
        }
//===================  On Mouse double click on customer record, display Client Edit Update window ==============================
        private void lstCustomerResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstCustomerResults.IndexFromPoint(e.Location);  // This code will determine if the double click occured over a selected listbox item
            if (index != System.Windows.Forms.ListBox.NoMatches) //if double click is over a selected list box item, then launch detail screen
            {
                Object ID = dataTable.Rows[lstCustomerResults.SelectedIndex]["ClientId"]; // collect client id for selected record
                var ClientId = (ID.ToString());
                {
                    Form newForm = new frmClientDetail(ClientId);  // open client detail form using clientId as SP parameter
                    newForm.MdiParent = this.ActiveMdiChild;
                    newForm.ShowDialog();
                }
            }


        }
    }
}
