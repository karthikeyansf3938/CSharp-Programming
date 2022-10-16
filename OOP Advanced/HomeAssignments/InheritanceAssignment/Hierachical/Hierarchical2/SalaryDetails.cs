using System;
namespace Hierarchical2
{
    public class SalaryDetails
    {
        public double BasicSalary{get;set;}
        public int Month{get;set;}

        public SalaryDetails(double basicSalary,int month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }
        public SalaryDetails(string data,double basicSalary,int month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }
        public void ShowSalary()
        {
            System.Console.WriteLine("Basic Salary : "+BasicSalary);
            System.Console.WriteLine("Month : "+Month);
        }
    }
}