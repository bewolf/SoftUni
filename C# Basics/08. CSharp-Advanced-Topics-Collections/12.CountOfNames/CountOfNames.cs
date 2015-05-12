using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter names: ");
        string someNames = Console.ReadLine();
        List<string> names = someNames.Split(' ').ToList();
        names.Sort();
        Dictionary<string,int> namesCount = new Dictionary<string,int>();
        int counter = 1;
        for (int i = 1; i < names.Count; i++)
        {
            if (names[i] == names[i-1])
            {
                counter++;
                namesCount.Add(names[i],counter);

            }
            else
            {
                counter = 1;
            }
        }
        foreach (var name in namesCount)
        {
            Console.WriteLine("{0} -> {1}", namesCount.Keys,namesCount.Values);
        }
    }
}