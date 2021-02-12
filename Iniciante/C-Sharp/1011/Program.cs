using System;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = Double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double VOLUME = (4.0/3) * pi * Math.Pow(R,3);

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3"));
        }
    }
}
