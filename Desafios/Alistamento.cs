using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo = "M";
            int idade = 18;

            Console.WriteLine("Digite o sexo(M/F): ");
            sexo = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            idade = Convert.ToInt32(Console.ReadLine());

            if (sexo == "M" & idade == 18)
            {

                Console.WriteLine("Você deve se alistar!");
            }
            else { 
            
                Console.WriteLine("Você não precisa se alistar!");
            }


            Console.ReadKey();    








            
        }
    }
}