using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter card sign: (write with capital case) ");
        string cardSign = Console.ReadLine();
        switch (cardSign)
        {
            case "A":
            case "Q":
            case "K":
            case "J":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
                Console.WriteLine("yes");
                break;
            default:
                Console.WriteLine("no");
                break;
        }
    }
}
