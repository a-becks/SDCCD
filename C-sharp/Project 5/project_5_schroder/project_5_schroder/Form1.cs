using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_5_schroder
{
    public partial class Form1 : Form
    {

        private const int LEFT_ARROW = 231;
        private const int RIGHT_ARROW = 232;
        private const int UP_ARROW = 233;
        private const int DOWN_ARROW = 234;

        private char direction = 'N';

        Robot someRobot = new Robot();

        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(label1);
            //label1.Location = new Point(100, 100);
            panel1.Height = 200;
            panel1.Width = 200;
            label1.Text = getString(UP_ARROW);
            updatePosition();
        }

        private string getString(int arrowInt) => Convert.ToChar(arrowInt).ToString();

        private void btnN_Click(object sender, EventArgs e)
        {
            label1.Text = getString(UP_ARROW);
            direction = 'N';
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            label1.Text = getString(LEFT_ARROW);
            direction = 'W';
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            label1.Text = getString(RIGHT_ARROW);
            direction = 'E';
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            label1.Text = getString(DOWN_ARROW);
            direction = 'S';
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            someRobot.moveRobot(direction, 1);
            updatePosition();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            someRobot.moveRobot(direction, 10);
            updatePosition();
        }

        private void updatePosition()
        {
            Point point = someRobot.Position;
            label1.Location = point;

            //because position in panel is between 0-200, but center is (0,0)
            int xCoord = point.X - 100;
            int yCoord = point.Y - 100;
            coordLabel.Text = "{ X=" + xCoord.ToString() + ", Y=" + yCoord.ToString() + " }";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
