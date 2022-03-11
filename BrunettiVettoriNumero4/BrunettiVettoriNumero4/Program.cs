using System;

namespace BrunettiVettoriNumero4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo 100 valori tra 1000 e 3000, e stampo il più grande e il più piccolo!");
            const int dim = 100;
            int[] valore = new int[dim];
            Random C = new Random();
            int valMax = 0;
            int valMin = 3001;
            
            for (int i = 0; i < dim; i++)
            {
                int g = C.Next(1000, 3000);
                valore[i] = g;
                Console.WriteLine($"Il numero è  {i} {valore[i]}");
                if (valore[i] > valMax)
                {
                    valore[i] = valMax;
                }
                else if (valore[i] < valMin)
                {
                    valore[i] = valMin ;
                }
            }
            Console.WriteLine($"Il valore più grande è {valMax} mentre il più piccolo è {valMin}.");
        }
    }
}
