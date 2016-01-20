using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 19.10.2013
/// <summary>
/// HEP!
/// </summary>
namespace T10
{
    class Teht10
    {
        /// <summary>
        /// Ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
        /// Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
        /// </summary>
        static void Main(string[] args)
        {
            int[] taulukko = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < taulukko.Length; i++)
            {
                Console.WriteLine(taulukko[i]);
                if (taulukko[i] % 2 == 0)
                    Console.WriteLine("HEP!");
            }
        }
    }
}
