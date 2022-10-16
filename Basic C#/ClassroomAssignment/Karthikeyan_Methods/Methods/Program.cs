using System;
namespace Methods;
class Program
{
    public static void Main(string[] args)
    {
        string condition="";
        do
        {
        
        condition=Console.ReadLine();
        System.Console.WriteLine("Enter the number1");
        int number1=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the number2");
        int number2=int.Parse(Console.ReadLine());

       
        System.Console.WriteLine("Choose the options:\n1.Addition \n2.Substraction \n3.Multiplication \n4.Division");
        System.Console.WriteLine("Enter the choice:");
        char choice=Convert.ToChar(Console.ReadLine());

        switch(choice)
        {
            case '1':
            {
                System.Console.WriteLine($"Addition of {+number1} and {+number2} is {Addition(number1,number2)}");
                break;
            }
            case '2':
            {
                System.Console.WriteLine($"Substraction of {+number1} and {+number2} is {Substraction(number1,number2)}");
                break;
            }
            case '3':
            {
                
                
                System.Console.WriteLine($"Multiplication of {+number1} and {+number2} is {Multiplication(number1,number2)}");
                break;
            }
            case '4':
            {
                System.Console.WriteLine($"Addition of {+number1} and {+number2} is {Division(number1,number2)}");
                break;
            }
        }
        System.Console.WriteLine("Do you want to continue again.press yes/no");
        condition=Console.ReadLine().ToLower();
        }while(condition=="yes");

         int Addition(int value1,int value2)
        {
            int sum = value1+value2;
            return sum;
        }
        int Substraction(int value1,int value2)
        {
            int minus = value1-value2;
            return minus;
        }
        int Multiplication(int value1, int value2)
        {
            int multiply = value1*value2;
            return multiply;
        }
        int Division(int value1,int value2)
        {
            int quotient=value1/value2;
            return quotient;
        }
        
    }
}