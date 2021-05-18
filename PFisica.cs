using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contribuinte
{
    public class PFisica : Contribuintes
    {
        protected String cpf;
        protected double salario;
        private int tipo;

        public PFisica()
        {

        }

        public PFisica(String nome, string end, double salario, String cpf,int tipo)
        {
            ///this.tipo = t;
            this.nome = nome;
            this.endereco = end;
            this.salario = salario;
            this.cpf = cpf;
            this.tipo = tipo;
            //this.excluir = s;
            //this.dados = dado;
            // inicialização das varáveis de instância
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public override double calcImposto()
        {
            double im;
            if (salario == 0 && salario <= 1400)
            {
                im = 0;
            }
            else if (salario > 1400 && salario <= 2100)
            {
                im = (salario * 0.1) - 100;
            }
            else if (salario > 2100 && salario <= 2800)
            {
                im = (salario * 0.15) - 270;
            }
            else if (salario > 2800 && salario <= 3600)
            {
                im = (salario * 0.25) - 500;
            }
            else
            {
                im = (salario * 0.30) - 700;
            }
            return (im);
            // Cálculo do imposto
        }

        //Método criado apenas para realizar os testes citados acima como verdadeiro ou falso.
        public static bool calcImpostoPF(double salario)
        {
            //double im;
            if (salario < 0)
            {
                return false;
            }

            else
            {
                return true;
            }
            // Cálculo do imposto
        }
    }
}
