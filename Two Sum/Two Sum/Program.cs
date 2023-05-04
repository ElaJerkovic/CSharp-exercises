using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public class Program
    {
        static public void Main()
        {
            int[] resultOfOptimized = TwoSum(new int[] { 2, 7, 11, 2 }, 9); //Concatenates the string representations of an array of objects, using the specified separator between each member
            Console.WriteLine(string.Join(" ", resultOfOptimized));
            Console.ReadLine();
        }


        private static int[] TwoSum(int[] nums, int target)
        {
            int arrayLength = nums.Length;
            Dictionary<int, int> targetDictionary = new Dictionary<int, int>(); //deklarir dictionary di cmo vrijednost spremit na prvo misto(key), a index na drugo misto(value)

            if (nums == null || arrayLength < 2)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < arrayLength; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber; //koliko triba bit drugi broj da bi suma bila jednaka targetu

                if (targetDictionary.TryGetValue(secondNumber, out int index)){ //vraca true ako mozemo u dictionaryu nac vrijednost jednaku secondNumberu i onda u varijablu index sprema index na kojem je taj seconNumber
                    return new[]{
                    index, i
                };
                }

                targetDictionary[firstNumber] = i;
            }
            Console.WriteLine("Nema rjesenja");
            return Array.Empty<int>();
        }
    }
}
