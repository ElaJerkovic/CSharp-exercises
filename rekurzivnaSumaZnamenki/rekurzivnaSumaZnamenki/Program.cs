using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzivnaSumaZnamenki
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number, result;

            Recursion suma = new Recursion();

            Console.WriteLine("Unesi broj: ");
            number = Convert.ToInt32(Console.ReadLine());

            result = suma.sum(number);
            Console.WriteLine("Zbroj znamenaka broja {0} je {1}.", number, result);

            Console.ReadLine();
        }
    }

    class Recursion
    {
        public int sum(int number)
        {
            if(number != 0)
            {
                return (number % 10 + sum(number / 10));
            }
            else
            {
                return 0;
            }
        }
    }
}
