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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void tbxVar1Var_TextChanged(object sender, EventArgs e)
        {
            if (tbxVar1Var.Text == "" && tbxVar2Var.Text == "" && tbxVar3Var.Text == "" && tbxVar4Var.Text == "" && tbxVar5Var.Text == "" && tbxVar6Var.Text == "")
            {
                grbxSubmitVar.Enabled = false;
            }
            else
            {
                grbxSubmitVar.Enabled = true;
            }
        }

        private void btnSubmitVar_Click(object sender, EventArgs e)
        {
            if (tbxVar1Var.Text == "Int" && tbxVar2Var.Text == "Bool" && tbxVar3Var.Text == "String" && tbxVar4Var.Text == "String" && tbxVar5Var.Text == "Int" && tbxVar6Var.Text == "Bool")
            {
                MessageBox.Show("The variables are filled in correctly", "Good Job!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 Form4 = new Form4();
                Form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill in the correct variable types", "Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearVar_Click(object sender, EventArgs e)
        {
            tbxVar1Var.Text = "";
            tbxVar2Var.Text = "";
            tbxVar3Var.Text = "";
            tbxVar4Var.Text = "";
            tbxVar5Var.Text = "";
            tbxVar6Var.Text = "";
        }
    }
}
