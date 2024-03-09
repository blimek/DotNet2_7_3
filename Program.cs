using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę :");
            int liczba = Int32.Parse(Console.ReadLine());
            if (liczba > 0)
            {

                Console.WriteLine("Podana liczba jest liczbą dodatnią ");

            }

            else
            {
                Console.WriteLine("podana licznba jest liczbą ujemną ");
            }
            Console.ReadLine();


        }
    }
}
