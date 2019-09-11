using System;

namespace Textos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("####### EXERCÍCIOS - TEXTO #######");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

            String fraseUm = "Olá Senaciano!";
            String fraseAlterada = fraseUm.Replace("Senaciano", "vinicius!");

            Console.WriteLine(fraseUm);
            Console.WriteLine(fraseAlterada);


            String Texto;

            Console.Write("Digite uma palavra: ");
            Texto = Console.ReadLine();
            Console.Write("Sua palavra tem " + Texto.Length + " Caractéres.");


            string primeirafrase = "Olá, bom dia.  Sou aluno do Senac Vila Prudente. ";

            String frase = primeirafrase.Substring(15);
            String segundafrase = primeirafrase.Substring(28, 20);

            Console.WriteLine(" 2ª frase - " + frase);
            Console.WriteLine(" Unidade - " + segundafrase);


            Console.ReadKey();






            

        }
    }
}
