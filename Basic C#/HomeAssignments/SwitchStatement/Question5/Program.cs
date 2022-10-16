using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the country");
        string choice =(Console.ReadLine());

        switch (choice)
        {
            case "india":
            {
                System.Console.WriteLine("1.Gambir\n2.Ashwin\n3.Dhoni\n4.Jadeja");
                break;
            }
            case "pakisthan":
            {
                System.Console.WriteLine("1.Azam\n2.Afridi\n3.Salman\n4.Ali");
                break;
            }
            case "bangaladesh":
            {
                System.Console.WriteLine("1.Hasan\n2.Katapa\n3.Seeraj\n4.Ali");
                break;
            }
        }
    }
}