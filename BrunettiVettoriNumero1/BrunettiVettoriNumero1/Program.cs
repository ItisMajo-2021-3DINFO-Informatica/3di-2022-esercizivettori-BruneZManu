using System;

namespace BrunettiVettoriNumero1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stampo un vettore di 400 valori compresi tra 1 e 100");

            const int dim = 400;
            
            Random t = new Random();
            int g;
            int[] num = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                g = t.Next(1, 100);
                num[i] = g;
                Console.WriteLine($" Il numero {i} è { num[i]}");
            }
        }
    }
}
