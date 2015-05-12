using System;

class NumberAsWords
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int firstNum = num % 10;
        int secondNum = (num / 10) % 10;
        int thirdNum = (num / 100) % 10;

        switch (thirdNum)
        {
            case 0: Console.Write("");
                break;
            case 1: Console.Write("one hundred ");
                break;
            case 2: Console.Write("two hundred ");
                break;
            case 3: Console.Write("three hundred ");
                break;
            case 4: Console.Write("four hundred ");
                break;
            case 5: Console.Write("five hundred ");
                break;
            case 6: Console.Write("six hundred ");
                break;
            case 7: Console.Write("seven hundred ");
                break;
            case 8: Console.Write("eight hundred ");
                break;
            case 9: Console.Write("nine hundred ");
                break;
            default:
                Console.Write("Enter valid number!");
                break;
        }
        if (secondNum == 1)
        {
            switch (firstNum)
            {
                case 0: Console.Write("ten ");
                    break;
                case 1: Console.Write("elenven  ");
                    break;
                case 2: Console.Write("twelve ");
                    break;
                case 3: Console.Write("thirteen ");
                    break;
                case 4: Console.Write("fourteen ");
                    break;
                case 5: Console.Write("fifteen ");
                    break;
                case 6: Console.Write("sixteen ");
                    break;
                case 7: Console.Write("seventeen ");
                    break;
                case 8: Console.Write("eightteen ");
                    break;
                case 9: Console.Write("nineteen ");
                    break;
                default:
                    Console.Write("Enter valid number!");
                    break;
            }
        }
        else if (secondNum !=1)
        {
            switch (secondNum)
            {
                case 0: Console.Write(" ");
                    break;
                case 1: Console.Write("and ten ");
                    break;
                case 2: Console.Write("and twenty ");
                    break;
                case 3: Console.Write("and thirty ");
                    break;
                case 4: Console.Write("and fourty ");
                    break;
                case 5: Console.Write("and fifty ");
                    break;
                case 6: Console.Write("and sixty ");
                    break;
                case 7: Console.Write("and seventy ");
                    break;
                case 8: Console.Write("and eighty ");
                    break;
                case 9: Console.Write("and ninty ");
                    break;
                default:
                    Console.Write("Enter valid number!");
                    break;
            }

            if (secondNum == 0 || thirdNum == 0)
            {
                switch (firstNum)
                {
                    case 0: Console.Write("");
                        break;
                    case 1: Console.Write("and one ");
                        break;
                    case 2: Console.Write("and two ");
                        break;
                    case 3: Console.Write("and three ");
                        break;
                    case 4: Console.Write("and four ");
                        break;
                    case 5: Console.Write("and five ");
                        break;
                    case 6: Console.Write("and six ");
                        break;
                    case 7: Console.Write("and seven ");
                        break;
                    case 8: Console.Write("and eight ");
                        break;
                    case 9: Console.Write("and nine ");
                        break;
                    default:
                        Console.Write("Enter valid number!");
                        break;
                }
            }
            else
            {
                switch (firstNum)
                {
                    case 0: Console.Write("zero");
                        break;
                    case 1: Console.Write("one ");
                        break;
                    case 2: Console.Write("two ");
                        break;
                    case 3: Console.Write("three ");
                        break;
                    case 4: Console.Write("four ");
                        break;
                    case 5: Console.Write("five ");
                        break;
                    case 6: Console.Write("six ");
                        break;
                    case 7: Console.Write("seven ");
                        break;
                    case 8: Console.Write("eight ");
                        break;
                    case 9: Console.Write("nine ");
                        break;
                    default:
                        Console.Write("Enter valid number!");
                        break;
                }

            }
        }
        
    }
}