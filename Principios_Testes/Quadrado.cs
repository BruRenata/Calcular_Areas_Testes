using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    public class Quadrado : Forma_Geometrica
    {
        public double lado { set; get; }
        public double area { set; get; }

        public static double CalculoArea(double L)
        {
            double resultado = L * L;
            return resultado;
        }




        public override void PegarMedida()
        {
            try
            {

                lado = Utilitarios.RetornarNumeroDouble("Digite o lado do Quadrado", "Erro, digite novamente o lado do quadrado");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }
        }

        public override void CalcularArea()
        {
            try
            {
                area = CalculoArea(lado);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }

        }


        public override void ExibirArea()
        {
            try
            {
                Console.WriteLine($"A Area do quadrado é {area.ToString("N2")}");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }
        }
    }
}

