using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO AS VARIÁVEIS
            int a, b;

            // SOLICITANDO AO USUÁRIO QUE DECLARE AS VARIÁVEIS
            Console.Write("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Clear(); // LIMPANDO O CONSOLE

            
            if (a > b)
            { 
                Console.WriteLine("O primeiro valor é maior que o segundo!");
            }
            else
            { 
                Console.WriteLine("O segundo valor é maior que o primeiro!");
            }

            // AGUARDANDO QUE O USUÁRIO DIGITE ALGUMA TECLA PARA ENCERRAR O PROGRAMA
            Console.ReadKey();
        }
    }
}
