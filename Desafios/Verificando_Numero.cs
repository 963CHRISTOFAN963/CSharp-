using System;

namespace Verificando_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01, num02;

            Console.Write("Digite o primeiro valor: ");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            if (num01 == num02)
            {
                Console.Write("Os valores são iguais..");
            }
            else
            {
                Console.Write("Os valores são diferentes..");
            }
            Console.ReadKey();
        }
    }
}
