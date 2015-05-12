using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        Console.Write(@"Enter ""t"" for leap year or ""f"" for not leap year: ");
        string t = Console.ReadLine();

        Console.Write("Enter number of holidays: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter weekend in hometown: ");
        int h = int.Parse(Console.ReadLine());

        double playTimes = (52-h)*2/3 + h + (p/2);

        if (t == "t")
        {
            Console.WriteLine((int)playTimes + 3);
        }
        else
        {
            Console.WriteLine((int)playTimes);
        }
    }
}
