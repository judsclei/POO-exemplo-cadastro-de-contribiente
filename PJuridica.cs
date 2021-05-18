using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contribuinte
{
    public class PJuridica : Contribuintes
    {
        protected String cnpj;
        protected double faturamento;
        private int tipo;

        public PJuridica()
        {

        }

        public PJuridica(String n, string end, double f, String c,int tipo)
        {
            // this.tipo = t;
            this.nome = n;
            this.endereco = end;
            this.faturamento = f;
            this.cnpj = c;
            this.tipo = tipo;
            //this.excluir = s;
            // inicialização das varáveis de instância
        }
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public double Faturamento
        {
            get { return faturamento; }
            set { faturamento = value; }
        }
        public override double calcImposto()
        {
            double im;
            if (faturamento > 0)
            {
                im = faturamento / 10;
                return (im);
            }
            else
            {
                im = 0.0;
                return (im);
            }
            // Cálculo do imposto
        }

        //Método criado apenas para realizar os testes citados acima como verdadeiro ou falso.

        public static bool calcImpostoPJ(double imp)
        {
            if (imp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            // Cálculo do imposto
        }

    }
}
