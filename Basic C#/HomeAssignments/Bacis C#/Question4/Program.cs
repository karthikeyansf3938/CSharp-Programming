using System;
namespace Questio3;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input radius:");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Height:");
        double height = double.Parse(Console.ReadLine());

        double volume = 3.14 * (radius*radius)*height;
        Console.WriteLine("Volume : "+volume);
    }
}