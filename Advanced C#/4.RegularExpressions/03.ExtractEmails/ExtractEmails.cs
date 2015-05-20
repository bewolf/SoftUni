using System;
using System.Net.Configuration;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        string mailPatern = @"\b([A-Za-z0-9]+?)[\w\-\.]*?[A-Za-z0-9]+?@[A-Za-z0-9]+?([\w\-\.]+)\2*?\.[\w]{2,}\b";
        Regex regex = new Regex(mailPatern);
        MatchCollection mails = regex.Matches(input);
        foreach (var mail in mails)
        {
            Console.WriteLine("{0}",mail);
        }
    }
}