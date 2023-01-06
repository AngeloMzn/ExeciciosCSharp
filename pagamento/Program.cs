using System;

namespace pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int horaTrab;
            double valorHora, salario;

            System.Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            System.Console.WriteLine("Valor por hora:");
            valorHora = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Horas trabalhadas:");
            horaTrab = int.Parse(Console.ReadLine());

            salario = (double)valorHora * horaTrab;

            System.Console.WriteLine("O pagamento para " + nome + " deve ser " + salario.ToString("F2"));

        }
    }
}
