namespace Calc
{
    public partial class Form1 : Form
    {
        public decimal numero { get; set; }
        public decimal res { get; set; }
        private oper selecao { get; set; }
        private enum oper
        {
            soma,
            sub,
            div,
            mult
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void soma_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "+";
            selecao = oper.soma;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "-";
            selecao = oper.sub;
        }

        private void div_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "/";
            selecao = oper.div;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "X";
            selecao = oper.mult;
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            label1.Text = "=";
            switch (selecao)
            {
                case oper.soma:
                    res = numero + Convert.ToDecimal(textBox1.Text);
                    break;
                case oper.sub:
                    res = numero - Convert.ToDecimal(textBox1.Text);
                    break;
                case oper.div:
                    res = numero / Convert.ToDecimal(textBox1.Text);
                    break;
                case oper.mult:
                    res = numero * Convert.ToDecimal(textBox1.Text);
                    break;

            }
            textBox1.Text = Convert.ToString(res);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            numero = 0;
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
