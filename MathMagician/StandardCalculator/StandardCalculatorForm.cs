using DataManipulation;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MathMagician
{
    public partial class StandardCalculatorForm : Form
    {
        private NumberHelper _numberHelper;
        private ArithmeticHelper _arithmeticHelper;

        private bool _nextNumberWillReplace;

        public StandardCalculatorForm()
        {
            InitializeComponent();
            _numberHelper = new NumberHelper();
            _arithmeticHelper = new ArithmeticHelper();
        }

        #region Interface Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            _numberHelper.ResetDecimalFlags(true, true);
            _arithmeticHelper.ClearValues();
            tbNumbers.Text = "0";
        }

        private void StandardCalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            var keybindingDictionary = new Dictionary<Keys, Action>()
            {
                { Keys.NumPad0, () => btnZero_Click(sender, e) },
                { Keys.NumPad1, () => btnOne_Click(sender, e) },
                { Keys.NumPad2, () => btnTwo_Click(sender, e) },
                { Keys.NumPad3, () => btnThree_Click(sender, e) },
                { Keys.NumPad4, () => btnFour_Click(sender, e) },
                { Keys.NumPad5, () => btnFive_Click(sender, e) },
                { Keys.NumPad6, () => btnSix_Click(sender, e) },
                { Keys.NumPad7, () => btnSeven_Click(sender, e) },
                { Keys.NumPad8, () => btnEight_Click(sender, e) },
                { Keys.NumPad9, () => btnNine_Click(sender, e) },
                { Keys.Add, () => btnAdd_Click(sender, e) },
                { Keys.Subtract, () => btnSubtract_Click(sender, e) },
                { Keys.Multiply, () => btnMultiply_Click(sender, e) },
                { Keys.Divide, () => btnDivide_Click(sender, e) },
                { Keys.Enter, () => btnEquals_Click(sender, e) },
                { Keys.Decimal, () => btnDecimal_Click(sender, e) },
                { Keys.Delete, () => btnClear_Click(sender, e) }
            };

            keybindingDictionary[e.KeyCode].Invoke();
        }

        #endregion

        #region Helper Methods

        private void PressNumberButton(string number)
        {
            if (_nextNumberWillReplace)
            {
                tbNumbers.Text = number;
                _nextNumberWillReplace = false;
                return;
            }

            if (_numberHelper.IsANumber(tbNumbers.Text))
            {
                if (_numberHelper.AddDecimalWithNext)
                {
                    tbNumbers.Text = $"{tbNumbers.Text}.{number}";
                    _numberHelper.ResetDecimalFlags(false, true);
                    return;
                }

                tbNumbers.Text = tbNumbers.Text == "0" ? number : tbNumbers.Text + number;
            }
        }

        private void PressOperatorButton(string currentOperator)
        {
            if (_numberHelper.IsANumber(tbNumbers.Text))
            {
                var operatorResponse = _arithmeticHelper.OperatorAction(decimal.Parse(tbNumbers.Text), currentOperator);
                if (operatorResponse != 0)
                {
                    tbNumbers.Text = operatorResponse.ToString();
                }

                _nextNumberWillReplace = true;
            }
        }

        #endregion

        #region Operator Buttons

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!_numberHelper.DecimalAction())
            {
                tbNumbers.Text = "ERROR: Exceeded decimal limit";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PressOperatorButton("Add");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PressOperatorButton("Subtract");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PressOperatorButton("Multiply");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PressOperatorButton("Divide");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            PressOperatorButton("Solve");
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (_numberHelper.IsANumber(tbNumbers.Text))
            {
                tbNumbers.Text = (decimal.Parse(tbNumbers.Text) * -1).ToString();
            }

                
        }

        #endregion

        #region Number Buttons

        private void btnZero_Click(object sender, EventArgs e)
        {
            PressNumberButton("0");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            PressNumberButton("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            PressNumberButton("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            PressNumberButton("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            PressNumberButton("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            PressNumberButton("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            PressNumberButton("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            PressNumberButton("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            PressNumberButton("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            PressNumberButton("9");
        }

        #endregion
    }
}
