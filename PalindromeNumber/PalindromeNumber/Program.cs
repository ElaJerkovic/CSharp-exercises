using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome(0));
            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            int num = x;
            int reverse = 0;

            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            if (reverse == x && x >= 0) return true;
            else return false;
        }
    }
}
