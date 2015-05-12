using System;

class Volleyball
{
    static void Main()
    {
        int weekends = 48;
        string leap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        if (leap == "leap") //+15%
        {
            int leapPlayTimes = ((h * (2/3))+ p+ ((weekends - p) * (3/4))) ;
            Console.WriteLine(leapPlayTimes);
        }
        else if (leap == "normal")
        {
            int normalPlayTimes = (h * (2 / 3)) + p + ((weekends - p) * (3 / 4));
            Console.WriteLine(normalPlayTimes);
        }


    }
}