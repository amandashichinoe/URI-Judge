using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = Int32.Parse(Console.ReadLine());
            int horas = segundos/3600;
            segundos-= horas * 3600;
            int minutos = segundos/60;
            segundos-= minutos * 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            
            
        }
    }
}
