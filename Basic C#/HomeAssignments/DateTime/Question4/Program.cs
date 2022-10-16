using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a date");
            string date1=new String(Console.ReadLine());
            DateTime date=Convert.ToDateTime(date1);
            System.Console.WriteLine("The day of the week for {0:d} is {1}",date, date.DayOfWeek);

        }
    }
}