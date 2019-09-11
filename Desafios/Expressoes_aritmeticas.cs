using System;

namespace Expressoes_aritmeticas1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, z, t; 

            a = (29 + 30);
            b = (55 - 27);
            c = (99 * 12);
            d = (100 / 2);
            z = Math.Pow(2, 10); 
            t = a + b + c + d * z;

            Console.WriteLine("Valor de 'a': " + a);
            Console.WriteLine("Valor de 'b': " + b);
            Console.WriteLine("Valor de 'c': " + c);
            Console.WriteLine("Valor de 'd': " + d);
            Console.WriteLine("Valor de 'z': " + z);
            Console.WriteLine("Valor de 't': " + t);
            Console.ReadKey();


        }
    }
}
