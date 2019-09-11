using System;

namespace Ano_Nascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double anoAtual, anoNascimento, idade;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a data do ano atual: ");
            anoAtual = Double.Parse(Console.ReadLine());

            Console.Write("Digite o ano de nascimento:");
            anoNascimento = Double.Parse(Console.ReadLine());

            idade = (anoAtual - anoNascimento);

            Console.WriteLine(" O " + nome + " Tem " + idade + " Anos de idade ");

            Console.ReadKey();







        }
    }
}
