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
        double arg1 = 0.0;
        double arg2 = 0.0;
        string operation = "";
        bool operatorJustClicked = false;
        double? result = 0.0;
        Calculator calc = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            Button numberBtn = (Button)sender;

            if (lblResult.Text == "0" || operatorJustClicked == true)
                lblResult.Text = numberBtn.Text;
            else
                lblResult.Text += numberBtn.Text;

            operatorJustClicked = false;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            Button btnPoint = (Button)sender;

            if ( !lblResult.Text.Contains(".") )
                lblResult.Text += btnPoint.Text;

            operatorJustClicked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            lblLastInput.Text = "";
            operatorJustClicked = false;
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
            operatorJustClicked = false;
        }

        private void operator_TwoArg_click(object sender, EventArgs e)
        {
            Button operatorBtn = (Button)sender;
            operation = operatorBtn.Text;
            arg1 = double.Parse(lblResult.Text);
            lblLastInput.Text = lblResult.Text + " " + operation;
            operatorJustClicked = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            arg2 = double.Parse(lblResult.Text);
            switch (operation)
            {
                case "+":
                    result = calc.Add(arg1, arg2);
                    break;
                case "-":
                    result = calc.Subtract(arg1, arg2);
                    break;
                case "×":
                    result = calc.Multiply(arg1, arg2);
                    break;
                case "÷":
                    result = calc.Divide(arg1, arg2);
                    break;
                default:
                    result = arg2;
                    break;
            }
            lblResult.Text = result.ToString();
        }
    }
}
