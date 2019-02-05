using System;
using System.Linq;
using System.Windows.Forms;

namespace CA2_Calculator
{
    public partial class CalculatorForm : Form
    {
        double arg1 = 0.0;
        double arg2 = 0.0;
        double? result = 0.0;
        string operation = "";
        bool equalsJustClicked = false;
        bool twoArgOperatorJustClicked = false;
        bool singleArgOperatorJustClicked = false;
        AngleType angleType = AngleType.Deg;
        Calculator calc = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        // Single method for click action of all numbers
        private void number_click(object sender, EventArgs e)
        {
            Button numberBtn = (Button)sender;

            bool isDouble = double.TryParse(lblResult.Text, out double num);
            if (!isDouble || double.IsInfinity(num) || double.IsNaN(num))
            {
                btnClear_Click(sender, e);
            }

            if (equalsJustClicked)
            {
                btnClear_Click(sender, e);
                lblResult.Text = numberBtn.Text;
            }
            else if(lblResult.Text == "0" || lblResult.Text == Math.PI.ToString() || twoArgOperatorJustClicked)
            {
                lblResult.Text = numberBtn.Text;
            }
            else
            {
                lblResult.Text += numberBtn.Text;
            }

            ResetJustClickedBooleans();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            Button btnPoint = (Button)sender;

            bool isDouble = double.TryParse(lblResult.Text, out double num);
            if ( !isDouble || double.IsInfinity(num) || double.IsNaN(num))
            {
                btnClear_Click(sender, e);
            }

            if (equalsJustClicked || twoArgOperatorJustClicked || singleArgOperatorJustClicked)
            {
                btnClear_Click(sender, e);
                lblResult.Text = "0" + btnPoint.Text;
                ResetJustClickedBooleans();
            }
            else if ( !lblResult.Text.Contains(".") )
            {
                lblResult.Text += btnPoint.Text;
            }
        }

        private void ResetJustClickedBooleans()
        {
            equalsJustClicked = false;
            twoArgOperatorJustClicked = false;
            singleArgOperatorJustClicked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            lblLastInput.Text = "";
            ResetFields();
        }

        private void btnReverseSign_Click(object sender, EventArgs e)
        {
            bool isDouble = double.TryParse(lblResult.Text, out double num);
            if (!isDouble || double.IsInfinity(num) || double.IsNaN(num))
            {
                btnClear_Click(sender, e);
                return;
            }

            if (lblResult.Text != "0")
            {
                if (equalsJustClicked || twoArgOperatorJustClicked || singleArgOperatorJustClicked)
                {
                    lblLastInput.Text = "";
                    ResetFields();
                }

                if (lblResult.Text.First() == '-')
                    lblResult.Text = lblResult.Text.Substring(1);
                else
                    lblResult.Text = "-" + lblResult.Text;
            }
            //ResetJustClickedBooleans();
        }

        private void ResetFields()
        {
            arg1 = 0.0;
            arg2 = 0.0;
            result = 0.0;
            operation = "";
            ResetJustClickedBooleans();
        }

        // For single argument operators (to show result without having to press = sign)
        private void operator_OneArg_click(object sender, EventArgs e)
        {
            Button operatorBtn = (Button)sender;
            operation = operatorBtn.Text;

            bool isDouble = double.TryParse(lblResult.Text, out arg1);
            if (!isDouble)
            {
                InvalidInput();
                return;
            }

            switch (operation)
            {
                case "cos":
                case "sin":
                case "tan":
                case "√":
                case "³√":
                    lblLastInput.Text = operation + "(" + lblResult.Text + ") =";
                    break;
                case "x²":
                    lblLastInput.Text = lblResult.Text + "² =";
                    break;
                case "x³":
                    lblLastInput.Text = lblResult.Text + "³ =";
                    break;
                case "n!":
                    lblLastInput.Text = lblResult.Text + "! =";
                    break;
                default:
                    lblLastInput.Text = lblResult.Text + " " + operation + " =";
                    break;
            }
            
            getOneArgResult();

            if (result == null)
            {
                InvalidInput();
                return;
            }
            else {
                lblResult.Text = result.ToString();
            }

            equalsJustClicked = false;
            twoArgOperatorJustClicked = false;
            singleArgOperatorJustClicked = true;
        }

        private void InvalidInput()
        {
            lblResult.Text = "Invalid Input";
            ResetFields();
        }

        private void getOneArgResult()
        {
            switch (operation)
            {
                case "cos": result = (angleType == AngleType.Deg) ? calc.CosFromDeg(arg1) : calc.CosFromRad(arg1); break;
                case "sin": result = (angleType == AngleType.Deg) ? calc.SinFromDeg(arg1) : calc.SinFromRad(arg1); break;
                case "tan": result = (angleType == AngleType.Deg) ? calc.TanFromDeg(arg1) : calc.TanFromRad(arg1); break;
                case "x²":  result = calc.Square(arg1);         break;
                case "x³":  result = calc.Cube(arg1);           break;
                case "√":   result = calc.SquareRoot(arg1);     break;
                case "³√":  result = calc.CubeRoot(arg1);       break;
                case "n!":  result = calc.Factorial(arg1);      break;                
                default:    result = arg1;                      break;
            }            
        }

        // For click action on double argument operations, i.e. +, -, ×, ÷
        private void operator_TwoArg_click(object sender, EventArgs e)
        {
            Button operatorBtn = (Button)sender;
            operation = operatorBtn.Text;
            arg1 = double.Parse(lblResult.Text);
            lblLastInput.Text = lblResult.Text + " " + operation;
            
            equalsJustClicked = false;
            twoArgOperatorJustClicked = true;
            singleArgOperatorJustClicked = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (equalsJustClicked && operation == "")
            {
                return;
            }
            else if (equalsJustClicked)
            {
                arg1 = (double)result;
                lblLastInput.Text = arg1.ToString() + " " + operation;
            }
            else
            {
                bool isDouble = double.TryParse(lblResult.Text, out arg2);
                if ( !isDouble)
                {
                    InvalidInput();
                    return;
                }
            }
            
            switch (operation)
            {
                case "+":   result = calc.Add(arg1, arg2);          break;
                case "-":   result = calc.Subtract(arg1, arg2);     break;
                case "×":   result = calc.Multiply(arg1, arg2);     break;
                case "÷":   result = calc.Divide(arg1, arg2);       break;
                default:
                    result = arg2;
                    lblLastInput.Text = lblResult.Text + " =";
                    lblResult.Text = result.ToString();
                    equalsJustClicked = true;
                    return;
            }

            lblResult.Text = result.ToString();
            lblLastInput.Text += " " + arg2.ToString() + " =";
            equalsJustClicked = true;
        }

        private void btnEraseLeft_Click(object sender, EventArgs e)
        {
            lblLastInput.Text = "";
            arg1 = 0.0;
            arg2 = 0.0;
            result = 0.0;

            if (lblResult.Text.Length <= 1)
            { 
                lblResult.Text = "0";
            }
            else
            { 
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }

            ResetJustClickedBooleans();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            lblResult.Text = Math.PI.ToString();
        }

        // Cycles the input mode for the Sin, Cos and Tan operations between Degrees & Radians
        private void lblAngleType_Click(object sender, EventArgs e)
        {
            if (lblAngleType.Text == "Deg")
            {
                lblAngleType.Text = "Rad";
                angleType = AngleType.Rad;
            }
            else
            {
                lblAngleType.Text = "Deg";
                angleType = AngleType.Deg;
            }
        }
    }
}
