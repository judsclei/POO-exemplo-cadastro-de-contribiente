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
    public partial class imprimec : Form
    {
        public imprimec()
        {
            InitializeComponent();
        }

        private void imprimec_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            PFisica pf;
            PJuridica pj;
            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    l.Items.Clear();
                    for (int aux = 0; aux < ControleDados.cont; aux++)
                    {
                        if (ControleDados.vet[aux].Dado == false && ControleDados.vet[aux].Excluir == false)//verifca o tipo de pessoa do vetor e se a conta existe 
                        {
                            pf = (PFisica)ControleDados.vet[aux];

                            l.Items.Add("Nome: " + pf.getNome() + " Endereco: " + pf.getendereco() + " Cpf: " + pf.CPF);
                            x++;
                        }
                    }
                }
                catch (System.InvalidCastException)
                {
                    MessageBox.Show("Erro");
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    l.Items.Clear();
                    for (int pos = 0; pos < ControleDados.cont; pos++)
                    {
                        if (ControleDados.vet[pos].Dado == false && ControleDados.vet[pos].Excluir == false)//verifca o tipo de pessoa do vetor e se a conta existe 
                        {
                            pj = (PJuridica)ControleDados.vet[pos];

                            l.Items.Add("Nome: " + pj.getNome() + " Endereco: " + pj.getendereco() + " CNPJ: " + pj.CNPJ);
                            x++;
                        }
                    }
                }
                catch (System.InvalidCastException)
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            l.Items.Clear();
        }
    }
}
