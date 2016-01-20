using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// @author Saara
/// @version 19.10.2013
/// <summary>
/// Karkausvuosi
/// </summary>
namespace T7
{
    class Teht7
    {
        /// <summary>
        /// Ohjelma näyttää onko annettu vuosi karkausvuosi
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Anna vuosi > ");
            int vuosi = int.Parse(Console.ReadLine());

            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0))
                Console.WriteLine("{0} on karkausvuosi!", vuosi);
            else
                Console.WriteLine("{0} ei ole karkausvuosi!", vuosi);
        }
    }
}
