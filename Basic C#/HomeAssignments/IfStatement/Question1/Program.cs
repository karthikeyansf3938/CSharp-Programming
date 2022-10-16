using System;
namespace Question1;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Test Data");
            double data = double.Parse(Console.ReadLine());

            if(data%2==0)
            {
                Console.WriteLine($"{data} is an even number");
            }
            else
            {
                Console.WriteLine($"{data} is an odd number");
            }
        }
        
    }