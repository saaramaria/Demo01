using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 20.10.2013
/// <summary>
/// Mäkihyppyä
/// </summary>
namespace T13
{
    class Teht13
    {
        /// <summary>
        /// Ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, 
        /// että summasta on vähennetty pois pienin ja suurin tyylipiste.
        /// </summary>
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            int summa = 0;

            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.Write("Anna pisteet > ");
                pisteet[i] = int.Parse(Console.ReadLine());
                summa += pisteet[i];
            }

            int pienin = pisteet[0];
            int suurin = pisteet[0];

            foreach (int arvo in pisteet)
            {
                if (arvo < pienin) pienin = arvo;
                if (arvo > suurin) suurin = arvo;
            }

            int kokpisteet = summa - (pienin + suurin);

            Console.WriteLine("Kokonaispisteet " + kokpisteet);
        }
    }
}
