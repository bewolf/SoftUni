using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] arrNumbers = numbers.Split().Select(int.Parse).ToArray();
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Console.WriteLine(isLargerThanNeighbours(arrNumbers,i));
        }

    }

     static bool isLargerThanNeighbours(int[] arrNumbers, int i)
    {
        bool isItLarger = false;

        if (i == 0)
        {
            isItLarger = arrNumbers[i + 1] < arrNumbers[i];
        }
        else if (i > 0 && i < arrNumbers.Length - 1)
        {
            isItLarger = arrNumbers[i - 1] < arrNumbers[i] && arrNumbers[i + 1] < arrNumbers[i];
        }
        else
        {
            isItLarger = arrNumbers[i - 1] < arrNumbers[i];
        }

        return isItLarger;
    }
}