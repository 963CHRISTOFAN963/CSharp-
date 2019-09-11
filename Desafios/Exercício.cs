using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textos_Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            string textos = "Olá amigos, estou muito feliz por estar aqui com cada um de vocês! Desejo a todos um ótimo dia!";
            string palavra = "um";


           

            // LOCALIZANDO A POSIÇÃO DA ÚTLTIMA LETRA
            Console.WriteLine("Localizando: " + textos.LastIndexOf(palavra));


            string textoCinco = "Olá a todos! Desejo um Ótimo dia!";


            String frase = textoCinco.Substring(13);
            String Palavra = textoCinco.Substring(13, 6);

            Console.WriteLine("2 frase: " + frase);
            Console.WriteLine("Palavra" + palavra);














        }
    }
}
