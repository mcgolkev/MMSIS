using System;
using System.Windows.Forms;
using MMSIS.DL;
using MMSIS.UL;

namespace MMSIS
{
    public partial class ClientSearch : Form
    {
        string clientId;

        public Customer customer;


        public ClientSearch()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    clientId = txtInputClientId.Text;
                    customer = CustomerDb.GetCustomer(clientId);

                    DisplayCustomer();

                }
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
            txtClientFn.Text = customer.ClientFn;
            txtClientLn.Text = customer.ClientLn;
            txtClientLastActivity.Text = customer.ClientLastActivity.ToString();
            txtClientId.Text = customer.ClientId.ToString();
            txtClientCreateDate.Text = customer.ClientCreateDate.ToString();
            txtInputClientId.Text = "";
        }


        private bool IsValidData()
        {
            return Validator.IsPresent(txtInputClientId, "Client ID"); //&&
               // Validator.IsDecimal(txtInputClientId, "Client ID");
        }

    }
}