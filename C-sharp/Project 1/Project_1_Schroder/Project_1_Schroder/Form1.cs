using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_Schroder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal width = Convert.ToDecimal(txtWidth.Text);
            decimal length = Convert.ToDecimal(txtLength.Text);

            decimal area = width * length;
            decimal perimeter = (2 * width) + (2 * length);

            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();

            txtLength.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
