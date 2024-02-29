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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.CenterToScreen();
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            lblRandomNumber.Text = randomNumber.ToString();
        }

        private void tbxVar1If_TextChanged(object sender, EventArgs e)
        {
            if(tbxVar1If.Text == "" && tbxInIf.Text == "")
            {
                grbxSubmitIf.Enabled = false;
            }
            else
            {
                grbxSubmitIf.Enabled = true;
            }
        }

        private void tbxInIf_TextChanged(object sender, EventArgs e)
        {
            if (tbxVar1If.Text == "" && tbxInIf.Text == "")
            {
                grbxSubmitIf.Enabled = false;
            }
            else
            {
                grbxSubmitIf.Enabled = true;
            }
        }

        private void btnSubmitIf_Click(object sender, EventArgs e)
        {
            if (tbxInIf.Text == "Console.WriteLine('Guess');" && tbxVar1If.Text == lblRandomNumber.Text)
            {
                rtbConsoleIf.Clear();
                rtbConsoleIf.AppendText("Guess");
                MessageBox.Show("The code you made is perfect!", "Good Job!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 Form3 = new Form3();
                Form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The code is not correct, please try again.", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearIf_Click(object sender, EventArgs e)
        {
            rtbConsoleIf.Clear();
            rtbConsoleIf.Text = "The console will display information here:";
            tbxVar1If.Clear();
            tbxInIf.Clear();
        }
    }
}
