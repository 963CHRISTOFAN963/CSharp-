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
            // DO WHILE 
            string entrada;
          do  {
                // BLOCO DE COMANDOS
                Console.Write("Digite o seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo, {0}", entrada);
                Console.WriteLine("Deseja continuar?");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s") ;

            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para sair...");
            











                Console.ReadKey();




            }
            
        }
    }


