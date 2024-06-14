
using System;

namespace InterfacePart
{
    interface IMovable
    {
        public void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }


    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    public class Program
    {

        public static void Main()
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
