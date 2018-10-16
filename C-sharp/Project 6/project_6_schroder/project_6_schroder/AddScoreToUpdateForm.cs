using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_6_schroder
{
    public partial class AddScoreToUpdateForm : Form
    {
        public AddScoreToUpdateForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Tag = scoreTB.Text;
        }
    }
}
