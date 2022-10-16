using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime date=DateTime.Now;
            DateTime answer=date.AddDays(40);
            System.Console.WriteLine("Today : {0:d}",date);
            System.Console.WriteLine("{0:dddd}",answer);
        }
    }
}