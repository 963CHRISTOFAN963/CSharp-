using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ímpar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("####### NÚMEROS PAR E ÍMPAR #######");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");


            int x = 12030450;
            // SOLICITANDO AO USUÁRIO QUE DECLARE AS VARIÁVEIS
            Console.Write("Digite o primeiro número : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // LIMPANDO O CONSOLE



            if (x % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            }
            else
            {
                Console.WriteLine("Esse número é ímpar ");
            }

            Console.ReadKey();


            }
    }
}
