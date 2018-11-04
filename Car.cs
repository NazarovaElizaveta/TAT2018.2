using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5Car
{

    public class Car 
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public Car(string brand, string model, int quantity, double price)
        {
            this.brand = brand;
            this.model = model;
            this.quantity = quantity;
            this.price = price;
            if (this.quantity <= 0)
            {
                throw new Exception("Wrong guantity. Please, enter a new value of quantity\n");
            }
            if (this.price <= 0)
            {
                throw new Exception("Wrong price. Please, enter a new value of price\n");
            }
            if (this.price.GetType() != typeof(double))
            {
                this.price = (double)this.price;
            }
        }
    }
}
