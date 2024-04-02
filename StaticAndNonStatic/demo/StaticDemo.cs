using System;

namespace demo
{
    internal class StaticDemo
    {
        //...Static field
        public static int staticField = 10;

        //...Non-static field
        public int nonStaticField = 5;

        //...Static property
        public static int StaticProperty { get; set; }

        //...Non-static property
        public int NonStaticProperty { get; set; }

        //...Static constructor
        static StaticDemo()
        {
            Console.WriteLine("Static Constructor Called : ");
        }

        //...Noon-static constructor
        public StaticDemo()
        {
            Console.WriteLine("Non-Static Constructor Called : ");
        }

        //...Static method
        public static void StaticMethod()
        {
            Console.WriteLine("Static method called : ");
        }

        //...Non-static method
        public void NonStaticMethod()
        {
            Console.WriteLine("Non-static method called : ");
        }
    }

    public static class StaticClass
    {
        public static void StaticMethodInStaticClass()
        {
            Console.WriteLine("Static method in static class : ");
        }
    }

    class Program
    {
        static void Main()
        {
            //...Accessing static field
            Console.WriteLine($"Static field value: {StaticDemo.staticField}");

            //...Setting and Getting static property
            StaticDemo.StaticProperty = 20;
            Console.WriteLine($"Static property value: {StaticDemo.StaticProperty}");

            // Creating an instance of the class
            StaticDemo demo = new StaticDemo();

            // Accessing non-static field
            Console.WriteLine($"Non-static field value: {demo.nonStaticField}");

            // Setting and getting non-static property
            demo.NonStaticProperty = 15;
            Console.WriteLine($"Non-static property value: {demo.NonStaticProperty}");

            // Calling static method
            StaticDemo.StaticMethod(); 

            // Calling non-static method
            demo.NonStaticMethod();

            // Calling static method in a static class
            StaticClass.StaticMethodInStaticClass();

        }
    }
}
