using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a date");
            string date1=new string(Console.ReadLine());
            DateTime date=Convert.ToDateTime(date1);
            for(int i=0;i<=20;i++)
            {
                DateTime dateToDisplay=date.AddYears(i);
                Console.WriteLine("{0:d} : day {1} of {2} {3}",dateToDisplay,dateToDisplay.DayOfYear,dateToDisplay.Year,DateTime.IsLeapYear(dateToDisplay.Year)?" (Leap Year)" : " ");
                
            }

        }
    }
}