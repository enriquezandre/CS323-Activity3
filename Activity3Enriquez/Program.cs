// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

bool cont;
int choice, toConvert;

do
{
    do
    {
        Console.WriteLine("Choose the number system of the number you want to convert:");
        Console.WriteLine("[1] Binary");
        Console.WriteLine("[2] Decimal");
        Console.WriteLine("[3] Octal");
        Console.WriteLine("[4] Hexadecimal");

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice > 4)
        {
            Console.WriteLine("Invalid choice. Try again.\n");
        }
    } while (choice > 4);


    do {
    Console.WriteLine("Choose the number system to be converted into");
    Console.WriteLine("[1] Binary");
    Console.WriteLine("[2] Decimal");
    Console.WriteLine("[3] Octal");
    Console.WriteLine("[4] Hexadecimal");

    toConvert = Convert.ToInt32(Console.ReadLine());

        if (toConvert > 4)
        {
            Console.WriteLine("Invalid choice. Try again.\n");
        }
    } while (toConvert > 4);

switch (choice)
    {
        case 1: //ALL BINARY CONVERSIONS
            Console.WriteLine("Enter BINARY to convert: ");
            var value1 = Console.ReadLine();
            if(!Regex.IsMatch(value1, "^[01]+$"))
            {
                Console.WriteLine("Invalid BINARY number");
            }
            else
            {
                switch (toConvert)
                {
                    case 1: //BINARY TO BINARY
                        Console.WriteLine(value1);
                        break;
                    case 2: //BINARY TO DECIMAL
                        Console.WriteLine(Convert.ToInt32(value1, 2).ToString());
                        break;
                    case 3: //BINARY TO OCTAL
                        Console.WriteLine(Convert.ToInt32(value1, 8).ToString());
                        break;
                    case 4: //BINARY TO HEXADECIMAL
                        Console.WriteLine(Convert.ToInt32(value1, 16).ToString());
                        break;
                    default:
                        break;
                }
            }
            break;

        case 2: //ALL DECIMAL CONVERSIONS
            int value2 = 0;
            Console.WriteLine("Enter DECIMAL to convert: ");
            try
            {
                value2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid DECIMAL number");
            }

            switch (toConvert)
            {
                case 1: //DECIMAL TO BINARY
                    Console.WriteLine(Convert.ToString(value2, 2));
                    break;
                case 2: //DECIMAL TO DECIMAL
                    Console.WriteLine(Convert.ToString(value2, 10));
                    break;
                case 3: //DECIMAL TO OCTAL
                    Console.WriteLine(Convert.ToString(value2, 8));
                    break;
                case 4: //DECIMAL TO HEXADECIMAL
                    Console.WriteLine(Convert.ToString(value2, 16));
                    break;
                default:
                    Console.WriteLine("Invalid inputted value");
                    break;
            }
            break;

        case 3: //ALL OCTAL CONVERSIONS
            Console.WriteLine("Enter OCTAL to convert: ");
            var value3 = Console.ReadLine();
            if(!Regex.IsMatch(value3, "^[0-7]+$"))
            {
                Console.WriteLine("Invalid OCTAL number");
            }
            else
            {
                switch (toConvert)
                {
                    case 1: //OCTAL TO BINARY
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value3, 8), 2));
                        break;
                    case 2: //OCTAL TO DECIMAL
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value3, 8), 10));
                        break;
                    case 3: //OCTAL TO OCTAL
                        Console.WriteLine(value3);
                        break;
                    case 4: //OCTAL TO HEXADECIMAL
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value3, 8), 16));
                        break;
                    default:
                        Console.WriteLine("Invalid inputted value");
                        break;
                }
            }
            break;

        case 4: //ALL HEXADECIMAL CONVERSIONS
            Console.WriteLine("Enter HEXADECIMAL to convert: ");
            var value4 = Console.ReadLine();
            if (!Regex.IsMatch(value4, "^[a-fA-F0-9]+$"))
            {
                Console.WriteLine("Invalid HEXADECIMAL number");
            }
            else
            {
                switch (toConvert)
                {
                    case 1: //HEXADECIMAL TO BINARY
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value4, 16), 2));
                        break;
                    case 2: //HEXADECIMAL TO DECIMAL
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value4, 16), 10));
                        break;
                    case 3: //HEXADECIMAL TO OCTAL
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value4, 16), 8));
                        break;
                    case 4: //HEXADECIMAL TO HEXADECIMAL
                        Console.WriteLine(Convert.ToString(Convert.ToInt64(value4, 16), 16));
                        break;
                    default:
                        Console.WriteLine("Invalid inputted value");
                        break;
                }
            }
            break;
        default: return;
    }

    Console.WriteLine("Do you want to convert again?");
    Console.WriteLine("[Any number] Yes");
    Console.WriteLine("[0] No");

    int again = Convert.ToInt32(Console.ReadLine());

    if (again == 0)
    {
        cont = false;
    }
    else
    {
        cont = true;
    }

} while (cont);




