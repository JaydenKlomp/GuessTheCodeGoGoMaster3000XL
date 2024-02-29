namespace SchoolOpdrOnzinSber
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmitHw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxVar1Hw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbxSubmit = new System.Windows.Forms.GroupBox();
            this.rtbConsoleHw = new System.Windows.Forms.RichTextBox();
            this.btnClearHw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbxSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitHw
            // 
            this.btnSubmitHw.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitHw.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitHw.Location = new System.Drawing.Point(8, 23);
            this.btnSubmitHw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitHw.Name = "btnSubmitHw";
            this.btnSubmitHw.Size = new System.Drawing.Size(272, 111);
            this.btnSubmitHw.TabIndex = 0;
            this.btnSubmitHw.Text = "Submit Code";
            this.btnSubmitHw.UseVisualStyleBackColor = true;
            this.btnSubmitHw.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxVar1Hw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display \"Hello World\" in the console";
            // 
            // tbxVar1Hw
            // 
            this.tbxVar1Hw.Location = new System.Drawing.Point(509, 151);
            this.tbxVar1Hw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxVar1Hw.Name = "tbxVar1Hw";
            this.tbxVar1Hw.Size = new System.Drawing.Size(132, 22);
            this.tbxVar1Hw.TabIndex = 2;
            this.tbxVar1Hw.TextChanged += new System.EventHandler(this.tbxVar1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Console.Log(\"                      \");";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please finish the C# code:";
            // 
            // grbxSubmit
            // 
            this.grbxSubmit.Controls.Add(this.rtbConsoleHw);
            this.grbxSubmit.Controls.Add(this.btnClearHw);
            this.grbxSubmit.Controls.Add(this.btnSubmitHw);
            this.grbxSubmit.Enabled = false;
            this.grbxSubmit.Location = new System.Drawing.Point(17, 292);
            this.grbxSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbxSubmit.Name = "grbxSubmit";
            this.grbxSubmit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbxSubmit.Size = new System.Drawing.Size(1033, 247);
            this.grbxSubmit.TabIndex = 2;
            this.grbxSubmit.TabStop = false;
            this.grbxSubmit.Text = "Console";
            // 
            // rtbConsoleHw
            // 
            this.rtbConsoleHw.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsoleHw.Location = new System.Drawing.Point(288, 23);
            this.rtbConsoleHw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbConsoleHw.Name = "rtbConsoleHw";
            this.rtbConsoleHw.ReadOnly = true;
            this.rtbConsoleHw.Size = new System.Drawing.Size(736, 216);
            this.rtbConsoleHw.TabIndex = 2;
            this.rtbConsoleHw.Text = "The console will display information here:";
            // 
            // btnClearHw
            // 
            this.btnClearHw.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHw.ForeColor = System.Drawing.Color.Crimson;
            this.btnClearHw.Location = new System.Drawing.Point(8, 137);
            this.btnClearHw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearHw.Name = "btnClearHw";
            this.btnClearHw.Size = new System.Drawing.Size(272, 103);
            this.btnClearHw.TabIndex = 1;
            this.btnClearHw.Text = "CLEAR";
            this.btnClearHw.UseVisualStyleBackColor = true;
            this.btnClearHw.Click += new System.EventHandler(this.btnClearHw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grbxSubmit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Lesson 1 / 6: Hello World";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxSubmit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitHw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbxSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxVar1Hw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClearHw;
        private System.Windows.Forms.RichTextBox rtbConsoleHw;
    }
}

