using System;

namespace Ifdois
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO AS VARIÁVEIS
            double notaUm, notaDois, notaTres, notaQuatro, media;

            // SOLICITANDO AO USUÁRIO QUE DIGITE AS NOTAS
            Console.Write("Digite a primeira nota: ");
            notaUm = Double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            notaDois = Double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            notaTres = Double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            notaQuatro = Double.Parse(Console.ReadLine());

            Console.Clear(); // LIMPANDO O CONSOLE

            // CALCULANDO A MÉDIA
            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            // FAZENDO A VERIFICAÇÃO DOS VALORES DA MÉDIA
            if (media > 7) // SE
            {
                Console.WriteLine("Aluno aprovado com média " + media + ". Parabéns!");
            }
            else
            { // SENÃO
                Console.WriteLine("Aluno reprovado com média " + media + ". Favor, dedique-se mais...");
            }

            // AGUARDANDO QUE O USUÁRIO DIGITE ALGUMA TECLA PARA ENCERRAR O PROGRAMA
            Console.ReadKey();
        }
    }
}
