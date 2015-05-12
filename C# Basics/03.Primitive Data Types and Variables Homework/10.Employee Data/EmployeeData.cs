using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Ener Your Firs Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Your Last Name ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Your Age (from 0 to 100) ");
        byte age = byte.Parse(Console.ReadLine());   
   
        Console.Write("Enter Your Gender (m/f) ");
        string gender = Console.ReadLine();

        Console.Write("Enter Your Personal ID (e.g. 8306112507): ");
        long personalID = long.Parse(Console.ReadLine());

        Console.Write("Enter Your Unique Employee Number: (from 27560000 to 27569999)");
        int employeeNumber = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Your First Name is: {0} \nYour Last Name is {1} \nYour Age is {2} \nYour Gender Is {3} \nYour Personal ID is: {4} \nYour Unique Employee Number is: {5} \nYour Unique Employee Number is: {6}" , firstName, lastName, age, gender, personalID, personalID, employeeNumber);
    }
}
