using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company adress: ");
        string companyAdress = Console.ReadLine();

        Console.Write("Enter company phone number: ");
        string phoneNumb = Console.ReadLine();

        Console.Write("Enter fax number: ");
        string faxNumb = Console.ReadLine();

        Console.Write("Enter web site: ");
        string site = Console.ReadLine();

        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter manager last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter manager age: ");
        string age = Console.ReadLine();

        Console.Write("Enter manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.Clear();
        Console.Write(@"
        Company name:       {0}
        Company adress:     {1}
        Phone number:       {2}
        Fax number:         {3}
        Web site:           {4}
        Manager first name: {5}
        Manager last name:  {6}
        Manager age         {7}
        Manager phone:      {8}

        {0}
        Adress: {1}
        Tel. {2}
        Fax {9}
        Web site: {4}
        Manager {5} {6}(age:
        {7}, tel. {8})", companyName,companyAdress,phoneNumb,faxNumb,site,firstName,lastName,age,managerPhone,faxNumb =="" ? "(no fax)": faxNumb);
    }
}
