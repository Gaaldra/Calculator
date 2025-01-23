using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        private string previousEntry;
        private string currentEntry = "0";
        private Func<double, double, double> calcAction;
        private string actionSign;
        private readonly bool isResult = false;

        public Calculator() => InitializeComponent();

        private void ChangeCurrentEntry(string entry)
        {
            if (currentEntry.Length < 9)
            {
                currentEntry = currentEntry == "0" ? entry : currentEntry + entry;
            }
        }

        private void UpdateVisor()
        {
            lblEntry.Text = currentEntry;
            lblPreviousEntry.Text = string.IsNullOrWhiteSpace(previousEntry) ? "" : $"{previousEntry} {actionSign}";
        }

        private void NextEntry()
        {
            if (currentEntry == "0") return;
            previousEntry = currentEntry;
            currentEntry = "0";
            UpdateVisor();
        }

        private void Calculate(double number1, double number2)
        {
            double result = calcAction(number1, number2);
            ResetState(result.ToString());
        }

        private void ResetState(string result)
        {
            previousEntry = string.Empty;
            actionSign = string.Empty;
            calcAction = null;
            currentEntry = result;
            UpdateVisor();
        }

        private void OnNumberButtonClick(object sender, EventArgs e)
        {
            ChangeCurrentEntry(((Button)sender).Text);
            UpdateVisor();
        }

        private void SetCalcutationAction(string action)
        {
            calcAction = action switch
            {
                "+" => Sum,
                "−" => Subtract,
                "×" => Multiply,
                "÷" => Divide,
                _ => null
            };
            actionSign = action;
            UpdateVisor();
        }

        private void OnActionButtonClick(object sender, EventArgs e)
        {
            if (IsInvalidCommaEntry()) return;

            string action = ((Button)sender).Text;
            if (IsNewActionAllowed())
            {
                SetActionAndPrepareNext(action);
                return;
            }

            if (IsContinuingWithZero())
            {
                SetCalcutationAction(action);
                return;
            }

            if (IsReadyForCalculation())
            {
                btnEqual.PerformClick();
                OnActionButtonClick(sender, e);
            }
        }

        private bool IsInvalidCommaEntry() => currentEntry.EndsWith(",");
        private bool IsNewActionAllowed() => string.IsNullOrEmpty(previousEntry) && currentEntry != "0";
        private bool IsContinuingWithZero() => currentEntry == "0" && !string.IsNullOrEmpty(actionSign);
        private bool IsReadyForCalculation() => currentEntry != "0" && !string.IsNullOrEmpty(previousEntry);

        private void SetActionAndPrepareNext(string action)
        {
            SetCalcutationAction(action);
            NextEntry();
        }

        private void OnEqualsButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(previousEntry) || currentEntry == "0") return;
            Calculate(Convert.ToDouble(previousEntry), Convert.ToDouble(currentEntry));
        }

        private void OnClearAllButtonClick(object sender, EventArgs e) => ResetState("0");

        private void OnClearEntryButtonClick(object sender, EventArgs e)
        {
            if (isResult)
            {
                btnClearAll.PerformClick();
            }
            else
            {
                currentEntry = "0";
                UpdateVisor();
            }
        }

        private void OnUnaryOperationButtonClick(Func<double, double> operation)
        {
            if (currentEntry == "0") return;
            currentEntry = operation(Convert.ToDouble(currentEntry)).ToString();
            UpdateVisor();
        }

        private void OnPercentButtonClick(object sender, EventArgs e) => OnUnaryOperationButtonClick(x => x / 100);

        private void OnReciprocalButtonClick(object sender, EventArgs e) => OnUnaryOperationButtonClick(x => 1 / x);

        private void OnSquareButtonClick(object sender, EventArgs e) => OnUnaryOperationButtonClick(x => Math.Pow(x, 2));

        private void OnSquareRootButtonClick(object sender, EventArgs e) => OnUnaryOperationButtonClick(Math.Sqrt);

        private void OnBackspaceButtonClick(object sender, EventArgs e)
        {
            if (currentEntry == "0") return;
            currentEntry = currentEntry.Length > 1 ? currentEntry.Remove(currentEntry.Length - 1) : "0";
            UpdateVisor();
        }

        private void OnPlusMinusButtonClick(object sender, EventArgs e)
        {
            if (currentEntry != "0")
            {
                currentEntry = currentEntry.StartsWith("-") ? currentEntry.Substring(1) : "-" + currentEntry;
                UpdateVisor();
            }
        }

        private void OnCommaButtonClick(object sender, EventArgs e)
        {
            if (!currentEntry.Contains(","))
            {
                currentEntry += ",";
                UpdateVisor();
            }
        }

        private static double Sum(double entry1, double entry2) => entry1 + entry2;
        private static double Subtract(double entry1, double entry2) => entry1 - entry2;
        private static double Divide(double entry1, double entry2) => entry1 / entry2;
        private static double Multiply(double entry1, double entry2) => entry1 * entry2;

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
