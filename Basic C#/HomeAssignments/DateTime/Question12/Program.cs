using System;
using System.Globalization;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the month number:");
            int month=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Input the year:");
            int year=Convert.ToInt32(Console.ReadLine());
            DateTimeFormatInfo info=new DateTimeFormatInfo();
            string month1=info.GetMonthName(month);
            int nodays=DateTime.DaysInMonth(year,month);
            Console.WriteLine("The number of days in the month {0} is : {1}",month1,nodays);
            
        }
    }
}