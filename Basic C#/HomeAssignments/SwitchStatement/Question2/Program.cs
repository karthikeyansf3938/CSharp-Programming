using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the character");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case '1':
            {
                System.Console.WriteLine("Monday");
                break;
            }
            case '2':
            {
                System.Console.WriteLine("Tuesday");
                break;
            }
            case '3':
            {
                System.Console.WriteLine("Wednesday");
                break;
            }
            case '4':
            {
                System.Console.WriteLine("Thursday");
                break;
            }
            case '5':
            {
                System.Console.WriteLine("Friday");
                break;
            }
            case '6':
            {
                System.Console.WriteLine("Saturday");
                break;
            }
            case '7':
            {
                System.Console.WriteLine("Sunday");
                break;
            }
            default:
            {
                System.Console.WriteLine("Operation invalid");
                break;
            }


        }
        

        
        

    }
}
