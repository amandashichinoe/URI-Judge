using System;

namespace _2779 //Album da Copa
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine()); // espaço de figurinhas no álbum
            int [] album = new int[N];
            int M = Int32.Parse(Console.ReadLine()); //figurinhas ja compradas
            
            for(int i=0; i<M; i++){
                int X = Int32.Parse(Console.ReadLine());
                if(album[X-1]==0){
                    album[X-1] = X;
                    N -=1;
                }
            }
            Console.WriteLine(N);
        }
    }
}
