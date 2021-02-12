using System;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pecas1 = Console.ReadLine().Split(' ');
            int codPeca1 = Int32.Parse(pecas1[0]);
            int numPeca1 = Int32.Parse(pecas1[1]);
            double valorUnitario1 = Double.Parse(pecas1[2]);

            string[] pecas2 = Console.ReadLine().Split(' ');
            int codPeca2 = Int32.Parse(pecas2[0]);
            int numPeca2 = Int32.Parse(pecas2[1]);
            double valorUnitario2 = Double.Parse(pecas2[2]);

            double total = numPeca1 * valorUnitario1 + numPeca2 * valorUnitario2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));

            
        }
    }
}
