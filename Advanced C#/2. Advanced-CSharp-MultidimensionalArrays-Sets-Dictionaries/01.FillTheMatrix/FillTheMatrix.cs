using System;
using System.Runtime.InteropServices;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        PaternA(n, matrix);
        Console.WriteLine();
        PaternB(n, matrix);
    }

    private static void PaternA(int n, int[,] matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < n; column++)
            {
                matrix[row, column] = row + 1 + column * 4;
                Console.Write("{0,4}", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
    private static void PaternB(int n, int[,] matrix)
    {
        for (int row = n-1; row >=0; row--)
        {
            for (int column = 0; column < n; column++)
            {
                if (column% 2==0)
                {
                    matrix[row, column] = column*4 - row;
                }
                else
                {
                    //not enought time
                }
                Console.Write("{0,4}", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}