using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        GetLastDigitAsWord(number);
    }

    private static void GetLastDigitAsWord(int number)
    {
        switch (number % 10)
        {
            case 0:
                Console.WriteLine("zero");
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;

        }
    }
}
// VARIANT TWO
//
//class LastDigit
//{
//    static string[] lastDigit= { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

//    static void PrintLastDigitAsWord(int num)
//    {
//        int lastDigit = num % 10;
//        Console.WriteLine(number[lastDigit]);
//    }
//    static void Main()
//    {
//        int lastDigit = int.Parse(Console.ReadLine());

//        PrintNumber(lastDigit);
//    }
//}