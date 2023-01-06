using System;

namespace terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double larg, comp, valorMM, area, preco;
            
            System.Console.WriteLine("Digite a largura do terreno:");
            larg = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o comprimento do terreno:");
            comp = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite o valor do metro quadrado:");
            valorMM = double.Parse(Console.ReadLine());

            
            area = larg * comp;
            preco = valorMM * area;

            System.Console.WriteLine("preco do terreno = " + preco.ToString("F2"));

        }
    }
}
