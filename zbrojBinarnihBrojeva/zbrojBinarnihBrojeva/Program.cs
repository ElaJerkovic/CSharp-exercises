using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zbrojBinarnihBrojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            int binaryNumber1, binaryNumber2;
            int i = 0, temp = 0;
            int[] sum = new int[20];

            Console.WriteLine("Enter the first binary number: ");
            binaryNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second binary number: ");
            binaryNumber2 = int.Parse(Console.ReadLine());

            while(binaryNumber1 != 0 || binaryNumber2 != 0)
            {
                sum[i] = (binaryNumber1 % 10 + binaryNumber2 % 10 + temp) % 2;
                temp = (binaryNumber1 % 10 + binaryNumber2 % 10 + temp) / 2;

                binaryNumber1 = binaryNumber1 / 10;
                binaryNumber2 = binaryNumber2 / 10;
                
                i++;
            }

            if(temp != 0)
            {
                sum[i] = temp;
            }

            while(i >= 0)
            {
                Console.WriteLine("{0} ", sum[i]);
                i--;
            }

            Console.ReadLine();
        }
    }
}
