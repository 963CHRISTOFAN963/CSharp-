using System;

namespace Validando_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.Write("Digite a nota do aluno para validação: ");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 0) if (nota <= 10)
                {

                    Console.Write("Essa nota é válida!");
                }
                else
                {
                    Console.Write("Essa nota não é valida");



                    Console.Write("Os valores são diferentes..");

                }
                    Console.ReadKey();
                }
        }
    }

