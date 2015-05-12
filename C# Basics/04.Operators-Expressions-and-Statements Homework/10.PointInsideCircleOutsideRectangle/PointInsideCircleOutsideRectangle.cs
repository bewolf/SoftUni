using System;

    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = ((x-1) *( x - 1)+ (y - 1) * (y - 1) <= 2.25);
            bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2;

            if (x == 0 || y == 0)
            {
                Console.WriteLine("no");
            }
            else if (isInCircle == true && isOutsideRectangle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
