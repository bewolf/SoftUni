using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("Enter Your First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Your Middle Name: ");
        string middleName = Console.ReadLine();

        Console.Write("Enter Your Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Your Amount Of Money: ");
        int amountMoney = int.Parse(Console.ReadLine());

        Console.Write("Enter Your Bank Name: ");
        string bankName = Console.ReadLine();

        Console.Write("Enter Your IBAN 1: ");
        string IBAN_1 = Console.ReadLine();

        Console.Write("Enter Your IBAN 2: ");
        string IBAN_2 = Console.ReadLine();

        Console.Write("Enter Your IBAN 3: ");
        string IBAN_3 = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Your First Name is: {0} \nYour Middle Name is: {1}, \nYour Last Name: {2} \nYour Amount Of Money: {3}\nYour Bank Name: {4} \nYour IBAN 1 Is: {5} \nYour IBAN 2 Is: {6}\nYour IBAN 3 Is: {7}", firstName, middleName, lastName, amountMoney, bankName, IBAN_1, IBAN_2, IBAN_3);
    }
}
