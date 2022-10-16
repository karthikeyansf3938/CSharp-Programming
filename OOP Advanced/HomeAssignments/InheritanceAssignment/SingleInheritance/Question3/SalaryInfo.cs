using System;
namespace Question3
{
    public class SalaryInfo : Attendance
    {
        public string SalaryOfMonth{get; set;}
        public string Month{get; set;}

         public void CalculateSalary()
    {
        System.Console.WriteLine("Enter the Month:");
        int month=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the year:");
        int year=int.Parse(Console.ReadLine());
        int nodays=DateTime.DaysInMonth(year,month);
        System.Console.WriteLine("Number of leaves taken in month:");
        int leave=int.Parse(Console.ReadLine());
        double Salary=(nodays-leave)*500;
    }
    public void DisplaySalary()
    {
        System.Console.WriteLine("Your Salary is ");
    }
    }
   
}
