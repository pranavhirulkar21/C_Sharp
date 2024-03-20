using System;

namespace Constructors
{

    class Details
    {
        public string Name
        { get; set; }
    }
    internal class Car
    {
        /*
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        static void Main(string[] args)
        {
            Car Audi = new Car("A3", "White", 2015);
            Console.WriteLine(Audi.color+" "+Audi.model+" "+Audi.year);
        }
        */
        static void Main(string[] args)
        {
            Details carX = new Details();
            carX.Name = "MyCar";
            Console.WriteLine(carX.Name);
        }


    }
}
