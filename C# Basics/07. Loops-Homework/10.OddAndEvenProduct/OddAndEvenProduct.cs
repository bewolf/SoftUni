using System;

public class OddAndEvenProduct
{
    public static void Main()
    {
    Beginning:
        Console.WriteLine("Enter some integer numbers separated by a single interval: ");
        string[] tryNumbers = Console.ReadLine().Split(' ');

        int n = tryNumbers.Length;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            bool validNumber = int.TryParse(tryNumbers[i], out numbers[i]);

            if (validNumber == false)
            {
                Console.WriteLine();
                Console.WriteLine("Wrong input! Enter your numbers again: ");
                Console.WriteLine();
                goto Beginning;
            }
        }

        int odd_product = 1;
        int even_product = 1;

        for (int odd = 0; odd < n; odd += 2)
        {
            odd_product *= numbers[odd];
        }

        for (int even = 1; even < n; even += 2)
        {
            even_product *= numbers[even];
        }

        Console.WriteLine();

        if (odd_product == even_product)
        {
            Console.WriteLine("yes");
            Console.WriteLine("poduct = {0}", even_product);
        }

        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", odd_product);
            Console.WriteLine("even_product = {0}", even_product);
        }
    }
}