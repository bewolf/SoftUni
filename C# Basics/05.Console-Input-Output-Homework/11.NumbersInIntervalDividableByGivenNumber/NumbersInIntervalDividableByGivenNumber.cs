using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int startNum = int.Parse(Console.ReadLine());
        Console.Write("Enter end number: ");
        int endNum = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = startNum; i <= endNum; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ",i);
                counter = counter + 1;
            }
        }
        Console.WriteLine(counter);

    }
}