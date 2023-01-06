using System;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
                int x, y, soma;
                
                System.Console.WriteLine("Digite o valor de X:");
                x = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Digite o valor de Y:");
                y = int.Parse(Console.ReadLine());

                soma = x + y;

                System.Console.WriteLine("SOMA = " + soma);

        }
    }
}
