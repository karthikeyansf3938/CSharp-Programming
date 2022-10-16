using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input a username to store the data:");
            string string1=Console.ReadLine();
            System.Console.WriteLine("Input a password to store the data");
            string string2=Console.ReadLine();
            System.Console.WriteLine("Enter a username:");
            string string3=Console.ReadLine();
            System.Console.WriteLine("Enter a password:");
            string string4=Console.ReadLine();
            if(string1==string3 && string2==string4)
            {
                System.Console.WriteLine("Password entered successfully");
            }
            else
            {
                System.Console.WriteLine("Password is incorrect");
            }

        }
    }
}