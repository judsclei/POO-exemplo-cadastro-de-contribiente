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
    public partial class calculac : Form
    {
        public calculac()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string id = null;
            double imposto;
            PFisica pf;
            PJuridica pj;

            try
            {
                id = textBox1.Text;
                if (comboBox1.SelectedIndex == 1)
                {
                    for (int i = 0; i < ControleDados.cont; i++)
                    {
                        if (ControleDados.vet[i].Dado == false && ControleDados.vet[i].Excluir == false)
                        {
                            pf = (PFisica)ControleDados.vet[i];
                            imposto = pf.calcImposto();

                            label4.Text = ("O valor do imposto do contribuinte com o CPF: " + pf.CPF + "é: R$ " + imposto*-1);
                        }
                        else { MessageBox.Show("Contribuinte Inrxistente"); }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    for (int pos = 0; pos < ControleDados.cont; pos++)
                    {
                        if (ControleDados.vet[pos].Dado == false && ControleDados.vet[pos].Excluir == false)
                        {
                            pj = (PJuridica)ControleDados.vet[pos];
                            imposto = pj.calcImposto();

                            label4.Text = ("O valor do imposto do contribuinte com o CNPJ: " + pj.CNPJ + "é: R$ " + imposto);
                        }
                        else { MessageBox.Show("Contribuinte Inrxistente"); }
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Insira um valoe valido");
                label3.Text = ("Insira um valoe valido");
            }
            catch (System.InvalidCastException)
            {
                MessageBox.Show("Dados inexistentes");
                label4.Text = ("Dados inexistentes");
            }
        }

        private void calculac_Load(object sender, EventArgs e)
        {

        }
    }
}
