using System;
using System.Text.RegularExpressions;

class ReplaceLinkTag
{
    static void Main()
    {
        string input = @"
                <ul>
                 <li>
                  <a href=http://softuni.bg>SoftUni</a>
                 </li>
                </ul>";
        string patern = @"<a\s+href=([^>]+)>([^<]+)<\/a";
        string replaceTag = "[URL href=$1]$2[/URL]";
        string output = Regex.Replace(input, patern, replaceTag);
        Console.WriteLine(output);
    }
}