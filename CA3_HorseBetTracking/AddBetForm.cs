using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CA3_HorseBetTracking
{
    public partial class AddBetForm : Form
    {
        public HorseBet newBet { get; set; }

        public AddBetForm()
        {
            InitializeComponent();
        }

        private void txtRaceCourse_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            // Check if the textbox is empty
            if (string.IsNullOrEmpty(txtRaceCourse.Text))
            {
                epError.SetError(txtRaceCourse, "Must have a value");
                cancel = true;
            }
            // Check text is at least 2 characters long
            else if (txtRaceCourse.Text.Length < 2)
            {
                epError.SetError(txtRaceCourse, "Must have a value");
                cancel = true;
            }
            // Check text is not a number
            else if (double.TryParse(txtRaceCourse.Text, out double num))
            {
                epError.SetError(txtRaceCourse, "Cannot be a number");
                cancel = true;
            }
            e.Cancel = cancel;
        }
        private void txtRaceCourse_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtRaceCourse, string.Empty);
        }

        private void dtpBetDate_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            // Check if the date is in the future
            if (dtpBetDate.Value.Date > System.DateTime.Now.Date)
            {
                epError.SetError(dtpBetDate, "Cannot be a date in the future");
                cancel = true;
            }
            e.Cancel = cancel;
        }
        private void dtpBetDate_Validated(object sender, EventArgs e)
        {
            epError.SetError(dtpBetDate, string.Empty);
        }

        private void txtBetAmount_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            const string AMOUNT_PATTERN = @"^[0-9]{0,6}(\.[0-9]{1,2})?$"; 
            Regex reEngine = new Regex(AMOUNT_PATTERN);
            Match match = reEngine.Match(txtBetAmount.Text);

            // Check if an invalid currency amount was entered
            if (!match.Success || txtBetAmount.Text == "" || decimal.Parse(txtBetAmount.Text) <= 0)
            {
                epError.SetError(txtBetAmount, "Must enter a valid currency amount (between 0.01 - 999999.99)");
                cancel = true;
            }
            e.Cancel = cancel;
        }
        private void txtBetAmount_Validated(object sender, EventArgs e)
        {
            epError.SetError(txtBetAmount, string.Empty);
        }

        private void rbWonLost_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;

            // Check if neither radio button has been selected
            if (!rbWon.Checked && !rbLost.Checked)
            {
                epError.SetError(rbLost, "Must select if bet was Won or Lost");
                cancel = true;
            }
            e.Cancel = cancel;
        }

        private void rbWonLost_Validated(object sender, EventArgs e)
        {
            epError.SetError(rbLost, string.Empty);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            if ( this.ValidateChildren(ValidationConstraints.Enabled) )
            {
                decimal betAmount = decimal.Parse(txtBetAmount.Text);
                newBet = new HorseBet(txtRaceCourse.Text, dtpBetDate.Value.Date, betAmount, rbWon.Checked);

                MessageBox.Show("Bet Saved!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }                  
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
