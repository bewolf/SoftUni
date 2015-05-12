using System;
using System.Collections.Generic;
using System.Linq;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate = new DateTime();
        DateTime secondDate = new DateTime();

        Console.WriteLine("Enter first date: ");
        string firstDateTime = Console.ReadLine();

        Console.WriteLine("Enter second date: ");
        string secondDateTime = Console.ReadLine();

        firstDate = Convert.ToDateTime(firstDateTime);
        secondDate = Convert.ToDateTime(secondDateTime);
        TimeSpan resultDate = secondDate - firstDate;

        Console.WriteLine(resultDate.Days);

    }
}