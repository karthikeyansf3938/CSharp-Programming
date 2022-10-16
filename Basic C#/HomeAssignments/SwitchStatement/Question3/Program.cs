using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Month");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case '1':
            {
                System.Console.WriteLine("Month have 31 days");
                break;
            }
            case '2':
            {
                System.Console.WriteLine("Month have 28 days");
                break;
            }
            case '3':
            {
                System.Console.WriteLine("Month have 31 days");
                break;
            }
            case '4':
            {
                System.Console.WriteLine("Month have 30 days");
                break;
            }
            case '5':
            {
               System.Console.WriteLine("Month have 31 days");
                break;
            }
            case '6':
            {
                System.Console.WriteLine("Month have 30 days");
                break;
            }
            case '7':
            {
                System.Console.WriteLine("Month have 31 days");
                break;
            }
            case '8':
            {
                System.Console.WriteLine("Month have 30 days");
                break;
            }
            case '9':
            {
                System.Console.WriteLine("Month have 31 days");
                break;
            }
            case "10":
            {
               System.Console.WriteLine("Month have 30 days");
                break;
            }
            case "11":
            {
                System.Console.WriteLine("Month have 31 days");
                break;
            }
            case "12":
            {
               System.Console.WriteLine("Month have 30 days");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid ");
                break;
            }


        }
        

        
        

    }
}
