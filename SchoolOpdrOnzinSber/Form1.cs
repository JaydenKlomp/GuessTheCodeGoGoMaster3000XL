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
    public partial class Form1 : Form
    {
        
        String Var1 = "";
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
                Var1 = tbxVar1Hw.Text;

                if (Var1 == "Hello world" || Var1 == "Hello World" || Var1 == "hello world" || Var1 == "hello World")
                {
                    rtbConsoleHw.Clear();
                    rtbConsoleHw.AppendText('"' + Var1 + '"');
                    MessageBox.Show("Great job! If you look in the console you can see the code you wrote is working as intended", "Great Job!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Form2 Form2 = new Form2();
                    //Form2.Show();
                    //this.Hide();

                    Form3 Form3 = new Form3();
                    Form3.Show();
                    this.Hide();
            }
                else
                {
                    rtbConsoleHw.Clear();
                    rtbConsoleHw.AppendText('"' + Var1 + '"');
                    MessageBox.Show("The code works, but you did not use Hello World! Please try again", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void tbxVar1_TextChanged(object sender, EventArgs e)
        {
            if(tbxVar1Hw.Text == "")
            {
                grbxSubmit.Enabled = false;
            }
            else
            {
                grbxSubmit.Enabled = true;
            }
        }

        private void btnClearHw_Click(object sender, EventArgs e)
        {
            tbxVar1Hw.Clear();
            rtbConsoleHw.Clear();
            rtbConsoleHw.Text = "The console will display information here:";
            Var1 = "";
        }
    }
}
