using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcprofessor
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomeProf;
            Double quantidadeHoras, valorHora;

            Console.Write("Digite o nome do professor: ");
            nomeProf = Console.ReadLine();

            Console.Write("Digite a quantidade de horas trabalhadas por dia: ");
            quantidadeHoras = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da hora aula: ");
            valorHora = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("O professor " + nomeProf + " recebe R$" + (quantidadeHoras * valorHora) + " por dia.");

            Console.ReadKey();
        }
    }

}
