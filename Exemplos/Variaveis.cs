using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
           
           // TRABALHANDO COM BYTE - DE 0 ATÉ 255

            // DECLARANDO AS VARIÁVEIS
            byte meuByte; // FORMA ABREVIDA
            System.Byte meuByteDois; // FORMA COMPLETA

            // DECLARANDO E ATRIBUINDO UM VALOR PARA A VAR 
            byte meuByteTres = 33;

            // TRABALHANDO COM SBYTE
            sbyte meuSbyte = -128;                 

            // ATRIBUINDO VALORES
            meuByte = 9;
            meuByteDois = 24;

            /* SHORT, INT E LONG*/

            short minhaVarDoTipoShort = 10;
            System.Int16 minhaVarDoTipoShortDois = 20;

            // INT
            int minhaVarDoTipoInteiro;
            System.Int32 minhaVarDoTipoInteiro32;

            long minhaVarDoTipoLong;
            System.Int64 minhaNovaVarDoTipoLong64;

            Console.WriteLine(minhaVarDoTipoShort + minhaVarDoTipoShortDois);
            Console.ReadKey();


        }
    }
}
