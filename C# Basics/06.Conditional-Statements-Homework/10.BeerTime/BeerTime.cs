using System;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Enter time in format hh:mm tt ");
        string beerTime = Console.ReadLine();
        DateTime dateTime;
        if (DateTime.TryParse(beerTime, out dateTime))
        {
            if (dateTime.Hour >= 0 && dateTime.Hour <= 13)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non beer time");
            }
        }
    }
}