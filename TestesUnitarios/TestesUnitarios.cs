using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formas_Geometricas;

namespace TestesUnitarios
{
    class TestesUnitarios
    {
        public static void TesteCalcularAreaCirculo_Raio5()
        {
            double resultado = Circulo.CalculoArea(5);
            if (resultado == 78.539816339744831)
            {
                Console.WriteLine("Passou no Teste de Calculo da area do circulo");
            }
            else
            {
                Console.WriteLine("Não Passou no Teste de Calculo da area do circulo");
                Console.WriteLine("Esperado como resultado 78.539816339744831");
            }
        }

        // area circulo 78.539816339744831

        public static void TesteCalcularAreaQuadrado_4()
        {
            double resultado = Quadrado.CalculoArea(4);
            if (resultado == 16)
            {
                Console.WriteLine("Passou no Teste de Calculo da area do quadrado");
            }
            else
            {
                Console.WriteLine("Não Passou no Teste de Calculo da area do quadrado");
                Console.WriteLine("Esperado como resultado 16");
            }
        }

        public static void TesteCalcularAreaRetangulo_4_5()
        {
            double resultado = Retangulo.CalculoArea(4, 5);
            if (resultado == 20)
            {
                Console.WriteLine("Passou no Teste de Calculo da area do retangulo");
            }
            else
            {
                Console.WriteLine("Não Passou no Teste de Calculo da area do retangulo");
                Console.WriteLine("Esperado como resultado 20");
            }
        }

        public static void TesteCalcularAreaTrianguloEquilatero_5()
        {
            double resultado = Triangulo.CalcularAreaEquilatero(5, 5, 5);
            if (resultado == 12.50)
            {
                Console.WriteLine("Passou no Teste de Calculo da area do triangulo equilatero");
            }
            else
            {
                Console.WriteLine("Não Passou no Teste de Calculo da area do triangulo equilatero");
                Console.WriteLine("Esperado como resultado 12.50");
            }
        }

        public static void TesteCalcularAreaTrianguloIsosceles_5_5_10()
        {
            double resultado = Triangulo.CalcularAreaIsosceles(5, 5, 10);
            if (resultado == 25)
            {
                Console.WriteLine("Passou no Teste de Calculo da area do triangulo isosceles");
            }
            else
            {
                Console.WriteLine("Não Passou no Teste de Calculo da area do triangulo isosceles");
                Console.WriteLine("Esperado como resultado 25");
            }
        }

        public static void TesteCalcularAreaTrianguloEscaleno_7_6_12()
        {
            double resultado = Triangulo.CalcularAreaEscaleno(7, 6, 12);
            if (resultado == 14.947825928876748)
            {
                Console.WriteLine("Passou no Teste de Calculo da area do triangulo escaleno");
            }
            else
            {
                Console.WriteLine("Não Passou no Teste de Calculo da area do triangulo escaleno");
                Console.WriteLine("Esperado como resultado 14.947825928876748");
            }
        }



        // area teste trinagulo escaleno 14.947825928876748


    }
}
