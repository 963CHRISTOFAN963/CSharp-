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
            int avaliacao;

            Console.Write("Avalie o atendimento com nota de 0 até 5: ");
            avaliacao = Convert.ToInt32(Console.ReadLine());

            switch (avaliacao)
            {
                case 0:

                    Console.WriteLine("Péssimo!");
                    break;
                case 1:
                    Console.WriteLine("Muito ruim!");
                    break;
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                    Console.WriteLine("Regular!");
                    break;
                case 4:
                    Console.WriteLine("Bom!");
                    break;
                case 5:
                    Console.WriteLine("Ótimo!!");
                    break;
                default:
                    Console.WriteLine("Nota inválida!");
                    break;

            }



                    Console.ReadKey();



            }      

        }
    }

