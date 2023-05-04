using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.IsValid("{[]([])}"));
            Console.ReadLine();
        }

    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            int n = 0;
            while(s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("[]", "");
                s = s.Replace("{}", "");
            }

            if (s.Length == 0) return true;
            else return false;
        }
    }
}
