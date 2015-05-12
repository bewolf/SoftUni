using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine()); //rows
        int c = int.Parse(Console.ReadLine()); //columns
        string[,] matrix = new string[r, c];
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                matrix[row, col] =
                    "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
            }
        }
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

    }
}