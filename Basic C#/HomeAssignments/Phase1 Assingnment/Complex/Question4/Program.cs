using System;
namespace Question4
{
    class Program
    {
           public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string string1=Console.ReadLine();
            var unique = new Hashset<char>(string1);
            System.Console.WriteLine("Output:");
            foreach(char c in unique)
            {
                Console.Write(c);
            }
        }
    }
}