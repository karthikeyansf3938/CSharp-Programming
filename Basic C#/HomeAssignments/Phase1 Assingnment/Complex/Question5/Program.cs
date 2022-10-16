using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a String:");
            string input=Console.ReadLine();
            string reverse=Console.ReadLine();
            for(int i=input.Length-1;i>=0;i--)
            {
                reverse+=input[i].ToString();
            }
            if(input==reverse)
            {
                System.Console.WriteLine($"{input} is a Palindrome");
            }
            else
            {
                System.Console.WriteLine($"{input} is a not palindrome");
            }
            
            
        }
    }
}