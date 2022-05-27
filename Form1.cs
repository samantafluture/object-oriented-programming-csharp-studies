using System;
using System.Windows.Forms;

namespace WindowsFormsSimpleCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // declare variables
            string input;
            int n1, n2, result;

            // get string input from user and convert it int
            // pass theses values to n1 and n2
            input = this.textBoxNumber1.Text;
            n1 = Convert.ToInt32(input);

            input = this.textBoxNumber2.Text;
            n2 = Convert.ToInt32(input);

            // addition
            result = Calculator.add(n1, n2);

            // output the result by converting int to string
            this.textBoxResult.Text = Convert.ToString(result);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            // declare variables
            string input;
            int n1, n2, result;

            // get string input from user and convert it int
            // pass theses values to n1 and n2
            input = this.textBoxNumber1.Text;
            n1 = Convert.ToInt32(input);

            input = this.textBoxNumber2.Text;
            n2 = Convert.ToInt32(input);

            // subtraction
            result = Calculator.subtract(n1, n2);

            // output the result by converting int to string
            this.textBoxResult.Text = Convert.ToString(result);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            // declare variables
            string input;
            int n1, n2, result;

            // get string input from user and convert it int
            // pass theses values to n1 and n2
            input = this.textBoxNumber1.Text;
            n1 = Convert.ToInt32(input);

            input = this.textBoxNumber2.Text;
            n2 = Convert.ToInt32(input);

            // multiplication
            result = Calculator.multiply(n1, n2);

            // output the result by converting int to string
            this.textBoxResult.Text = Convert.ToString(result);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            // declare variables
            string input;
            int n1, n2, result;

            // get string input from user and convert it int
            // pass theses values to n1 and n2
            input = this.textBoxNumber1.Text;
            n1 = Convert.ToInt32(input);

            input = this.textBoxNumber2.Text;
            n2 = Convert.ToInt32(input);

            // division
            if (n2 != 0)
            {
                result = Calculator.divide(n1, n2);

                // output the result by converting int to string
                this.textBoxResult.Text = Convert.ToString(result);
            } else
            {
                this.textBoxResult.Text = "Error, cannot divide by 0";
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            // declare variables
            string input;
            int n1, n2, result;

            // get string input from user and convert it int
            // pass theses values to n1 and n2
            input = this.textBoxNumber1.Text;
            n1 = Convert.ToInt32(input);

            input = this.textBoxNumber2.Text;
            n2 = Convert.ToInt32(input);

            // multiplication
            result = Calculator.modulos(n1, n2);

            // output the result by converting int to string
            this.textBoxResult.Text = Convert.ToString(result);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxNumber1.Text = "";
            this.textBoxNumber2.Text = "";
            this.textBoxResult.Text = "";

            this.textBoxNumber1.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit the application?\n\tIf yes, click OK", "Easy Calculator - Version 01");
            this.Close();
        }

    }
}
