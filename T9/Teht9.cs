using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 19.10.2013
/// <summary>
/// Lukujen syöttöä
/// </summary>
namespace T9
{
    class Teht9
    {
        /// <summary>
        /// Ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0 ja tulostaa sitten lukujen summan
        /// </summary>
        static void Main(string[] args)
        {
            int summa = 0;
            int luku;

            do
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                summa += luku;
            }
            while (luku != 0);

            Console.WriteLine("Lukujen summa on " + summa);
            Console.ReadLine();
        }
    }
}
