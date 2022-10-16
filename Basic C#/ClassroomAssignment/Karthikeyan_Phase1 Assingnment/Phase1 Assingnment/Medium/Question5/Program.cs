using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the value of N :");
            int year2=int.Parse(Console.ReadLine());
            for(int i=1;i<=year2;i++)
            {if(DateTime.IsLeapYear(i))
                {
                    Console.WriteLine("{0} is Leap year.",i);  
                }
            }
        }
    }
}
