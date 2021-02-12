using System;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double A = Double.Parse(valores[0]);
            double B = Double.Parse(valores[1]);
            double C = Double.Parse(valores[2]);
            
            double pi = 3.14159;

            double triangulo = (A*C)/2;
            double circulo = pi*Math.Pow(C,2);
            double trapezio = ((A+B)*C)/2;
            double quadrado = Math.Pow(B,2);
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3") + "\nCIRCULO: " + circulo.ToString("F3") 
            + "\nTRAPEZIO: " + trapezio.ToString("F3") + "\nQUADRADO: " + quadrado.ToString("F3") + "\nRETANGULO: " 
            + retangulo.ToString("F3"));
        }
    }
}
