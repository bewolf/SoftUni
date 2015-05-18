using System;
using System.Text;


class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(StringReverse(input));
    }

    private static StringBuilder StringReverse(string input)
    {
      var reversedString = new StringBuilder();
        for (int i = input.Length-1; i >=0; i--)
        {
            reversedString.Append(input[i]).ToString();

        }
        return reversedString;
    }
}