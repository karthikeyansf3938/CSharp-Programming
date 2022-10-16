using System;
namespace Question13
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(("Enter the number:"));
            double number=double.Parse(Console.ReadLine());
            for(int i=1;i<=20;i++)
            {
                double multiplication=number*i;
                System.Console.WriteLine($"{+number} * {+i} = {+multiplication}");
            }
        }
    }
}