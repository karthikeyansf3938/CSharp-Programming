using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime[] dates = { DateTime.Now, 
                           new DateTime(2016, 8, 16, 9, 28, 0),
                           new DateTime(2011, 5, 28, 10, 35, 0),
                           new DateTime(1979, 12, 25, 14, 30, 0) };
            foreach(var date in dates)
            {
                Console.WriteLine("Day: {0.d} Time: {1:g}" ,date.Date, date.TimeOfDay);
                Console.WriteLine("Day:{0.d} Time:{0.t}\n",date);
            }

        }
    }
}