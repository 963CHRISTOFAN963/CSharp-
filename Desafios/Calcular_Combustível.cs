using System;

namespace Calcular_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double abastecimento = 0;
            const double LITRO = 3.85;
            double quantidadelitros = 0;

            Console.Write("A gasolina está custando R$ 3.85, Qual o valor que deseja abastecer em litros : ");
            abastecimento = double.Parse(Console.ReadLine());

            quantidadelitros = abastecimento * LITRO;

            Console.Write("Litros abastecido com o valor de R$" + abastecimento + " foi de : " + quantidadelitros);

            Console.ReadKey();


        }
    }
}
