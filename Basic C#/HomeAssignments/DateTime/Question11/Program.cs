using System;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime now=DateTime.Now;
            System.Console.WriteLine("Display the name of the month of the year:");
            System.Console.WriteLine("The date of Today is {0}",now.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("The twelve months are: ");
            for(int i=0;i<12;i++)
            {
                System.Console.WriteLine("{0}",now.ToString("MMMM"));
                now=now.AddMonths(1);
            }System.Console.WriteLine();
        }
    }
}