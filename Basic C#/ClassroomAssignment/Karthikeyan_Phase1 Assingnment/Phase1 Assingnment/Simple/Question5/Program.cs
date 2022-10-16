using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Monthly salary:");
            double salary=double.Parse(Console.ReadLine());
            double ha=(salary/100)*10;
            double hra=(salary/100)*10;
            double tax=(salary/100)*5;
            double salary1=salary+hra+ha-tax;
            double Annualincome=salary1*12;
            System.Console.WriteLine("Annual Income:"+Annualincome);
            
        }
    }
}