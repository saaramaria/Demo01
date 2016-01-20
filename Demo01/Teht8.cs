using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 6.10.2013
/// <summary>
/// Kolmen luvun suurin ja pienin
/// </summary>
namespace T8
{
    class Teht8
    {
        /// <summary>
        /// Ohjelma tulostaa, mikä syötetyistä luvuista on suurin
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Anna 1. kokonaisluku >");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Anna 2. kokonaisluku >");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Anna 3. kokonaisluku >");
            int c = int.Parse(Console.ReadLine());
            int suurinluku = Suurin(a, b, c);
            Console.WriteLine("\"" + suurinluku + "\" oli suurin luku");
            Console.ReadKey();
        }

        /// <summary>
        /// Etsitään suurinta lukua
        /// </summary>
        /// <param name="a">1. luku</param>
        /// <param name="b">2. luku</param>
        /// <param name="c">3. luku</param>
        /// <returns>Suurin luku</returns>
        public static int Suurin(int a, int b, int c)
        {
            if (a > b)
                if (a > c)
                    return a;

            if (b > a)
                if (b > c)
                    return b;

            if (c > a)
                if (c > b)
                    return c;

            return 0;
        }
    }
}
