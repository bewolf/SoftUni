using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double pi = Math.PI, area, perimeter;
        Console.Write("Please enter radius of circle : ");
        double radius = double.Parse(Console.ReadLine());
        area = pi * radius * radius;
        perimeter = 2 * pi * radius;

        Console.WriteLine("Area of circle is: {0:F2}",area
            );
        Console.WriteLine("Perimeter of circle is: {0:F2}", perimeter);
    }
}
