using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount of Celsius:");
        double celsius = double.Parse(Console.ReadLine());

        double kelvin = celsius + 273;
        double fahernheit = (celsius*9/5) + 32;

        Console.WriteLine("Kelvin : "+kelvin);
        Console.WriteLine("Fahernheit : "+fahernheit);
        
    }
}