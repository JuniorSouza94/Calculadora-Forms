namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double numTemporario = 0;
        private double primeiroNum = 0;
        private double segundoNum = 0;
        private string operadorTemporario = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
            numTemporario = double.Parse(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            primeiroNum = numTemporario;
            operadorTemporario = "+";
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            primeiroNum = numTemporario;
            operadorTemporario = "-";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            primeiroNum = numTemporario;
            operadorTemporario = "*";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            primeiroNum = numTemporario;
            operadorTemporario = "/";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            segundoNum = numTemporario;
            double resultado = 0;

            switch (operadorTemporario)
            {
                case "+":
                    resultado = primeiroNum + segundoNum;
                    break;
                case "-":
                    resultado = primeiroNum - segundoNum;
                    break;
                case "*":
                    resultado = primeiroNum * segundoNum;
                    break;
                case "/":
                    if (segundoNum == 0)
                    {
                        textBox1.Text = "Erro: divisão por zero!";
                        return;
                    }
                    else
                        resultado = primeiroNum / segundoNum;
                    break;
                default:
                    textBox1.Clear();
                    break;
            }
            textBox1.Text = resultado.ToString();
            numTemporario = resultado;
        }


        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numTemporario = 0;
            primeiroNum = 0;
            segundoNum = 0;
            operadorTemporario = "";
        }
    }
}