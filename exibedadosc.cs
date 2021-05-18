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
    public partial class exibedadosc : Form
    {
        public exibedadosc()
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
            String aux;
            PFisica pf;
            PJuridica pj;
            try
            {
                aux = textBox1.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    try
                    {
                        for (int i = 0; i < ControleDados.cont; i++)
                        {
                            pf = (PFisica)ControleDados.vet[i];
                            if (aux == pf.CPF && pf.Excluir == false) 
                            {
                                label4.Text = ("Contribuinte: " + pf.getNome() + "\n\nCPF: " + pf.CPF + " \n\nEndereço: " + pf.getendereco() + "\n\nRenda de: R$" + pf.Salario);
                            }
                            else { label4.Text = ("Contribuinte Nao Encontrado:"); }
                        }
                    }
                    catch (System.InvalidCastException)
                    {
                        MessageBox.Show("Erro Tipo invalido");
                    }
                }
                else if (comboBox1.SelectedIndex==2)
                {
                    try
                    {
                        for (int pos = 0; pos < ControleDados.cont; pos++)
                        {
                            pj = (PJuridica)ControleDados.vet[pos];
                            if (aux == pj.CNPJ && pj.Excluir==false)
                            {
                                label4.Text = ("Comtribuinte: " + pj.getNome() + "\n\nCNPJ: " + pj.CNPJ + "\n\nEndereço: " + pj.getendereco() + "\n\nRenda de:" + pj.Faturamento);
                            }
                            else { label4.Text = ("Contribuinte Nao Encontrado:"); }
                        }
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
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
