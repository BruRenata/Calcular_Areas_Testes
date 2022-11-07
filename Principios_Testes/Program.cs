using System;

namespace Formas_Geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo Circulo01 = new Circulo();
            Circulo01.PegarMedida();
            Circulo01.CalcularArea();
            Circulo01.ExibirArea();

            Quadrado Quadrado01 = new Quadrado();
            Quadrado01.PegarMedida();
            Quadrado01.CalcularArea();
            Quadrado01.ExibirArea();

            Retangulo Retangulo01 = new Retangulo();
            Retangulo01.PegarMedida();
            Retangulo01.CalcularArea();
            Retangulo01.ExibirArea(); 

            Triangulo Triangulo01 = new Triangulo();
            Triangulo01.PegarMedida();
            Triangulo01.CalcularArea();
            Triangulo01.ExibirArea();


        }
    }
}
