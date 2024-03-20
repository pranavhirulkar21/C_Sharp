using System;

namespace ClassesAndObjects
{
    internal class Program
    {

        class Car
        {
            /*
            string color = "Black";

            static void Main(string[] args)
            {
                Car newcar = new Car();
                Console.WriteLine(newcar.color);
            }
            

            static void Main(string[] args)
            {
                CarProperty car1 = new CarProperty();
                Console.WriteLine("");
                Console.WriteLine("The color of car is: "+car1.color);
                Console.WriteLine("The type of car is: "+car1.type);

            }
            */

            string color;
            int maxSpeed;
            string type;

            static void Main(string[] args)
            {
                /*
                Car car = new Car();
                car.color = "White";
                car.maxSpeed = 300;

                Console.WriteLine("The color of car is: "+car.color);
                Console.WriteLine("The max speed of car is: "+car.maxSpeed);
                */

                Car BMW = new Car();
                BMW.color = "Purple";
                BMW.maxSpeed = 400;
                BMW.type = "Manual";

                Car Tesla = new Car();
                Tesla.color = "White";
                Tesla.maxSpeed = 250;
                Tesla.type = "Automatic";

                Console.WriteLine(BMW.type);
                Console.WriteLine(Tesla.type);

            }
        }
    }
}
