using System;
namespace Question9;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Speed");
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine("Time");
            double time = double.Parse(Console.ReadLine());

            double distance = speed*time*5/18;
            Console.WriteLine($"{distance} Meters ");
        }
    
    }
