using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a month to salary receipt of month");
            string month=Console.ReadLine();
            System.Console.WriteLine("Enter the leave taken on that month");
            double leave=double.Parse(Console.ReadLine());
            double salary;
            if(month== "january" || month=="march" || month=="may" || month=="july" || month=="august" ||month=="october"||month=="december")
            {
                salary=(31-leave)*500;
                System.Console.WriteLine("Month salary:"+salary);
            }
            else if(month== "april" || month=="june" || month=="september" || month=="november" )
            {
                salary=(30-leave)*500;
                System.Console.WriteLine("Month salary:"+salary);
            }
            else{
                salary=(28-leave)*500;
            }
        }
    }
}