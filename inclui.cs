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
    public partial class inclui : Form
    {
        public inclui()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nome = null, end = null, id = null,date;
            int tipo,k=0;
            double sal = 0;
            PFisica pf;
            PJuridica pj;

            nome = textBox1.Text +" "+ textBox2.Text; 
            end = textBox3.Text +" "+ textBox4.Text;

            if ((nome.Length > 0))
            {
                if ((end.Length > 0))
                {
                    if (radioButton1.Checked == true)
                    {
                        tipo = 1;
                        id = textBox5.Text;

                        if (ControleDados.cont == 0)
                        { k = 0; }

                        else if (ControleDados.cont > 0)
                        {
                            for (int m = 0; m < ControleDados.cont; m++)
                            {
                                pf = (PFisica)ControleDados.vet[m];

                                if (pf.CPF == id)
                                { k++; }
                            }
                        }
                        if (k == 0)
                        {
                            try { sal = double.Parse(textBox6.Text); }
                            catch (System.FormatException) { label11.Text = ("Valor Invalido"); }

                            pf = new PFisica(nome, end, sal, id,1);

                            ControleDados.vet[ControleDados.cont] = pf;
                            ControleDados.vet[ControleDados.cont].Excluir = false;
                            ControleDados.vet[ControleDados.cont].Dado = false;
                            ControleDados.cont++;
                            MessageBox.Show("Contribuinte incluido com sucesso");
                            label12.Text = ("Contribuinte incluido com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Cpf existente,não foi possivel incluir o contribuinte");
                            label12.Text = ("Cpf existente,não foi possivel incluir o contribuinte");
                            k = 0;
                        }
                    }
                    else if (radioButton2.Checked == true)
                    {
                        tipo = 2;
                        id = textBox5.Text;

                        if (ControleDados.cont == 0)
                        { k = 0; }
                        else if (ControleDados.cont > 0)
                        {
                            for (int m = 0; m < ControleDados.cont; m++)
                            {
                                pj = (PJuridica)ControleDados.vet[m];

                                if (pj.CNPJ == id)
                                { k++; }
                            }
                        }
                        if (k == 0)
                        {
                            try { sal = double.Parse(textBox6.Text); }
                            catch (System.FormatException) { label11.Text = ("Valor Invalido"); }

                            pj = new PJuridica(nome, end, sal, id,2);

                            ControleDados.vet[ControleDados.cont] = pj;
                            ControleDados.vet[ControleDados.cont].Excluir = false;
                            ControleDados.vet[ControleDados.cont].Dado = false;
                            ControleDados.cont++;
                            MessageBox.Show("Contribuinte incluido com sucesso");
                            label12.Text = ("Contribuinte incluido com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Cnpj existente,não foi possivel incluir o contribuinte");
                            label12.Text = ("Cnpj existente,não foi possivel incluir o contribuinte");
                            k = 0;
                        }
                    }
                }
                else { label7.Text = ("Endereço Invalido"); }
            }
            else
            {
                label4.Text=("Nome invalido");
            }
        }
    }
}
