using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("{0} {1} {0} {2} {0} {3} {0} {4}", i, (char)5, (char)4, (char)3, (char)6);
        }
        for (int j = 1; j <= 4; j++)
        {
            switch (j)
            {
                case 1:
                    Console.WriteLine("{0} {1} {0} {2} {0} {3} {0} {4} ", (char)75, (char)5, (char)4, (char)3, (char)6);
                    break;
                case 2:
                    Console.WriteLine("{0} {1} {0} {2} {0} {3} {0} {4} ", (char)81, (char)5, (char)4, (char)3, (char)6);
                    break;
                case 3:
                    Console.WriteLine("{0} {1} {0} {2} {0} {3} {0} {4} ", (char)74, (char)5, (char)4, (char)3, (char)6);
                    break;
                case 4:
                    Console.WriteLine("{0} {1} {0} {2} {0} {3} {0} {4} ", (char)65, (char)5, (char)4, (char)3, (char)6);
                    break;
                default:
                    break;
            }
        }
    }
}

