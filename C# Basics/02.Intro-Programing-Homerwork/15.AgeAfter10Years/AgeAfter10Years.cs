    using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter how old are you now:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("After 10 years you will be {0} years old.", age+10);
    }
}

