using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Int32.Parse(Console.ReadLine()); //distancia percorrida
            double Y  = Double.Parse(Console.ReadLine()); //combustivel gasto

            double consumoMedio = X/Y;

            Console.WriteLine(consumoMedio.ToString("F3") + " km/l");
        }
    }
}
