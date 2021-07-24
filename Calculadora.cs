using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        decimal valor1 = 0, valor2 = 0, diferencaResultado = 0, conjuntoValor1 = 0;
        string operacao = "";



        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {


        }




        private void button17_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "" && txtResultado.Text != "0")
                {
                    txtResultado.Text += "0";
                }
                else
                {
                    txtResultado.Text = "0";
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "1";
                }
                else
                {
                    txtResultado.Text = "1";

                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "2";
                }
                else
                {
                    txtResultado.Text = "2";

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "3";
                }
                else
                {
                    txtResultado.Text = "3";

                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "4";
                }
                else
                {
                    txtResultado.Text = "4";

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "5";
                }
                else
                {
                    txtResultado.Text = "5";

                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "6";
                }
                else
                {
                    txtResultado.Text = "6";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "7";
                }
                else
                {
                    txtResultado.Text = "7";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "8";
                }
                else
                {
                    txtResultado.Text = "8";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text += "9";
                }
                else
                {
                    txtResultado.Text = "9";

                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (lblOperacao.Text != "=")
            {
                if (txtResultado.Text != "")
                {
                    if (!txtResultado.Text.Contains("."))
                    {
                        txtResultado.Text += ".";
                    }
                }
                else
                {
                    MessageBox.Show("Digite algum número!!");
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";

            if (lblOperacao.Text == "=")
            {
                txtResultado.Text = "";
                valor1 = 0;
                valor2 = 0;
                lblOperacao.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (valor1 == 0 && valor2 == 0 && lblOperacao.Text != "+")
            {
                if (txtResultado.Text != "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    operacao = "SOMA";
                    lblOperacao.Text = "+";
                    if (txtResultado.Text == "0")
                    {
                        txtResultado.Text = "0";
                    }
                    else
                    {
                        txtResultado.Text = "";
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "+")
                {
                    txtResultado.Text = "0";
                    operacao = "SOMA";
                    lblOperacao.Text = "+";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Soma!!");
                }
            }
            else if (valor1 != 0 && valor2 == 0)
            {
                if (txtResultado.Text != "")
                {
                    if (conjuntoValor1 == 0 && lblOperacao.Text == "+")
                    {
                        conjuntoValor1 = valor1 + decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "SOMA";
                        lblOperacao.Text = "+";
                        txtResultado.Text = "";
                    }
                    else if (conjuntoValor1 != 0 && lblOperacao.Text == "+")
                    {
                        conjuntoValor1 = conjuntoValor1 + decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "SOMA";
                        lblOperacao.Text = "+";
                        txtResultado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não há como usar outro Operador no Momento!!\nContinue usando o Operador atual ou clique em '=' para continuar com outro operador!!");
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "+")
                {
                    operacao = "SOMA";
                    lblOperacao.Text = "+";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Soma!!");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (valor1 == 0 && valor2 == 0 && lblOperacao.Text != "-")
            {
                if (txtResultado.Text != "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    operacao = "SUB";
                    lblOperacao.Text = "-";
                    if (txtResultado.Text == "0")
                    {
                        txtResultado.Text = "0";
                    }
                    else
                    {
                        txtResultado.Text = "";
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "-")
                {
                    txtResultado.Text = "0";
                    operacao = "SUB";
                    lblOperacao.Text = "-";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Subtração!!");
                }
            }
            else if (valor1 != 0 && valor2 == 0)
            {
                if (txtResultado.Text != "")
                {
                    if (conjuntoValor1 == 0 && lblOperacao.Text == "-")
                    {
                        conjuntoValor1 = valor1 - decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "SUB";
                        lblOperacao.Text = "-";
                        txtResultado.Text = "";
                    }
                    else if (conjuntoValor1 != 0 && lblOperacao.Text == "-")
                    {
                        conjuntoValor1 = conjuntoValor1 - decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "SUB";
                        lblOperacao.Text = "-";
                        txtResultado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não há como usar outro Operador no Momento!!\nContinue usando o Operador atual ou clique em '=' para continuar com outro operador!!");
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "-")
                {
                    operacao = "SUB";
                    lblOperacao.Text = "-";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Subtração!!");
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (valor1 == 0 && valor2 == 0 && lblOperacao.Text != "*")
            {
                if (txtResultado.Text != "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    operacao = "MULT";
                    lblOperacao.Text = "*";
                    if (txtResultado.Text == "0")
                    {
                        txtResultado.Text = "0";
                    }
                    else
                    {
                        txtResultado.Text = "";
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "*")
                {
                    txtResultado.Text = "0";
                    operacao = "MULT";
                    lblOperacao.Text = "*";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Multiplicação!!");
                }
            }
            else if (valor1 != 0 && valor2 == 0)
            {
                if (txtResultado.Text != "")
                {
                    if (conjuntoValor1 == 0 && lblOperacao.Text == "*")
                    {
                        conjuntoValor1 = valor1 * decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "MULT";
                        lblOperacao.Text = "*";
                        txtResultado.Text = "";
                    }
                    else if (conjuntoValor1 != 0 && lblOperacao.Text == "*")
                    {
                        conjuntoValor1 = conjuntoValor1 * decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "MULT";
                        lblOperacao.Text = "*";
                        txtResultado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não há como usar outro Operador no Momento!!\nContinue usando o Operador atual ou clique em '=' para continuar com outro operador!!");
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "*")
                {
                    operacao = "MULT";
                    lblOperacao.Text = "*";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Multiplicação!!");
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (valor1 == 0 && valor2 == 0 && lblOperacao.Text != "/")
            {
                if (txtResultado.Text != "")
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    operacao = "DIV";
                    lblOperacao.Text = "/";
                    if (txtResultado.Text == "0")
                    {
                        txtResultado.Text = "0";
                    }
                    else
                    {
                        txtResultado.Text = "";
                    }
                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "/")
                {
                    txtResultado.Text = "0";
                    operacao = "DIV";
                    lblOperacao.Text = "/";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Divisão!!");
                }
            }
            else if (valor1 != 0 && valor2 == 0)
            {
                if (txtResultado.Text != "")
                {
                    if (conjuntoValor1 == 0 && lblOperacao.Text == "/")
                    {
                        conjuntoValor1 = valor1 / decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "DIV";
                        lblOperacao.Text = "/";
                        txtResultado.Text = "";
                    }
                    else if (conjuntoValor1 != 0 && lblOperacao.Text == "/")
                    {
                        conjuntoValor1 = conjuntoValor1 / decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                        operacao = "DIV";
                        lblOperacao.Text = "/";
                        txtResultado.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não há como usar outro Operador no Momento!!\nContinue usando o Operador atual ou clique em '=' para continuar com outro operador!!");
                    }

                }
                else if (txtResultado.Text == "" && lblOperacao.Text != "/")
                {
                    operacao = "DIV";
                    lblOperacao.Text = "/";
                }
                else
                {
                    MessageBox.Show("Informe os valores para efetuar a Divisão!!");
                }
            }
        }



        private void button15_Click(object sender, EventArgs e)
        {
            if (conjuntoValor1 != 0)
            {
                valor1 = 0;
                valor1 = conjuntoValor1;
                conjuntoValor1 = 0;
            }

            if (txtResultado.Text != "" && valor2 == 0 && valor1 != 0)
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                lblOperacao.Text = "=";

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2, CultureInfo.InvariantCulture);
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2, CultureInfo.InvariantCulture);
                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
                }
                else if (operacao == "DIV")
                {
                    try
                    {
                        txtResultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show($"Impossível Dividir {valor1} por Zero!!");
                        txtResultado.Text = "";
                        lblOperacao.Text = "";
                    }
                }

                valor1 = 0;
                diferencaResultado = valor2;
                valor2 = 0;
            }
            else if (txtResultado.Text != "" && valor2 == 0 && valor1 == 0 && lblOperacao.Text == "=")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + diferencaResultado, CultureInfo.InvariantCulture);
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - diferencaResultado, CultureInfo.InvariantCulture);
                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * diferencaResultado, CultureInfo.InvariantCulture);
                }
                else if (operacao == "DIV")
                {
                    try
                    {
                        txtResultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show($"Impossível Dividir {valor1} por Zero!!");
                        txtResultado.Text = "";
                        lblOperacao.Text = "";
                    }
                }

                valor1 = 0;
                valor2 = 0;
            }
            else if (txtResultado.Text != "" && valor2 == 0 && valor1 == 0 && lblOperacao.Text != "=" && lblOperacao.Text != "" && txtResultado.Text != "0")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                lblOperacao.Text = "=";

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2, CultureInfo.InvariantCulture);
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2, CultureInfo.InvariantCulture);
                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2, CultureInfo.InvariantCulture);
                }
                else if (operacao == "DIV")
                {
                    try
                    {
                        txtResultado.Text = Convert.ToString(valor1 / valor2, CultureInfo.InvariantCulture);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show($"Impossível Dividir {valor1} por Zero!!");
                        txtResultado.Text = "";
                        lblOperacao.Text = "";
                    }
                }

                diferencaResultado = valor2;
                valor2 = 0;
            }
            else
            {
                MessageBox.Show("Informe os valores para efetuar o Resultado!!");
            }
        }
    }
}
