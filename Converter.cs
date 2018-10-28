using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Converter
{
    class Converter
    {
        //This method converts the decimal number to the number of the new system
        public void ConvertDecToOtherSystem(int decNum, int toBase, List<char> convertingNumber)
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
        //This method output converted number in new number system
        public void OutputNumberInNewSystem(List<char> convertedNumber)
        {
            for (int i = convertedNumber.Count - 1; i >= 0; i--)
            {
                Console.Write(convertedNumber[i]);
            }
            Console.WriteLine();
        }
    }
}
