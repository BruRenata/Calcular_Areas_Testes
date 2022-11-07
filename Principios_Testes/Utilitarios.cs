using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    public class Utilitarios
    {
        public static int RetornarNumeroInteiro(string msgSolicitacao, string msgErro)
        {
            string numeroStr = "";
            int numero = 0;
            while (true)
            {
                Console.WriteLine(msgSolicitacao);
                numeroStr = Console.ReadLine();

                if (!int.TryParse(numeroStr, out numero))
                {
                    Console.WriteLine(msgErro);
                }
                else
                {
                    break;
                }
            }

            return numero;
        }


        public static double RetornarNumeroDouble(string msgSolicitacao, string msgErro)
        {
            string numeroStr = "";
            double numero = 0;
            while (true)
            {
                Console.WriteLine(msgSolicitacao);
                numeroStr = Console.ReadLine();

                if (!double.TryParse(numeroStr, out numero))
                {
                    Console.WriteLine(msgErro);
                }
                if (numero < 0)
                {
                    Console.WriteLine("Número não pode ser negativo");
                }
                else
                {
                    break;
                }
            }

            return numero;
        }
    }
}
