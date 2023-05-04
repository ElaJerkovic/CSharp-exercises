using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman;
            roman = "XIV";
            Console.WriteLine(RomanToInt(roman));
            Console.ReadLine();
        }
        public static int RomanToInt(string s)
        {
            int suma = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 &&  findValue(s[i - 1]) < findValue(s[i]))
                {
                    suma = suma + (findValue(s[i]) - findValue(s[i - 1])*2);
                }

                else
                {
                    suma = suma + findValue(s[i]);
                }
            }

            return suma;
        }
        public static int findValue(char chr)
        {
            switch (chr)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}
