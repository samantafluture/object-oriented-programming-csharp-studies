using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSimpleCalculator
{
    internal static class Program
    {
        public static int add(int x, int y)
        {
            return x + y;
        }

        public static int subtract(int x, int y)
        {
            return x - y;
        }

        public static int multiply(int x, int y)
        {
            return x * y;
        }

        public static int divide(int x, int y)
        {
            return x / y;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
