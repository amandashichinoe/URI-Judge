using System;

namespace _1002
{
    class Program // 1002 - Área do Círculo
    {
        static void Main(string[] args)
        {
            double raio = Double.Parse(Console.ReadLine());
            double n = 3.14159;
            
            double A = (n * raio * raio);

            Console.WriteLine("A=" + A.ToString("N4")); 
        }
    }
}
