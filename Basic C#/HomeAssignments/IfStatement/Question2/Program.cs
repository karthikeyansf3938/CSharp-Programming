using System;
namespace Question2;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Age");
            double age = double.Parse(Console.ReadLine());

            if(age>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You're not eligible for voting.");
            }
        }
        
    }