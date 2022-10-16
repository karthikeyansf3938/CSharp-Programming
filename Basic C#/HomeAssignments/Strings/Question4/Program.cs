using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
           
            string[] input1=input.Split(" ");
            int count=0,length=input1.Length;
            for(int i=0;i<length;i++)
            {
                count++;
            }
            System.Console.WriteLine("Total number of words in String:"+count);
        }
    }
}