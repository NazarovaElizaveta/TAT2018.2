using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Converter
{
    //tThis class implements a program that converts a number 
    //from the decimal number system to another by base from 2 to 20
    class ConverterForDecNumber
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            const int maxBase = 20;
            const int minBase = 2;
            Console.WriteLine("Enter a decimal number:");
            int decNum = Convert.ToInt32(Console.ReadLine()); //Input Decimal number
            Console.WriteLine("Enter a base of new system:");
            int toBase = Convert.ToInt32(Console.ReadLine()); //Input base of new system
            //Array which stores the characters of the number in the new number system
            List<char> convertingNumber = new List<char>();

            if (decNum >= 0 && (toBase >= minBase && toBase <= maxBase))
            {
                converter.ConvertDecToOtherSystem(decNum, toBase, convertingNumber);
                converter.OutputNumberInNewSystem(convertingNumber);
            }
            else throw new Exception("Wrong decimal number or base new system!");
        }
    }
}
