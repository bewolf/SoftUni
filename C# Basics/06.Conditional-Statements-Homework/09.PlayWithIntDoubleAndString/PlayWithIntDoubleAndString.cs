using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Plese choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int numb = int.Parse(Console.ReadLine());
            switch (numb)
            {
                case 1: Console.WriteLine("Please enter a int: ");
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(1 + intNum);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double: ");
                    double doubNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(1 + doubNum);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string: ");
                    string newStr = Console.ReadLine();
                    Console.WriteLine("{0}*", newStr);
                    break;
                default:
                    Console.WriteLine("Enter between 1 and 3");
                    break;
            }
        }
    }