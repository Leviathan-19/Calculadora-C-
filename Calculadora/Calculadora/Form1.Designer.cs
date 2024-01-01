namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Disp = new TextBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonSuma = new Button();
            buttonResta = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            buttonMulti = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            buttonDivi = new Button();
            buttonIgual = new Button();
            button0 = new Button();
            buttonC = new Button();
            SuspendLayout();
            // 
            // textBox_Disp
            // 
            textBox_Disp.BackColor = Color.FromArgb(255, 255, 192);
            textBox_Disp.Enabled = false;
            textBox_Disp.Font = new Font("Impact", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Disp.ForeColor = Color.RoyalBlue;
            textBox_Disp.Location = new Point(91, 36);
            textBox_Disp.Multiline = true;
            textBox_Disp.Name = "textBox_Disp";
            textBox_Disp.Size = new Size(314, 72);
            textBox_Disp.TabIndex = 0;
            textBox_Disp.Text = "Bienvenido";
            textBox_Disp.TextAlign = HorizontalAlignment.Center;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(0, 192, 192);
            button9.Cursor = Cursors.WaitCursor;
            button9.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.RoyalBlue;
            button9.Location = new Point(257, 156);
            button9.Name = "button9";
            button9.Size = new Size(79, 75);
            button9.TabIndex = 1;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 192, 192);
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.RoyalBlue;
            button8.Location = new Point(145, 156);
            button8.Name = "button8";
            button8.Size = new Size(79, 75);
            button8.TabIndex = 2;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 192, 192);
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.RoyalBlue;
            button7.Location = new Point(45, 156);
            button7.Name = "button7";
            button7.Size = new Size(79, 75);
            button7.TabIndex = 3;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button3_Click;
            // 
            // buttonSuma
            // 
            buttonSuma.BackColor = Color.FromArgb(0, 192, 192);
            buttonSuma.Cursor = Cursors.Hand;
            buttonSuma.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSuma.ForeColor = Color.RoyalBlue;
            buttonSuma.Location = new Point(403, 156);
            buttonSuma.Name = "buttonSuma";
            buttonSuma.Size = new Size(79, 75);
            buttonSuma.TabIndex = 4;
            buttonSuma.Text = "+";
            buttonSuma.UseVisualStyleBackColor = false;
            buttonSuma.Click += buttonSuma_Click;
            // 
            // buttonResta
            // 
            buttonResta.BackColor = Color.FromArgb(0, 192, 192);
            buttonResta.Cursor = Cursors.Hand;
            buttonResta.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResta.ForeColor = Color.RoyalBlue;
            buttonResta.Location = new Point(403, 245);
            buttonResta.Name = "buttonResta";
            buttonResta.Size = new Size(79, 75);
            buttonResta.TabIndex = 8;
            buttonResta.Text = "-";
            buttonResta.UseVisualStyleBackColor = false;
            buttonResta.Click += buttonResta_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 192, 192);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.RoyalBlue;
            button4.Location = new Point(45, 245);
            button4.Name = "button4";
            button4.Size = new Size(79, 75);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 192, 192);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.RoyalBlue;
            button5.Location = new Point(145, 245);
            button5.Name = "button5";
            button5.Size = new Size(79, 75);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 192, 192);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.RoyalBlue;
            button6.Location = new Point(257, 245);
            button6.Name = "button6";
            button6.Size = new Size(79, 75);
            button6.TabIndex = 3;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = Color.FromArgb(0, 192, 192);
            buttonMulti.Cursor = Cursors.Hand;
            buttonMulti.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMulti.ForeColor = Color.RoyalBlue;
            buttonMulti.Location = new Point(403, 337);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new Size(79, 75);
            buttonMulti.TabIndex = 12;
            buttonMulti.Text = "X";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMulti_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.RoyalBlue;
            button1.Location = new Point(45, 337);
            button1.Name = "button1";
            button1.Size = new Size(79, 75);
            button1.TabIndex = 11;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button10_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.RoyalBlue;
            button2.Location = new Point(145, 337);
            button2.Name = "button2";
            button2.Size = new Size(79, 75);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.RoyalBlue;
            button3.Location = new Point(257, 337);
            button3.Name = "button3";
            button3.Size = new Size(79, 75);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // buttonDivi
            // 
            buttonDivi.BackColor = Color.FromArgb(0, 192, 192);
            buttonDivi.Cursor = Cursors.Hand;
            buttonDivi.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivi.ForeColor = Color.RoyalBlue;
            buttonDivi.Location = new Point(403, 428);
            buttonDivi.Name = "buttonDivi";
            buttonDivi.Size = new Size(79, 75);
            buttonDivi.TabIndex = 16;
            buttonDivi.Text = "/";
            buttonDivi.UseVisualStyleBackColor = false;
            buttonDivi.Click += buttonDivi_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = Color.FromArgb(0, 192, 192);
            buttonIgual.Cursor = Cursors.Hand;
            buttonIgual.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIgual.ForeColor = Color.RoyalBlue;
            buttonIgual.Location = new Point(257, 428);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(79, 75);
            buttonIgual.TabIndex = 15;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // button0
            // 
            button0.BackColor = Color.FromArgb(0, 192, 192);
            button0.Cursor = Cursors.Hand;
            button0.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button0.ForeColor = Color.RoyalBlue;
            button0.Location = new Point(145, 428);
            button0.Name = "button0";
            button0.Size = new Size(79, 75);
            button0.TabIndex = 14;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(0, 192, 192);
            buttonC.Cursor = Cursors.Hand;
            buttonC.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonC.ForeColor = Color.RoyalBlue;
            buttonC.Location = new Point(45, 428);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(79, 75);
            buttonC.TabIndex = 13;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(526, 564);
            Controls.Add(buttonDivi);
            Controls.Add(buttonIgual);
            Controls.Add(button0);
            Controls.Add(buttonC);
            Controls.Add(buttonMulti);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(buttonResta);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(buttonSuma);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(textBox_Disp);
            Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "CALCULADORA";
            TransparencyKey = SystemColors.ActiveCaptionText;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Disp;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonSuma;
        private Button buttonResta;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button buttonMulti;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button buttonDivi;
        private Button buttonIgual;
        private Button button0;
        private Button buttonC;
    }
}
