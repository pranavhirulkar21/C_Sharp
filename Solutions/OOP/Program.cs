using System;

namespace OOP
{
    /*
    // INHERITANCE
     
    class Fruit
    {
        public string color = "Green";
        public void taste() {
            Console.WriteLine("Sweet and Sour!!!");
        }
    }

    class Healthy : Fruit
    {
        public string name = "Orange";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Healthy item1 = new Healthy();
            item1.taste();

            Console.WriteLine(item1.color+" "+item1.name);
        }
    }



    // POLYMORPHISM
    class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Animal Maks A Sound.");
        }
    }

    class Cat : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Cat Says: Meow Meow.");
        }
    }

    class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Dog Says: Bhow Bhow.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();

            animal.AnimalSound();
            cat.AnimalSound();
            dog.AnimalSound();

        }
    }



    // ABTRACTION

    abstract class Animal
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("Zzzz....");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Pig says: wee wee....");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig p = new Pig();
            p.AnimalSound();
            p.sleep();
        }
    }
    */


    // INTERFACE

    interface IVehicale
    {
        void VehicleSound();
    }

    class Bike : IVehicale
    {
        public void VehicleSound()
        {
            Console.WriteLine("The Bike sounds: Whrom Whrom...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            bike.VehicleSound();
        }
    }

}
