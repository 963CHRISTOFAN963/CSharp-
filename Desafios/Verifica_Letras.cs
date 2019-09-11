using System;

namespace Validando_Letras
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b;
            Console.Write("Digite a primeira letra: ");
            a = char.Parse(Console.ReadLine());

            Console.Write("Digite a segunda letra: ");
            b = char.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Os valores são iguais..");

            }
            else
            {
                Console.WriteLine("Os valores são diferentes");

            }
            Console.ReadKey();


        }
    }

}