using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas_Geometricas
{
    public class Triangulo : Forma_Geometrica
    {
        public double lateral1 { set; get; }
        public double lateral2 { set; get; }
        public double lateral3 { set; get; }
        public double area { set; get; }

        public override void PegarMedida()
        {
            try
            {

                lateral1 = Utilitarios.RetornarNumeroDouble("Digite o comprimento do primeiro lado:", "Erro, valor invalido, digite novamente");
                Console.Write("\r");

                lateral2 = Utilitarios.RetornarNumeroDouble("Digite o comprimento do segundo lado:", "Erro, valor invalido, digite novamente");
                Console.Write("\r");

                lateral3 = Utilitarios.RetornarNumeroDouble("Digite o comprimento do terceiro lado:", "Erro, valor invalido, digite novamente");
                Console.Write("\r");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }

        }

        public static double CalcularAreaEquilatero(double L1, double L2, double L3)
        {
            double resultado = (L1 * L2) / 2;
            return resultado;
        }

        public static double CalcularAreaIsosceles(double L1, double L2, double L3)
        {
            double resultado = 0; 
            if (L1 == L2)
            {
                 resultado = (L1 * L3) / 2;
            }
            else if (L3 == L2)
            {
                 resultado = (L3 * L1) / 2;
            }
            else if (L1 == L3)
            {
                resultado = (L1 * L2) / 2;
            }

            return resultado;
        }

        public static double CalcularAreaEscaleno(double L1, double L2, double L3)
        {
            double semiperimetro = (L1 + L2 + L3) / 2;
            double p = semiperimetro;
            double Parcial1 = (p - L1);
            double Parcial2 = (p - L2);
            double Parcial3 = (p - L3);
            double Parcial = p * Parcial1 * Parcial2 * Parcial3;
            double resultado = Math.Sqrt(Parcial);
            return  resultado;
        }


        public override void CalcularArea()
        {
            try
            {

                string triangulo = "";

                if (lateral1 == lateral2 && lateral2 == lateral3)
                {
                    triangulo = "equilatero";
                    area = CalcularAreaEquilatero(lateral1, lateral1, lateral3);

                }

                else if (lateral1 == lateral2 || lateral3 == lateral2 || lateral1 == lateral3)
                {
                    triangulo = "isosceles";
                    area = CalcularAreaIsosceles(lateral1, lateral2, lateral3);
                }

                else if (lateral1 != lateral2 && lateral2 != lateral3 && lateral1 != lateral3)
                {
                    triangulo = "escaleno";
                    area = CalcularAreaEscaleno(lateral1, lateral2, lateral3);
                }

                Console.WriteLine($"o Triangulo é {triangulo}");
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
                Console.WriteLine($"A Area do Triangulo é {area.ToString("N2")}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro Inesperado: {e.Message}");
            }

        }


    }

}

