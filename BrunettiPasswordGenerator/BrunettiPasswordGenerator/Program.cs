using System;

namespace BrunettiPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int[] vettore = new int[34];
            vettore[0] = 0;
            vettore[0] = 0;
            vettore[1] = 0;
            vettore[2] = 0;
            vettore[3] = 0;
            vettore[4] = 0;
            vettore[5] = 0;
            vettore[6] = 0;
            char[] alfabeto = new char[26];
            alfabeto[0] = 'a';
            alfabeto[1] = 'b';
            alfabeto[2] = 'c';
            alfabeto[3] = 'd';
            alfabeto[4] = 'e';
            alfabeto[5] = 'f';
            alfabeto[6] = 'g';
            alfabeto[7] = 'h';
            alfabeto[8] = 'i';
            alfabeto[9] = 'l';
            alfabeto[10] = 'm';
            alfabeto[11] = 'n';
            alfabeto[12] = 'o';
            alfabeto[13] = 'p';
            alfabeto[14] = 'q';
            alfabeto[15] = 'r';
            alfabeto[16] = 's';
            alfabeto[17] = 't';
            alfabeto[18] = 'u';
            alfabeto[19] = 'v';
            alfabeto[20] = 'w';
            alfabeto[21] = 'x';
            alfabeto[22] = 'y';
            alfabeto[23] = 'z';
            alfabeto[24] = 'j';
            alfabeto[25] = 'k';




            Console.WriteLine("Indica la lunghezza della tua password!");
            int lungh = Convert.ToInt32(Console.ReadLine());


            string nuovaP = "";
            Random G = new Random();
            char[] simb = new char[12];
            simb[0] = '#';
            simb[1] = '@';
            simb[2] = '^';
            simb[3] = '?';
            simb[4] = '$';
            simb[5] = '£';
            simb[6] = '&';
            simb[7] = '/';
            simb[8] = '+';
            simb[9] = '*';
            simb[10] = '-';
            simb[11] = '§';

            string nuovaP2 = "";

            string nuovaP3 = "";

            for (int A = 0; A <=lungh; A += 1)
            {
                int genP = G.Next(1, 26);
                
                int CharC = G.Next(0, 11);
                nuovaP = nuovaP + alfabeto[genP] + genP + simb[CharC];
                nuovaP2 = nuovaP2 + genP + alfabeto[genP] + simb[CharC];
                nuovaP3 = nuovaP3 + simb[CharC] + genP + alfabeto[genP];
            }
            Random cas = new Random();
            int P = G.Next(1,3);
            Console.Write("La tua password: ");

            if (P == 1)
            {
                Console.WriteLine(nuovaP);
            }
            else if (P == 2)
            {
                Console.WriteLine(nuovaP2);
            }
            else if (P == 3)
            {
                Console.WriteLine(nuovaP3);
            }



            string []parole = new string[10];
            parole[0] = "Boh ";
            parole[1] = "è ";
            parole[2] = "kakà ";
            parole[3] = "Ronaldo ";
            parole[4] = "ronnie ";
            parole[5] = "Gigio ";
            parole[6] = "Mihail ";
            parole[7] = "Orto ";
            parole[8] = "Eros ";

            Console.WriteLine();


        }
    }
}
