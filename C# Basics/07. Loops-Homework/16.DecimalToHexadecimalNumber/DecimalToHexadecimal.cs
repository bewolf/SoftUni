using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string number = "";
        while (n >= 1)
        {
            number = (n % 2) + number;
            n = n / 2;
        }
        long result = Convert.ToInt64(number, 2);
        result = Convert.ToInt32(result.ToString("X"));
        Console.WriteLine("The hexadecimal number is: {0}", result);
    }
}
//the program didn't work correct!