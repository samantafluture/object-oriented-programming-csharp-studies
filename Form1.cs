using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            result = n1 + n2;

            // output the result by converting int to string
            this.textBoxResult.Text = Convert.ToString(result);
        }
    }
}
