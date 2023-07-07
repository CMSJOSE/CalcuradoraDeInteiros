namespace CalcuradoraDeInteiros
{
    public partial class Form1 : Form
    {
        public int resultado, numTemp;
        public string operacao = "";

        public Form1()

        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numTemp = (numTemp * 10) + num;
            Display.Text = numTemp.ToString();
        }

        private void DigitaOperacao(string operador)
        {
            if (operacao.Length > 0)
            {
                CalculaResultado();
            }
            else
            {
                resultado = numTemp;
            }

            numTemp = 0;
            operacao = operador;

        }
        private void CalculaResultado()
        {
            switch (operacao)
            {
                case "+":
                    resultado = resultado + numTemp;
                    break;
                case "-":
                    resultado = resultado - numTemp;
                    break;
                case "*":
                    resultado = resultado * numTemp;
                    break;
                case "/":
                    resultado = resultado / numTemp;
                    break;

            }
            Display.Text = resultado.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DigitaNumero(1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DigitaOperacao("/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DigitaNumero(0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DigitaOperacao("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DigitaOperacao("-");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DigitaOperacao("*");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void button12_Click(object sender, EventArgs e)
        {

            CalculaResultado();
            resultado = 0;
            numTemp = 0;
            operacao = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DigitaNumero(4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DigitaNumero(8);
        }
    }
}