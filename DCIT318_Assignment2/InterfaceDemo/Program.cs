using System;

namespace InterfaceDemo
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move() => Console.WriteLine("Car is moving");
    }

    class Bicycle : IMovable
    {
        public void Move() => Console.WriteLine("Bicycle is moving");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===");

            IMovable car = new Car();
            IMovable bike = new Bicycle();

            car.Move();
            bike.Move();
        }
    }
}
