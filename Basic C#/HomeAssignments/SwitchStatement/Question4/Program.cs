using System;
namespace SwitchStatement;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Value1");
        int option1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Value2");
        int option2= int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the character");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case '1':
            {
                System.Console.WriteLine($"The Addition of {+option1} and {+option2} is {option1+option2}");
                break;
            }
            case '2':
            {
                System.Console.WriteLine($"The Substraction of {+option1} and {+option2} is {option1-option2}");
                break;
            }
            case '3':
            {
                System.Console.WriteLine($"The Multiplication of {+option1} and {+option2} is {option1 *option2}");
                break;
            }
            case '4':
            {
                System.Console.WriteLine($"The Division of {option1} and {option2} is {option1/option2}");
                break;
            }
            case '5':
            {
                System.Console.WriteLine("Exit");
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
