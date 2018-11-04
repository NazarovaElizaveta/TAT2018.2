using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW5Car
{
    //This class add cars at list, and contains some methods for calculating values
    public class CarList
    {
        //List for store cars
        public List<Car> listCars { get; set; }
        public CarList()
        {
            List<Car> listCars = new List<Car>();
            do
            {
                Console.WriteLine("Please enter a brand: ");
                string brand = Console.ReadLine();
                Console.WriteLine("Please enter a model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Please enter a quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Car initialCar = new Car(brand, model, quantity, price);
                listCars.Add(initialCar);
            }
             while (Console.ReadLine() != "count types" || Console.ReadLine() != "count all"
                 || Console.ReadLine() != "average price" || Console.ReadLine() != "average price type"
                 || Console.ReadLine() != "exit");
         
        }
        //This method calculate and return value of average price
        public double AveragePrice()
        {
            int carCounter = 0;
            double averPrice = 0;
            foreach (Car i in listCars)
            {
                carCounter++;
                averPrice += i.price;
            }
            averPrice = averPrice / carCounter;
            return (averPrice);
        }
        //This method calculate and return value of average price by type
        public double AveragePriceType(string brand)
        {
            int carCounter = 0;
            double averPriceType = 0;
            foreach (Car i in listCars)
            {
                if (i.brand == brand)
                {
                    carCounter++;
                    averPriceType += i.price;
                }
            }
            averPriceType = averPriceType / carCounter;
            return (averPriceType);
        }
        //This method calculate and return value of count types
        public int CountTypes(string brand)
        {
            int TypeCounter = 0;
            foreach (Car i in listCars)
            {
                if (i.brand == brand)
                {
                    TypeCounter++;
                }
            }
            return (TypeCounter);
        }
        //This method calculate and return value of count all cars
        public int CarCounter()
        {
            int counter = 0;
            foreach (Car i in listCars)
                counter++;
            return (counter);
        }
    }
}


