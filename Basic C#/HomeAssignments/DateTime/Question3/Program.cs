using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input a string");
            string datetime =new String(Console.ReadLine());
            DateTime dateTime1=Convert.ToDateTime(datetime);

            System.Console.WriteLine("Year:"+dateTime1.Year);
            System.Console.WriteLine("Month:"+dateTime1.Month);
            System.Console.WriteLine("Day:"+dateTime1.Day);
            System.Console.WriteLine("Hours:"+dateTime1.Hour);
            System.Console.WriteLine("Minutes:"+dateTime1.Minute);
            System.Console.WriteLine("Seconds:"+dateTime1.Second);
            System.Console.WriteLine("Millesecond:"+dateTime1.Millisecond);
        }
    }
}