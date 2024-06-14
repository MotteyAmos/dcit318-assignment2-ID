using System;

interface AbstractClassesAndMethods
{

    public abstract class Shape
    {
        public abstract double GetArea();

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }


        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double GetArea()
        {
            return this.Width * this.Length;
        }
    }


    public class Program
    {
        public static void Main()
        {
            Circle circle = new Circle() { Radius = 10 };

            Console.WriteLine("The area of the circle is: " + circle.GetArea());

            Rectangle rectangle = new Rectangle() { Length = 10, Width = 20 };
            Console.WriteLine("The area of the rectangle is: " + rectangle.GetArea());

        }
    }
}