using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe_T4_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program zwrot = new Program();
                Console.WriteLine("Wprowadz liczbe, ktorej parzystosc chcesz sprawdzic");
                var numberToCheck = int.Parse(Console.ReadLine());

                var wynik = zwrot.zwrot(numberToCheck, 2);

                if (wynik == 1)
                {
                    Console.WriteLine("Podana liczba jest nieparzysta!");
                }
                else if (wynik == 0)
                {
                    Console.WriteLine("Podana liczba jest parzysta!");
                }
            }
            catch(Exception)
            {
                throw new Exception("\nBledne dane!");
            }
        }
        public int zwrot(int a, int b)
        {
            return a % b;
        }
    }
}
