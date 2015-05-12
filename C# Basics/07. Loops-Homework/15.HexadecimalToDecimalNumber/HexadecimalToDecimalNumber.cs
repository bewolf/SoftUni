using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string stringNumber = Console.ReadLine();
        foreach (char numb in stringNumber)
        {
            Console.WriteLine(numb);
        }
        for (int i = 0; i < stringNumber.Length; i++)
        {
            Console.WriteLine(stringNumber[i]);
        }
        Console.WriteLine(stringNumber);
    }
}