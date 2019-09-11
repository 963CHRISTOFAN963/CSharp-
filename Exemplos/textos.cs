using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textos
{
    class Program
    {
        static void Main(string[] args)
        {
            string textos  ="Olá amigos, estou muito feliz por estar aqui com cada um de vocês! Desejo a todos um ótimo dia!";
            string palavra = "um";


            //VERIFICANDO O TAMANHO DO TEXTO
            Console.WriteLine("Tamanho do texto: " + textos.Length);

            // LOCALIZANDO UMA PALAVRA
            Console.WriteLine("Localizando: " + textos.IndexOf(palavra));

            // LOCALIZANDO A POSIÇÃO DA ÚTLTIMA LETRA
            Console.WriteLine("Localizando: " + textos.LastIndexOf(palavra));


            string textoDois = "Olá amigos do Vanderlei!";
            Console.WriteLine(textoDois);

            string textoAlterado = textoDois.Replace("Vanderlei", "Zezinho");
            Console.WriteLine(textoAlterado);
            Console.WriteLine(textoDois);




            string textoTres = "Olá Turminha! Bom dia =!";

            Console.WriteLine("Verifica se começa com: " + textoTres.StartsWith("Olá"));
            Console.WriteLine("Verifica se termina com: " + textoTres.EndsWith("dia"));
            Console.WriteLine("Verificando existência: " + textoTres.Contains("Tur"));



            string textoQuatro = "Olá Galerinha de TI... Bom dia para todos";

            Console.WriteLine(textoQuatro.ToUpper());
            Console.WriteLine(textoQuatro.ToLower());






            string textoEspaco = "                   Bom dia, Turma MU!                 ";

             Console.WriteLine(textoEspaco.Length);

                // REMOVENDO O ESPAÇO EM BRANCO DO COMEÇO
            Console.WriteLine("Início: " + textoEspaco.TrimStart());
            Console.WriteLine("Início: " + textoEspaco.TrimStart().Length);

            // REMOVENDO O ESPAÇO EM BRANCO FINAL
            Console.WriteLine("Início: " + textoEspaco.TrimEnd());
            Console.WriteLine("Início: " + textoEspaco.TrimEnd().Length);

            // REMOVENDO O ESPAÇO EM BRANCO DOS DOIS LADOS 
            Console.WriteLine("Início: " + textoEspaco.Trim());
            Console.WriteLine("Início: " + textoEspaco.Trim().Length);








            string textoCinco = "Olá a todos! Desejo um Ótimo dia!";

           
            String frase = textoCinco.Substring(13);
            String Palavra = textoCinco.Substring(13, 6);

            Console.WriteLine("2 frase: " + frase);
            Console.WriteLine("Palavra" + palavra);


            Console.ReadKey();
           





        }
    }
}







