using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a Celsius:");
            double celsius=double.Parse(Console.ReadLine());
            
            double fahernheit=celsius*(9/5)+32;
            System.Console.WriteLine("Fahernheit : "+fahernheit);
        }
    }
}