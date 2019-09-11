using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, idade01, idade02, idade03, idade04, idade05, media;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("#######      IDADE     #######");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

            Console.Write(" Digite a sua idade aluno01? ");
            idade01 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a sua idade aluno02? ");
            idade02 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a sua idade aluno03? ");
            idade03 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a sua idade aluno04?  ");
            idade04 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a sua idade aluno05? ");
            idade05 = Convert.ToInt32(Console.ReadLine());


            idade = (idade01 + idade02 + idade03 + idade04) / 4;

            Console.WriteLine("A média das idades consultadas foi: " + idade);





            Console.ReadKey();


        }
    }
}
