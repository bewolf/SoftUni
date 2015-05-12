using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Old a = {0} \nOld b = {1}", a, b);
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("New a = {0} \nNew b = {1}", a, b);
    }
}
