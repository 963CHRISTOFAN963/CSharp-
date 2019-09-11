using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidade, valorUnit;
            string nomeProduto;
            char tecla;

            Console.Write("Digite o nome do produto: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Digite a quantidade do produto: ");
            quantidade = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor unitário do produto: ");
            valorUnit = Double.Parse(Console.ReadLine());

            Console.WriteLine("O total a pagar por " + quantidade + " do produto " + nomeProduto + " é de R$" + (valorUnit * quantidade));

            Console.ReadKey();

        }


    }
}
