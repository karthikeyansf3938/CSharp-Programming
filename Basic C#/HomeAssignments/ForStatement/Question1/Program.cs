using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int number=int.Parse(Console.ReadLine());

        for(int i=1;i<=10;i++)
        {
            System.Console.WriteLine(""+i);
        }
    }
}
