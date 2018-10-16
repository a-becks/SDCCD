using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4_schroder
{
    public partial class Form1 : Form
    {
        DateTime currentDate = DateTime.Today;

        public Form1()
        {
            InitializeComponent();
            txtArrivalDate.Text = currentDate.ToShortDateString();
            txtDepartureDate.Text = currentDate.AddDays(3).ToShortDateString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!isValid()) {
                txtArrivalDate.Focus();
                return;
            }

            const int pricePerNight = 115;
            TimeSpan numberOfNights;
            int totalPrice;

            numberOfNights = DateTime.Parse(txtDepartureDate.Text) - DateTime.Parse(txtArrivalDate.Text);
            totalPrice = numberOfNights.Days * pricePerNight;

            txtPricePerNight.Text = pricePerNight.ToString("c");
            txtNumNights.Text = numberOfNights.Days.ToString();
            txtTotalPrice.Text = totalPrice.ToString("c");    
        }

        private bool isValid()
        {
            bool isValid = true;

            //check if both are valid dates and store dates if successful
            if (!DateTime.TryParse(txtArrivalDate.Text, out DateTime arrivalDate) || !DateTime.TryParse(txtDepartureDate.Text, out DateTime departureDate))
            {
                isValid = false;
                MessageBox.Show("Please enter a valid date in the form MM/DD/YYYY.");
            }

            //make sure departure date is after arrival date
            else if (arrivalDate > departureDate )
            {
                isValid = false;
                MessageBox.Show("Departure must be after arrival date.");
            }

            // make sure reservation is for a future date
            else if (currentDate > arrivalDate)
            {
                isValid = false;
                MessageBox.Show("Please enter a date after today's date.");
            }

            //make sure it is within 5 years of today
            else if (arrivalDate > currentDate.AddYears(5))
            {
                isValid = false;
                MessageBox.Show("Reservations must be within five years of today's date.");
            }
            return isValid;
        }

     }
}
