using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(x * x + y * y <= 4 ? true : false);
        //use formula (x - center_x_of_circle)^2 + (y - center_y_of_circle)^2 <= radius^2.
        //В случая имаме център на кръга с точки х=0 и y=0 и затова съм ползвал съкратен вариант на формулата
    }
}
