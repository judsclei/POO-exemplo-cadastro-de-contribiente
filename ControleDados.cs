using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace contribuinte
{
    class ControleDados
    {
        public static DateTime hora;
        public static StreamWriter escritor;
        public static StreamWriter escritor2;
        public static StreamWriter escritor3;
        public static StreamReader leitor;
        public static int cont;
        const int MAXCONTRIBUINTES = 100; // número máximo de contas suportado 
        public static Contribuintes[] vet = new Contribuintes[MAXCONTRIBUINTES]; //vetor de contribuintes


    }   
}
