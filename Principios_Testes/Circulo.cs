using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    public class Circulo : Forma_Geometrica
    {
        public double raio { set; get; }

        public double area { set; get; }

        public static double CalculoArea(double R)
        {
            double resultado = Math.PI * (Math.Pow(R, 2));
            return resultado;
        }

        public override void PegarMedida()
        {
            try
            {
                double raioDigitado = Utilitarios.RetornarNumeroDouble("Digite o raio", "Erro, valor invalido, digite novamente");
                raio = raioDigitado;

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
                area = CalculoArea(raio);
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
                Console.WriteLine($"A Area do Circulo é {area.ToString("N2")}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }

        }
    }
}
