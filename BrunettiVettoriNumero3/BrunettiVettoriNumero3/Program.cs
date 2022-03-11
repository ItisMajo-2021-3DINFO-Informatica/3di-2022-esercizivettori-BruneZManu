using System;

namespace BrunettiVettoriNumero3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stampo 30 valori compresi tra 1 e 50 e stampo anche la media!");
            const int dim = 30;
            int[] valore = new int[dim];
            int somma = 0;
            
            Random C = new Random();
            for (int i = 0; i < dim; i++)
            {
                int g = C.Next(1, 100);
                valore[i] = g;
                somma = somma + valore[i];
            }
            int media = somma / dim;
            Console.WriteLine($"La somma dei 30 numeri è {somma} e la media è {media}.");
        }
    }
}
