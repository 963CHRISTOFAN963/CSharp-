using System;

namespace Condicional_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int salarios;

            Console.Write("Digite o nome do salario desejado ");
            salarios = Convert.ToInt32(Console.ReadLine());

            if (salarios <= 2000)
            {

                Console.Write("Candidato selecionado para a primeira fase!");
            }

            else
            {
                Console.Write("Candidato não possui os requisitos");

            }
            Console.ReadKey();
        }
    }

}