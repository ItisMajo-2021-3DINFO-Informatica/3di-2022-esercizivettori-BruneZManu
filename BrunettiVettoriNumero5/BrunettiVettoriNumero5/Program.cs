using System;

namespace BrunettiVettoriNumero5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo 1000 valori casuali tra 0 e 250 e stampo quelli che in percentuale sono minori di 175!");
            const int dim = 1000;
            decimal[] valore = new decimal[dim];
            Random C = new Random();
            decimal cont = 0;
            for (int i = 0; i < dim; i += 1)
            {
                decimal g = C.Next(0, 251);
                valore[i] = g;
                if (valore[i] < 176)
                {
                    cont = cont + 1;
                }
            }
            decimal perc = cont * 100 / dim;
            Console.WriteLine($"I numeri inferiori a 175 sono {cont} e la percentuale è {perc}");
        }
    }
}
