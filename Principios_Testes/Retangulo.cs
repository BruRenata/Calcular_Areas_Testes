using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    public class Retangulo : Forma_Geometrica
    {
        public double lado1 { set; get; }
        public double lado2 { set; get; }
        public double area { set; get; }

        public static double CalculoArea(double L1, double L2)
        {
            double resultado = L1 * L2;
            return resultado;
        }


        public override void CalcularArea()
        {
            try
            {

                area = CalculoArea(lado1, lado2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }

        }

        public override void PegarMedida()
        {
            try
            {

                lado1 = Utilitarios.RetornarNumeroDouble("Digite o 01º lado do Retangulo", "Erro, digite novamente o 01º lado do Retangulo");

                lado2 = Utilitarios.RetornarNumeroDouble("Digite o 02º lado do Retangulo", "Erro, digite novamente o 02º lado do Retangulo");
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
                Console.WriteLine($"A Area do retangulo é {area.ToString("N2")}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }

        }
    }
}
