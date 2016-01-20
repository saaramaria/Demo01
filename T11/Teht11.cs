using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 6.10.2013
/// <summary>
/// Tähtikuvion tulostaminen
/// </summary>
namespace T11
{
    class Teht11
    {
        /// <summary>
        /// Ohjelma kysyy käyttäjältä numeron ja tulostaa sen pohjalta kuvion
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Anna luku > ");
            int luku = int.Parse(Console.ReadLine());

            for (int i = 0; i < luku; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
