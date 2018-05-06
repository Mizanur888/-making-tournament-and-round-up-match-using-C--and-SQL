using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibarry;

namespace TrckerUI
{
    public partial class Create_Prize : Form
    {
        IPrizeRequester callingFrom;

        public Create_Prize(IPrizeRequester caller)
        {
            InitializeComponent();
            callingFrom = caller;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePriceButton_Click(object sender, EventArgs e)
        {
            if (validateFrom())
            {
               
                PrizeModel model = new PrizeModel(PlaceNumberTextBox.Text, PlaceNameTextBox.Text,
                    PrizeAmountTextBox.Text, pricePercentageTextBox.Text);

                GlobalConfig.connection.createPrize(model);
                callingFrom.prizeComplete(model);

                this.Close();
                //PlaceNumberTextBox.Text = "";
                //PlaceNameTextBox.Text = "";
                //PrizeAmountTextBox.Text = "0";
                //pricePercentageTextBox.Text = "0";
            }
            else {
                MessageBox.Show("This from has invalid information . Please Check and try again");
            }
        }
        private void Valid() {

            PrizeAmountTextBox.Text = "";
            pricePercentageTextBox.Text = "";
        }
        private bool validateFrom() {

            bool output = true;
            int placenumber = 0;

            bool placenumberValidation = int.TryParse(PlaceNumberTextBox.Text, out placenumber);
            if (!placenumberValidation && placenumber < 1) {
                output = false;
            }
            if (PlaceNameTextBox.Text.Length == 0) {
                output = false;
            }
            decimal prizeAmout = 0;
            double prizePercentage = 0;

            bool priceAmoutValid = decimal.TryParse(PrizeAmountTextBox.Text,out prizeAmout);
            bool prizePercentagevalid = double.TryParse(pricePercentageTextBox.Text,out prizePercentage);

            if (prizePercentage <= 0 && prizeAmout <= 0 &&(prizePercentage<0 || prizePercentage >100)) {
                output = false;
            }


            return output;
        }
    }
}
