using System;

namespace retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, b, area, perimetro, diagonal, somaQuadrados; // vou usar b para base, pois aparentemente base é uma palavra reservada de uma classe
            
            System.Console.WriteLine("Digite a base do retangulo:");
            b = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a altura do retangulo:");
            altura = double.Parse(Console.ReadLine());

            area = b * altura;
            perimetro = (2 * b) + (2 * altura);
            somaQuadrados = System.Math.Pow(b, 2) + System.Math.Pow(altura, 2); // teorema de pitagoras realizando a soma do quadrado dos catetos
            diagonal = System.Math.Sqrt(somaQuadrados); // raiz da soma dos quadrados

            System.Console.WriteLine("AREA = " + area.ToString("F4"));
            System.Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
            System.Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));

        }
    }
}
