namespace Calculadora
{
    public partial class Form1 : Form
    {
        static double valor1 = 0;
        static double valor2 = 0;
        static double resultado = 0;
        static string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "9";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "8";
        }



        private void button0_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = textBox_Disp.Text + "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_Disp.Text = "";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox_Disp.Text);
            textBox_Disp.Text = "";
            operacion = "SUM";
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox_Disp.Text);
            textBox_Disp.Text = "";
            operacion = "RES";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox_Disp.Text);
            textBox_Disp.Text =  "";
            operacion = "MUL";
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(textBox_Disp.Text);
            textBox_Disp.Text = "";
            operacion = "DIV";
        }




        private void buttonIgual_Click(object sender, EventArgs e)
        {


            switch (operacion)
            {
                case "SUM":
                    valor2 = Convert.ToDouble(textBox_Disp.Text);
                    resultado = valor1 + valor2;
                    textBox_Disp.Text = resultado.ToString();
                    valor1 = 0;
                    valor2 = 0;
                    break;

                case "RES":
                    valor2 = Convert.ToDouble(textBox_Disp.Text);
                    resultado = valor1 - valor2;
                    textBox_Disp.Text = resultado.ToString();
                    valor1 = 0;
                    valor2 = 0;
                    break;

                case "MUL":
                    valor2 = Convert.ToDouble(textBox_Disp.Text);
                    resultado = valor1 * valor2;
                    textBox_Disp.Text = resultado.ToString();
                    valor1 = 0;
                    valor2 = 0;
                    break;
                case "DIV":

                    valor2 = Convert.ToDouble(textBox_Disp.Text);
                    resultado = valor1 / valor2;
                    textBox_Disp.Text = resultado.ToString();
                    valor1 = 0;
                    valor2 = 0;
                    break;
            }
        }

        
    }
}
