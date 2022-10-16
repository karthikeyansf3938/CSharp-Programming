using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the string:");
            string string1=Console.ReadLine();
            System.Console.WriteLine("Input the sub string to search:");
            string substring=Console.ReadLine();
            string string3=string1.ToLower();
            string[] string2=string3.Split(" ");
            string string4=substring.ToLower();

            int length=string2.Length;
            for(int i=0;i<length;i++)
            {
                if(string2[i]==string4)
                {
                    Console.WriteLine("The substring exist in the string");
                }
                else
                {
                    Console.WriteLine("The substring not exist in the string");
                    break;
                }
            }
        }
    }
}