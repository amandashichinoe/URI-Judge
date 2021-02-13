using System;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoViagem = Int32.Parse(Console.ReadLine());
            int velocidadeMedia = Int32.Parse(Console.ReadLine());
            double consumoLitro = 12.0; 

            double litrosNecessarios = ((velocidadeMedia * tempoViagem)/consumoLitro);

            Console.WriteLine(litrosNecessarios.ToString("F3"));
        }
    }
}
