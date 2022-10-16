using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number ");
            int number=int.Parse(Console.ReadLine());
            Factorial(number);
            int i=1;
            int Factorial(int value)
            {   int fact=1;
                for(i=1;i<=value;i++)
                {
                    fact=fact*i;
                } 
                Console.Write("The Factorial of "+value+" is:"+fact);
                return fact;
            }
        }
    }
}