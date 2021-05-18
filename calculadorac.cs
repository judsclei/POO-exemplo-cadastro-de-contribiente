using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contribuinte
{
    public partial class calculadorac : Form
    {
        public calculadorac()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int num1, num2;

            CalculadoraSimples calc = new CalculadoraSimples();

            try
            {   
                if (Int32.TryParse(textBox1.Text, out num1) == true){
                    num1 = int.Parse(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Valor 1 inserido é inválido");
                    textBox1.Clear();
                    return;
                }

                if (Int32.TryParse(textBox2.Text, out num2) == true)
                {
                    num2 = int.Parse(textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Valor 2 inserido é inválido");
                    textBox2.Clear();
                    return;
                }

                if (comboBox1.SelectedIndex == 1) //somar
                {
                    try
                    {

                        label4.Text = "Resultado: " + calc.Somar(num1, num2).ToString();

                    }
                    catch (System.InvalidCastException)
                    {
                        MessageBox.Show("Erro Tipo invalido");
                    }
                } 
                else if (comboBox1.SelectedIndex == 2) //subtrair
                {
                    try
                    {
                        label4.Text = "Resultado: " + calc.Diminuir(num1, num2).ToString();
                    }
                    catch (System.InvalidCastException)
                    {
                        MessageBox.Show("Erro Tipo invalido");
                    }
                }
                else if (comboBox1.SelectedIndex == 3) //Multiplicar
                {
                    try
                    {
                        label4.Text = "Resultado: " + calc.Multiplicar(num1, num2).ToString();
                    }
                    catch (System.InvalidCastException)
                    {
                        MessageBox.Show("Erro Tipo invalido");
                    }
                }
                else if (comboBox1.SelectedIndex == 4) //Dividir
                {
                    try
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossível realizar divisão por 0.\nFavor inserir outro numero no Valor 2");
                            textBox2.Clear();
                            return;
                        }

                        label4.Text = "Resultado: " + calc.Dividir(num1, num2).ToString();
                    }
                    catch (System.InvalidCastException)
                    {
                        MessageBox.Show("Erro Tipo invalido");
                    }
                }


            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dados inexistentes");
                label4.Text = ("Dados inexistentes");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            comboBox1.SelectedIndex = 0;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculadorac_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
