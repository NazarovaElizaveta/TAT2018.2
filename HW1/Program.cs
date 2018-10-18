using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        private int findLengthOfLongest(string inputStr)
        {
            int maxLenght = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                StringBuilder alreadyMetSymbols = new StringBuilder();
                alreadyMetSymbols.Append(inputStr[i]);
                int j = i + 1;
                while (j < inputStr.Length && !alreadyMetSymbols.ToString().Contains(inputStr[j]))
                {
                    alreadyMetSymbols.Append(inputStr[j]);
                    j++;
                }
                if (maxLenght < alreadyMetSymbols.Length)
                    maxLenght = alreadyMetSymbols.Length;
            }
            return maxLenght;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            string s1 = Console.ReadLine();
            Console.WriteLine(program.findLengthOfLongest(s1));
    
        }
    }
}
