using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolOpdrOnzinSber
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSubmitCodeLoop_Click(object sender, EventArgs e)
        {
            if (tbxLoopNumber.Text == "15")
            {
                MessageBox.Show("Good job! On to the last exercise", "Good Job!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form5 Form5 = new Form5();
                Form5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Oh, that's not quite correct. Try again!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoopClear_Click(object sender, EventArgs e)
        {
            tbxLoopNumber.Text = "";
        }
    }
}
