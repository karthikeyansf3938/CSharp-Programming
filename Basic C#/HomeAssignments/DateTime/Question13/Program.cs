using System;
namespace Question13
{
    class Program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Input the day:");
           int day=Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine("Input the month:");
           int month=Convert.ToInt32(Console.ReadLine());
           System.Console.WriteLine("Input the year:");
           int year=int.Parse(Console.ReadLine());
           
           DateTime day1=new DateTime(year,month,day);
           System.Console.WriteLine("The formatted Date is : {0}",day1.ToString("dd/MM/yyyy"));
           System.Console.WriteLine("The first day of the week for the above date is: {0}",LastDayofWeek(day1).ToString("dd/MM/yyyy"));
        }
           public static DateTime LastDayofWeek(DateTime day)
           {
                var culture=System.Threading.Thread.CurrentThread.CurrentCulture;
                var diff=day.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
                if(diff<0)
                    diff+=7;
                return day.AddDays(-diff).Date;
           }
        }
    
}