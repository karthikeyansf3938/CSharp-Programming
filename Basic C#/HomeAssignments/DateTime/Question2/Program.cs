using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {   
            System.Console.WriteLine("Enter the date");
            string date=new string(Console.ReadLine());

            DateTime date1=Convert.ToDateTime(date);
            
            Console.WriteLine("Complete Date:"+date.ToString());

            DateTime dateonly=date1.Date;
            Console.WriteLine("Short date:"+dateonly.ToString("d"));

            System.Console.WriteLine(date1.ToString("d"));
            System.Console.WriteLine(date1.ToString("D"));
            System.Console.WriteLine(date1.ToString("g"));
            System.Console.WriteLine(date1.ToString("d"));
            System.Console.WriteLine(date1.ToString("t"));   
        }
    }
}