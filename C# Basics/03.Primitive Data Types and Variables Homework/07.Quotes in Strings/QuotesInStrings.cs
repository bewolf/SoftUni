using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstVariable = @"The ""use"" of quotations causes difficulties.";
        string secondVariable = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstVariable);
        Console.WriteLine(secondVariable);
    }
}
