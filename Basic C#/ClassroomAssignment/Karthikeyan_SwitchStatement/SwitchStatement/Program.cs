using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Value A");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Value B");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the character");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case '+':
            {
                System.Console.WriteLine($"Addtion = {a+b}");
                break;
            }
            case '-':
            {
                System.Console.WriteLine($"Substraction = {a-b}");
                break;
            }
            case '*':
            {
                System.Console.WriteLine($"Multiplication = {a*b}");
                break;
            }
            case '/':
            {
                System.Console.WriteLine($"Divison = {a/b}");
                break;
            }
            case '%':
            {
                System.Console.WriteLine($"Percentage = {a%b}");
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