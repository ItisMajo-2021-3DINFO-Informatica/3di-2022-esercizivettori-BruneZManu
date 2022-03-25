using System;

namespace BrunettiVettoriNumero6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i tempi di 8 nuotatori, ti dico chi è il migliore e lo scarto con ogni altro concorrente!");
            int dim = 8;
            decimal[] nuotatore = new decimal[dim];
            decimal[] scarti = new decimal[dim];
            decimal min = decimal.MaxValue;
            int migl=0;

            for (int c = 0; c < dim; c += 1)
            {
                Console.Write($"Inserisci il tempo del giocatore N°{c+1} = ");
                nuotatore[c] = Convert.ToDecimal(Console.ReadLine());

                if (nuotatore[c] < min)
                {
                    min = nuotatore[c];
                    migl = c;
                }
                
            }

            Console.WriteLine($"Il nuotatore migliore è il N°{migl} con il tempo di {min}s. ");

            Console.WriteLine("Gli scarti con gli altri nuotatori:");
            for (int c = 0; c < dim; c += 1)
            {       
                scarti[c] = nuotatore[c] - min;
                Console.WriteLine($"Gli scarti con il nuotatore N°{c + 1} è = {scarti[c]}.");
            }
        }
    }
}
