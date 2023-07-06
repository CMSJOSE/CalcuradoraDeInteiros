namespace CalcuradoraDeInteiros
{
    public partial class Form1 : Form
    {
        public int resultado, numTemp;
        public string operacao;

        public Form1()

        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numTemp = (numTemp * 10) + num;
        }

        private void DigitaOperacao(string operador)
        {
            resultado = numTemp;
            numTemp = 0;
            operacao = operador;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            private void button13_Click(object sender, EventArgs e)
            {
                DigitaOperacao("/");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DigitaOperacao("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            private void button13_Click(object sender, EventArgs e)
            {
                DigitaOperacao("-");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            private void button13_Click(object sender, EventArgs e)
            {
                DigitaOperacao("*");
            }
        }
    }
}