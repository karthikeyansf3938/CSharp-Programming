using System;
namespace Question10;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the password:");
            string password = Console.ReadLine();
            string HiTeam = Console.ReadLine();
                if(HiTeam == password)
                {
                    Console.WriteLine("Right password ");
                }
                 else
                {
                    Console.WriteLine("Wrong Password");
                }
        }
    }
