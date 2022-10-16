using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
            char[] input1=input.ToCharArray();
            System.Console.WriteLine("The characters of the string are : ");
            foreach(char input2 in input)
            {
                System.Console.Write(" "+input2);
            }
        }
    }
}