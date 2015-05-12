using System;
using System.Linq;

class SortArrayOfNumbsSelectionSort
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] arrNumbers = numbers.Split().Select(int.Parse).ToArray();
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            int min = arrNumbers[i];
            for (int j = i + 1; j < arrNumbers.Length; j++)
            {
                if (arrNumbers[j] < min)
                {
                    min = arrNumbers[j];
                    arrNumbers[j] = arrNumbers[i];
                    arrNumbers[i] = min;
                }
            }
        }
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Console.Write("{0} ", arrNumbers[i]);
        }
    }
}
//http://visualgo.net/sorting.html - using this method