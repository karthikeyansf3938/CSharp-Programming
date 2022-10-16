using System;
namespace Question5;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("A");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("B");
        double b = double.Parse(Console.ReadLine());

        double output = (a*a)+(b*b)+2*a*b;
        Console.WriteLine("Output = "+output);
       


    }
}
