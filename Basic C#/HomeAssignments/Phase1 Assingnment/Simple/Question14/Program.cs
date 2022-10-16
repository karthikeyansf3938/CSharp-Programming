using System;
namespace Question14
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a value:");
            int value=int.Parse(Console.ReadLine());
            for(int i=1;i<=value;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    for(int k=0;k<=j;k++)
                    {
                        System.Console.Write(i);
                    }
                }Console.WriteLine();
            }Console.WriteLine();
        }
    }
}