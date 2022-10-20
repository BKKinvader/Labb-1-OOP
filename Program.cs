using System;

namespace Labb_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirkel 1");
            Circle c1 = new Circle(5,5); // Skickar 5 till class Circle
            Console.WriteLine("Area");
            c1.getArea();// Executing c1 genom att kalla på metoden från klassen Circle
            Console.WriteLine("Omkrets");
            c1.getcircumference();
            Console.WriteLine("Volym");
            c1.getvolume();

            Console.WriteLine("----------------&&---------------");

            Console.WriteLine("Cirkel 2");
            Circle c2 = new Circle(6,5);// Skickar 6 till class Circle
            Console.WriteLine("Area");
            c2.getArea();// Executing c2 genom att kalla på metoden från klassen Circle
            Console.WriteLine("Omkrets");
            c2.getcircumference();
            Console.WriteLine("Volym");
            c2.getvolume();



        }
    }
}
