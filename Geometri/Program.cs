using System;

namespace Geometri
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            // Exercise A

            Square square = new Square(2);
            Console.WriteLine("Perimeter of square with side length of 2: " + square.Perimeter());

            Square largeSquare = new Square(800);
            Console.WriteLine("If the square instead had sides of length 800, the perimeter would be: " + largeSquare.Perimeter());

            Square tinySquare = new Square(0.0001);
            Console.WriteLine("A tiny square with side lenghts of 0.0001 would have a perimeter of: " + tinySquare.Perimeter());

            Console.WriteLine("Area of square width side length 2 = " + square.Area());
            Console.WriteLine("Area of square width side length 800 = " + largeSquare.Area());
            Console.WriteLine("Area of square width side length 0.0001 = " + tinySquare.Area());

            // Exercise B

            square.Side = 64;
            Console.WriteLine("square now has a side length of 64. Its perimeter is now: " + square.Perimeter());
            Console.WriteLine("Its area is now: " + square.Area());
        }
    }
}