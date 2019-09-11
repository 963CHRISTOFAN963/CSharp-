using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_de_Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR
            //for (int i =  10; i >= 0; i --) { 
            //{
            //    Console.WriteLine("O valor de i é: " + i);



            //}

            double somatorio = 0;
            int tamanhoTurma;

            Console.WriteLine("Informe o tamanho da turma: ");
            tamanhoTurma = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine("Informe a nota do aluno {0}: ", i);
                double notaAtual = Double.Parse(Console.ReadLine());

                // somatorio = somatorio + notaAtual;
                somatorio += notaAtual;

            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("A média da turma é: " + media);






                Console.ReadKey();




            }
            
        }
    }


