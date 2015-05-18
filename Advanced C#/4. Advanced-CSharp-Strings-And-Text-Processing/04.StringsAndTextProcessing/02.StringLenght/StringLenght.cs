using System;

class StringLenght
{
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(TrimOrNotString(input));    
        
    }

    private static string TrimOrNotString(string input)
    {
        if (input.Length > 20)
        {
            input = input.Substring(0,20);
        }
        else if (input.Length < 20)
        {
            for (int i = 0; i <20- input.Length; i++)
            {
                input += '*';
            }
        }
        return input;
    }
}