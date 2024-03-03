using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            validateForm();
        }

        private bool validateForm()
        {
            bool output = true;

            int placeNumber = 0;

            decimal prizeAmount = 0;

            int pricePercentage = 0;

            bool pricePercentageValid = int.TryParse(prizePercentageValue.Text, out pricePercentage);

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);

            PlaceNumberErrorProvider.SetError(placeNumberValue, String.Empty);
            PrizeAmountErrorProvider.SetError(prizeAmountValue, String.Empty);
            PlaceNameErrorProvider.SetError(placeNameValue, String.Empty);
            PrizePercentageErrorProvider.SetError(prizePercentageValue, String.Empty);


            placeNumberValue.TextChanged +=
                (sender, e) => TxtChanged(sender, e, placeNumberValue, PlaceNumberErrorProvider);

            placeNameValue.TextChanged +=
                (sender, e) => TxtChanged(sender, e, placeNameValue, PlaceNameErrorProvider);

            prizeAmountValue.TextChanged +=
                (sender, e) => TxtChanged(sender, e, prizeAmountValue, PrizeAmountErrorProvider);

            void TxtChanged(object sender, EventArgs e, TextBox value, ErrorProvider error)
            {
                error.SetError(value, String.Empty);
            }


            if (!int.TryParse(placeNumberValue.Text, out placeNumber) || placeNumber < 1)
            {
                PlaceNumberErrorProvider.SetError(placeNumberValue, "invalid Place Number Provided");

                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                PlaceNameErrorProvider.SetError(placeNameValue, "Place Name should not be Empty");
                output = false;
            }


            if (!prizeAmountValid || !pricePercentageValid)
            {
                output = false;
            }


            if (prizeAmount < 1 && pricePercentage < 1)
            {
                output = false;
            }

            if (pricePercentage < 0 || pricePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}