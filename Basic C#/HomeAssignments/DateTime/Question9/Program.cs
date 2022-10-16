using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a year1");
            int year1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a year2");
            int year2=int.Parse(Console.ReadLine());
            for(int i=year1;i<=year2;i++)
            {
                if(DateTime.IsLeapYear(i))
                {
                    Console.WriteLine("{0} is Leap year.",i);
                    DateTime leapDay=new DateTime(i, 2, 29);
                    DateTime nextyear=leapDay.AddYears(1);
                    Console.WriteLine(" One year from {0} is {1}.",leapDay.ToString("d"),nextyear.ToString("d"));
                }
            }
        }
    }
}