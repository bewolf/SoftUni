using System;
class BitwiseExtractBitc3
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        uint n = uint.Parse(Console.ReadLine());
        uint numRightN = n >> 3;
        uint bit = numRightN & 1;
        Console.WriteLine(bit);
    }
}
