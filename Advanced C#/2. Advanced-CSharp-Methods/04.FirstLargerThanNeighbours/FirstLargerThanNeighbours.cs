using System;
using System.Threading;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));


    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] sequence)
    {
        int position = new int();
        for (int i = 1; i < sequence.Length - 1; i++)
        {
            if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1])
            {
                position = i;
                break;
            }
            else
            {
                position = -1;
            }
        }

        return position;
    }
}