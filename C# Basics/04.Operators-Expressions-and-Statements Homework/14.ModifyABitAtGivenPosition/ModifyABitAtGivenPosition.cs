﻿using System;

class ModifyABitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter index P: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value v: ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));

        if (v == 1)
        {
            int setOne = 1 << p;
            int foundBitOne = n | setOne;
            Console.WriteLine(Convert.ToString(foundBitOne, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: " + foundBitOne);
        }
        else
        {
            int setZero = ~(1 << p);
            int foundBitZero = n & setZero;
            Console.WriteLine(Convert.ToString(foundBitZero, 2).PadLeft(16, '0'));
            Console.WriteLine("Result: " + foundBitZero);
        }

    }
}