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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSubmitVar_Click(object sender, EventArgs e)
        {
            if (tbxMore.Text == ">" && tbxLogRand.Text == "Console.WriteLine(random);" && tbxLogLess.Text == "Console.WriteLine('less');")
            {
                MessageBox.Show("You passed the test!!", "Good Job!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form7 Form7 = new Form7();
                Form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thats not right!", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearVar_Click(object sender, EventArgs e)
        {

        }

        private void tbxLogRand_TextChanged(object sender, EventArgs e)
        {
            if(tbxMore.Text == "" || tbxLogRand.Text == "" ||  tbxLogLess.Text == "")
            {
                grbxSubmitVar.Enabled = false;
            }
            else
            {
                grbxSubmitVar.Enabled = true;
            }
        }
    }
}
