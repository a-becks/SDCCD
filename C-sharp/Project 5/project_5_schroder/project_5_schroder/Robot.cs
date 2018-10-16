using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace project_5_schroder
{
    public class Robot
    {
        private int currentX, currentY;
        public string direction;

        public Robot()
        {
            currentX = 100;
            currentY = 100;
        }

        public Point Position{
            get
            {
                return new Point(this.currentX, this.currentY);
            }
        }

        public void moveRobot(char direction, int amount)
        {
            if (direction == 'N')
            {
                int newCoord = currentY - amount;
                if (!isValid(newCoord)){
                    MessageBox.Show("Cannot move more than 100 units in any direction", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                currentY = newCoord;
            }

            else if (direction == 'S')
            {
                int newCoord = currentY + amount;
                if (!isValid(newCoord))
                {
                    MessageBox.Show("Cannot move more than 100 units in any direction", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                currentY = newCoord;
            }

            else if (direction == 'W')
            {
                int newCoord = currentX - amount;
                if (!isValid(newCoord))
                {
                    MessageBox.Show("Cannot move more than 100 units in any direction", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                currentX = newCoord;
            }

            else if (direction == 'E')
            {
                int newCoord = currentX + amount;
                if (!isValid(newCoord))
                {
                    MessageBox.Show("Cannot move more than 100 units in any direction", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                currentX = newCoord;
            }
        }

        private bool isValid(int someCoord)
        {
            return !(someCoord > 200 || someCoord < 0);
        }

    }
}
