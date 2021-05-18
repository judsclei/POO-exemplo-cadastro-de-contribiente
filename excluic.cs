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
    public partial class excluic : Form
    {
        public excluic()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = null;
            PFisica pf;
            PJuridica pj;

            try { id = (textBox1.Text); }
            catch (System.ArgumentNullException)
            {
                MessageBox.Show("Erro ");
                label3.Text = ("Erro ");
            }

            if (radioButton1.Checked == true)
            {
                for (int pos = 0; pos < ControleDados.cont; pos++)
                {
                    pf = (PFisica)ControleDados.vet[pos];

                    if (id == pf.CPF)
                    {
                        pf.Excluir = true;
                        label4.Text = ("O contribuinte com a identidade " + id + " foi excluido");
                        MessageBox.Show("O contribuinte com a identidade " + id + " foi excluido");
                    }
                    else
                    {
                        label4.Text = ("Contribuinte Inexistente ou Excluido");
                        MessageBox.Show("Contribuinte Inexistente ou Excluido");
                    }
                }
            }
            else if (radioButton2.Checked == true)
            {
                for (int j = 0; j < ControleDados.cont; j++)
                {
                    pj = (PJuridica)ControleDados.vet[j];
                    if (id == pj.CNPJ)
                    {
                        pj.Excluir = true;
                        label4.Text = ("O contribuinte com a identidade " + id + " foi excluido");
                        MessageBox.Show("O contribuinte com a identidade " + id + " foi excluido");
                    }
                    else
                    {
                        label4.Text = ("Contribuinte Inexistente ou Excluido");
                        MessageBox.Show("Contribuinte Inexistente ou Excluido");
                    }
                }
            }
            else { MessageBox.Show("Campo de preenchimento Invalido"); }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String aux;
            PFisica pf;
            PJuridica pj;
            try
            {
                aux = textBox1.Text;
                if (radioButton1.Checked == true)
                {
                    for (int i = 0; i < ControleDados.cont; i++)
                    {
                        pf = (PFisica)ControleDados.vet[i];
                        if (aux == pf.CPF)
                        {
                            label4.Text = ("Comtribuinte: " + pf.getNome() + " CPF: " + pf.CPF + " Endereço: " + pf.getendereco() + " Renda de: R$" + pf.Salario);
                        }
                        else { label4.Text = ("Contribuinte Nao Encontrado:"); }
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    for (int pos = 0; pos < ControleDados.cont; pos++)
                    {
                        pj = (PJuridica)ControleDados.vet[pos];
                        if (aux == pj.CNPJ)
                        {
                            label4.Text = ("Comtribuinte: " + pj.getNome() + " CNPJ: " + pj.CNPJ + " Endereço: " + pj.getendereco() + " Renda de: R$" + pj.Faturamento);
                        }
                        else { label4.Text = ("Contribuinte Nao Encontrado:"); }
                    }
                }

                
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dados inexistentes");
                label4.Text= ("Dados inexistentes");
            }
        }
    }
}
