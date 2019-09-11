using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota01, nota02, nota03, nota04, media;

            Console.Write(" Digite a primeira nota: ");
            nota01 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a segunda nota: ");
            nota02 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a terceira nota: ");
            nota03 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite a nota nota: ");
            nota04 = Convert.ToInt32(Console.ReadLine());

            media = (nota01 + nota02 + nota03 + nota04) / 4;

            Console.WriteLine(" O aluno teve média " + media);

            Console.ReadKey();
        }
    }
}
