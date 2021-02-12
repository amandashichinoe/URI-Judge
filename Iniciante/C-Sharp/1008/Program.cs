using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER = Int32.Parse(Console.ReadLine());
            int horasTrabalhadas = Int32.Parse(Console.ReadLine());
            double salarioHora = Double.Parse(Console.ReadLine());

            double SALARY = horasTrabalhadas * salarioHora;

            Console.WriteLine("NUMBER = " + NUMBER + "\nSALARY = U$ " + SALARY.ToString("F2"));

        }
    }
}
