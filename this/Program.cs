using System;

namespace Constructors
{
    class Car
    {
        string brand;
        int price;
        int passengers;

        //parameterized constructor
        Car(string brand, int price, int passengers)
        {
            this.brand = brand;  
            this.price = price;
            this.passengers = passengers;
        }

        static void Main(string[] args)
        {
            //Call parameterized constructor
            Car car1 = new Car("Bugatti", 1000000, 2);
            Car car2 = new Car("Ferrari", 700000, 2);
            Car car3 = new Car("Aston Martin", 300000, 2);

            Console.WriteLine("Brand: " + car1.brand);
            Console.WriteLine("Price: " + car1.price);
            Console.WriteLine("Passengers: " + car1.passengers);
            Console.WriteLine("Brand: " + car2.brand);
            Console.WriteLine("Price: " + car2.price);
            Console.WriteLine("Passengers: " + car2.passengers);
            Console.WriteLine("Brand: " + car3.brand);
            Console.WriteLine("Price: " + car3.price);
            Console.WriteLine("Passengers: " + car3.passengers);
            Console.ReadLine();
        }
    }
}