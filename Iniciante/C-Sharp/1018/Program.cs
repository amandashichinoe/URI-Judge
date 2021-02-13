using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = Int32.Parse(Console.ReadLine());
            int aux = A;

            int notas100 = aux/100;
            aux-= notas100*100;

            int notas50 = aux/50;
            aux-= notas50*50;

            int notas20 = aux/20;
            aux-= notas20*20;

            int notas10 = aux/10;
            aux-= notas10*10;

            int notas5 = aux/5;
            aux-= notas5*5;
            
            int notas2 = aux/2;
            aux-= notas2*2;

            int notas1 = aux;

            Console.WriteLine(A);
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
        }
    }
}
