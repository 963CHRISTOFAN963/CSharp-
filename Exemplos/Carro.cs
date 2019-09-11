using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Carro
    {
        // PROPRIEDADES OU CARACTERÍSTICAS
        public string Jogos = "Pes";
        public int Ano;
       public bool Lançamentos = false;


        // MÉTODO OU AÇÕES 
         public void abrirPortas() {
            // IMAGINE QUE O ALGUÉM IRÁ ABRIR A PORTA 
            // DO CARRO E AS LUZES VÃO ACENDER.
            Lançamentos = true;


        }


        public void fecharPortas()
        {
            
                // IMAGINE QUE O PASSAGEIRO FECHOU A PORTA
                // DO CARRO E AS LUZES VÃO APAGAR.
                Lançamentos = false;
            }

             /* ESSE MÉTODO IRÁ RETORNAR UMA INFORMAÇÃO PARA O USÚARIO
              *  NESTE EXEMPLO, VAMOS IMAGINAR QUE ELE IRÁ LIGAR OS FAROIS
              *  MAS EU PRECISO SABER QUAL A INTENSIDADE. */
            public string acenderFarolAutomaticamente() {
                return "Médio";

            Console.ReadKey();

            }


        }
    }
