using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contribuinte
{
    public abstract class Contribuintes
    {
        protected string nome;
        protected string endereco;
        protected bool excluir;
        protected bool dado = false;

        public string getNome()
        {
            return nome;
        }
        public string getendereco()
        {
            return endereco;
        }
        public bool Excluir
        {
            get { return excluir; }
            set { excluir = value; }
        }
        public bool Dado
        {
            get { return dado; }
            set { dado = value; }
        }

       abstract public double calcImposto();
    }
}

