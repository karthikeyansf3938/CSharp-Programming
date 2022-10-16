using System;
namespace Question6;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature:");
            double temperature = double.Parse(Console.ReadLine());
                if(temperature<0)
                {
                    Console.WriteLine("Freezing weather ");
                }
                 else if(temperature<=10)
                {
                    Console.WriteLine("Very Cold weather");
                }
                else if(temperature<=20 && temperature>10)
                {
                    Console.WriteLine("Cold weather");
                }
                 else if(temperature<=30 && temperature>20)
                {
                    Console.WriteLine("Normal in Temperature");
                }
                else if(temperature<=40 && temperature>30)
                {
                    Console.WriteLine("It's Hot");
                }
                else
                {
                    Console.WriteLine("It's Very Hot");
                }
        }
    }
