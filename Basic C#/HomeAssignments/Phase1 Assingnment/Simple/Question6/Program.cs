using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the password to store:");
            string password=Console.ReadLine();
            System.Console.WriteLine("Enter a password to login ");
            string password1=Console.ReadLine();
            if(password==password1)
            {
                System.Console.WriteLine("Welcome");
            }
            else
            {
                System.Console.WriteLine("Wrong Password!");
            }

        }
    }
}
