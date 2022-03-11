using System;

namespace BrunettiVettoriNumero2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ci sono 100 valori casuali, stampo quelli superiori a 50!");
            const int dim = 100;
            int[] valore = new int[dim];
            int cont = 0;
            Random C = new Random();
            for (int i = 0; i < dim; i += 1)
            {
                int g = C.Next(1, 100);
                valore[i] = g;
                if (valore[i] > 50)
                {
                    cont = cont + 1;
                }
            }
            Console.WriteLine($"Sono stati trovati {cont} numeri superiori a 50!");
        }
    }
}
