using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the number:");
        double input=double.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++)
        {
            System.Console.WriteLine(input +" * " + i + " = " +input*i);
        }
    }
}