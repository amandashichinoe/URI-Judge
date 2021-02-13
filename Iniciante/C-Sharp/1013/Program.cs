using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valorA = Int32.Parse(valores[0]);
            int valorB = Int32.Parse(valores[1]);
            int valorC = Int32.Parse(valores[2]);

            int maior = (valorA + valorB + Math.Abs(valorA - valorB))/2;
            maior = (valorC + maior + Math.Abs(valorC - maior))/2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
