using System;

namespace idades
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            
            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.WriteLine("Nome:");
            nome1 = Console.ReadLine();
            System.Console.WriteLine("Idade:");
            idade1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa:");
            System.Console.WriteLine("Nome:");
            nome2 = Console.ReadLine();
            System.Console.WriteLine("Idade:");
            idade2 = int.Parse(Console.ReadLine());

            media = (double)(idade1 + idade2) / 2;

            System.Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1") + " anos");

        }
    }
}
