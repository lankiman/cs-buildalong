﻿using System;
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

            PlaceNumberErrorProvider.SetError(placeNumberValue, String.Empty);
            PlaceNameErrorProvider.SetError(placeNameValue, String.Empty);
            PrizeAmountErrorProvider.SetError(prizeAmountValue, String.Empty);

            if (!int.TryParse(placeNumberValue.Text, out placeNumber))
            {
                PlaceNumberErrorProvider.SetError(placeNumberValue, "invalid Place Number Provided");

                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                PlaceNameErrorProvider.SetError(placeNameValue, "Place Name should not be Empty");
                output = false;
            }

            if (!decimal.TryParse(prizeAmountValue.Text, out prizeAmount))
            {
                PrizeAmountErrorProvider.SetError(prizeAmountValue, "Empty or Invalid Prize Amount");
                output = false;
            }


            return output;
        }
    }
}