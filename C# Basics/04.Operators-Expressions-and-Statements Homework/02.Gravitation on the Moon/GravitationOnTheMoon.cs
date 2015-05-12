using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Enter weight on Earth: ");
            double weight = double.Parse(Console.ReadLine());
            double weightOnMoon = (17.0/100) * weight ;
            Console.WriteLine("Your weight on Earth is {0}, on Moon is {1}",weight, weightOnMoon);
        }
    }
