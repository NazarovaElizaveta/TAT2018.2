using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5Car
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarList CarCounter = new CarList();
            CarList CountTypes = new CarList();
            CarList AveragePrice = new CarList();
            CarList AveragePriceType = new CarList();
            Console.WriteLine("Please, enter command: count types / count all / average price / avarege price type / exit");
            string command = Console.ReadLine();
            switch (command)
            {
                case "count types":
               Console.WriteLine (CountTypes);
            break;
                case "count all":
            Console.WriteLine(CarCounter);
            break;
                case "average price":
            Console.WriteLine(AveragePrice);
            break;
                case "average price type":
            Console.WriteLine(AveragePriceType);
            break;
                case "exit":
            break;
            }


        }
  
    }
}

