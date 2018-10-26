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
            const int maxBase = 20;
            const int minBase = 2;
            int decNum = Convert.ToInt32(Console.ReadLine()); //Input Decimal number
            int toBase = Convert.ToInt32(Console.ReadLine()); //Input base of new system
            //Array which stores the characters of the number in the new number system
            List<char> convertingNumber = new List<char>(); 
            if (decNum >= 0 && (toBase >= minBase && toBase <= maxBase))
            {
                ConvertDecToOtherSystem(decNum, toBase, convertingNumber);
                OutputNumberInNewSystem(convertingNumber);
            }
            else throw new Exception("Wrong decimal number or base new system!");
        }
        //This function converts the decimal number to the number of the new system
        static void ConvertDecToOtherSystem(int decNum, int toBase, List<char> convertingNumber)
        {
            //String with characters which will be compared with inputing
            //base of new system
            string stringOfBase = "0123456789ABCDEFGHIJ"; 
            while (decNum >= toBase)
            {
                int index = decNum % toBase;
                convertingNumber.Add(stringOfBase[index]);
                decNum = (decNum - (decNum % toBase)) / toBase;
            }
            convertingNumber.Add(stringOfBase[decNum]);
        }
        //This function output converted number in new number system
        static void OutputNumberInNewSystem(List<char> convertedNumber)
        {
            for (int i = convertedNumber.Count - 1; i >= 0; i--)
            {
                Console.Write(convertedNumber[i]); 
            }
        }
    }
}
