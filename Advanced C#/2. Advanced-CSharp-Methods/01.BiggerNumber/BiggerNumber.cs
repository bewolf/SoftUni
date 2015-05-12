using System;

class BiggerNumber
{
    private static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

     static int GetMax(int firstNumber, int secondNumber)
     {
         int maxNumb = Math.Max(firstNumber, secondNumber);
         return maxNumb;
     }
}
