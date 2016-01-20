using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 6.10.2013
/// <summary>
/// Taulukon kääntäminen
/// </summary>
namespace T12
{
    class Teht12
    {
        /// <summary>
        /// Ohjelma kysyy käyttäjältä 5 numeroa, sijoittaa ne taulukkoon ja tulostaa käänteisessä järjestyksessä
        /// </summary>
        static void Main(string[] args)
        {
            int[] taulukko = new int[5];

            for (int i = 0; i < taulukko.Length; i++)
            {
                Console.Write("Anna luku > ");
                taulukko[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < taulukko.Length / 2; i++)
            {
                int tmp = taulukko[i];
                taulukko[i] = taulukko[taulukko.Length - i - 1];
                taulukko[taulukko.Length - i - 1] = tmp;
            }

            Console.Write("Luvut käänteisessa järjestyksessä ovat ");
            for (int i = 0; i < taulukko.Length; i++)
            {
                if (i < taulukko.Length - 1)
                    Console.Write(taulukko[i] + ", ");
                else
                    Console.WriteLine("ja " + taulukko[i]);
            }
        }
    }
}