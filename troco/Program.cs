using System;

namespace troco
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdComprada;
            double precoUni, valorRecebido, precoTotal, troco;
            
            System.Console.WriteLine("Preço unitário do produto:");
            precoUni = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Quantidade comprada:");
            qtdComprada = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dinheiro recebido:");
            valorRecebido = double.Parse(Console.ReadLine());

            precoTotal = precoUni * qtdComprada;

            troco = valorRecebido - precoTotal;

            System.Console.WriteLine("TROCO = " + troco.ToString("F2"));

        }
    }
}
