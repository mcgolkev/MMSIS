using MMSIS.DL;
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
    public partial class frmClientDetail : Form
    {
        string clientId;
        Customer customer;

        public frmClientDetail(string ClientId)
        {
            InitializeComponent();
            clientId = ClientId;
        }

        private void frmClientDetail_Load(object sender, EventArgs e)
        {
            try
            {
                    customer = CustomerDb.GetCustomer(clientId);

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
            txtClientFn.Text = customer.ClientFn;
            txtClientLn.Text = customer.ClientLn;
            //txtClientLastActivity.Text = customer.ClientLastActivity.ToString();
            txtClientId.Text = customer.ClientId.ToString();
            txtClientCreateDate.Text = customer.ClientCreateDate.ToString();
           // txtInputClientId.Text = "";
        }

    }
}
