using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace MMSIS.UL
{
    public static class Validator
    {

        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
        public static bool IsPostalCode(TextBox textBox, string name)
        {

            // The following Regex tests for a valid formatted US zip code (5 digit or 5 digit hyphin 4 digit, and Canadain postal code

       Regex postalCodeRegex = new Regex("^.*(\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}).*$"
             , RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant);

            Match m = postalCodeRegex.Match(textBox.Text);
            if (m.Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a valid postal code.", "Entry Error");
                textBox.Focus();
                return false;
            }

            

        }
    }
}