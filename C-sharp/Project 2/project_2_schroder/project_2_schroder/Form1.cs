using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2_schroder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startNum = Convert.ToInt16(txtNumber.Text);
            long factorial = calculateFactorial(startNum);
            txtFactorial.Text = factorial.ToString("n0");
        }

        private long calculateFactorial(int num)
        {
            if (num > 1)
            {
                return num * calculateFactorial(num - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
