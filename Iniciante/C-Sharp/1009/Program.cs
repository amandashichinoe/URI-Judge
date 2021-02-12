using System;
using System.IO;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = Double.Parse(Console.ReadLine());
            double totalVendas = Double.Parse(Console.ReadLine());

            double TOTAL = salario + totalVendas*0.15;

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2"));
        }
    }
}
