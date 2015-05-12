using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter side 1 of rectangle: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2 of rectangle: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter is {0} \nArea is {1}", side1*2+side2*2, side1*side2);
        }
    }
