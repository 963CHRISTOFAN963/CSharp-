using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_vars
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma letra ou número");
            int codigoASCII = Console.Read();

            /*
             * QUANDO PRECISAMOS CONVERTER UM DADO EM OUTRO TIPO;
             * PODEMOS FAZER O CAST DELE, CONFORME ABAIXO
             */
            char caractere = (char)codigoASCII;
            

            Console.WriteLine(codigoASCII + " é o código ASCII correspondente do caractere " + caractere);

            Console.ReadKey();
        }   
    }
}
