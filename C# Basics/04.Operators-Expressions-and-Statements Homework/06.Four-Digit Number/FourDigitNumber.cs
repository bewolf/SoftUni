using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter Four Digit Number: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = 0;
        for (int n = number; n > 0; sumOfDigits += n % 10, n /= 10) ;
        Console.WriteLine("The sum of all digits is: {0}", sumOfDigits);

        int reverse = 0;
        while (number > 0)
        {
            int rem = number % 10;
            reverse = (reverse * 10) + rem;
            number = number / 10;

        }
        Console.WriteLine("Reversed number is = {0}", reverse);


    }
}
