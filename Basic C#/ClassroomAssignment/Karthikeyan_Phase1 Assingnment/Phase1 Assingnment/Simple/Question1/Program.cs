using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Inches:");
            double inches=double.Parse(Console.ReadLine());
            double inch=2.54;
            double centimeters=inches*inch;
            System.Console.WriteLine($"Centimeter:{+centimeters} CM");
        }
    }
}