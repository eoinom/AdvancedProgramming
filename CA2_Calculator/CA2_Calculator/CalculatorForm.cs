using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA2_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            Button numberBtn = (Button)sender;
            if (lblResult.Text == "0")
                lblResult.Text = numberBtn.Text;
            else
                lblResult.Text += numberBtn.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            Button btnPoint = (Button)sender;
            if ( !lblResult.Text.Contains(".") )
                lblResult.Text += btnPoint.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void btnReverseSign_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "0")
            {
                if (lblResult.Text.First() == '-')
                    lblResult.Text = lblResult.Text.Substring(1);
                else
                    lblResult.Text = "-" + lblResult.Text;
            }
        }

    }
}
