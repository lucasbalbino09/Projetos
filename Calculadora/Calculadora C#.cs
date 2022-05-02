using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class lbloperacao : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public lbloperacao()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtres.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                txtres.Text = Convert.ToString(valor1 + valor2);
            } else if (operacao == "SUB")
            {
                txtres.Text = Convert.ToString(valor1 - valor2);
            } else if(operacao == "MULT")
            {
                txtres.Text = Convert.ToString(valor1 * valor2);
            } else
            {
                txtres.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtres.Text += "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtres.Text += "2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            txtres.Text += "0";
        }

        private void lboperacao_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtres.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtres.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtres.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtres.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtres.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtres.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtres.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtres.Text += ".";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            valor1 = decimal.Parse(txtres.Text, CultureInfo.InvariantCulture);

            txtres.Text = "";
            operacao = "SUB";
            opera.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtres.Text, CultureInfo.InvariantCulture);

            txtres.Text = "";
            operacao = "MULT";
            opera.Text = "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtres.Text, CultureInfo.InvariantCulture);

            txtres.Text = "";
            operacao = "DIV";
            opera.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtres.Text = "";
            valor1 = 0;
            valor2 = 0;
            opera.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtres.Text = "";
            opera.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtres.Text != "")
            {
            valor1 = decimal.Parse(txtres.Text, CultureInfo.InvariantCulture);
            txtres.Text = "";
            operacao = "SOMA";
            opera.Text = "+";
            } else
            {
                MessageBox.Show("erro na informação.");
                
            }
        }
    }
}
