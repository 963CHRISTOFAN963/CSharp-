using System;

namespace Calculando_Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, velocidade;

            Console.Write("Digite a distancia percorrida: ");
            distancia = Double.Parse(Console.ReadLine());

            Console.Write("Escreva a velocidade percorrida: ");
            velocidade = double.Parse(Console.ReadLine());

            Console.WriteLine("O tempo gasto foi de:" + velocidade + distancia);

            distancia = velocidade;


            Console.ReadKey();


        }
        }
}
    