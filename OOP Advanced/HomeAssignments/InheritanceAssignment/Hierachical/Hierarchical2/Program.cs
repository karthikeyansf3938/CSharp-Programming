using System;
namespace Hierarchical2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("-------Temporary Employee Salary--------");
        TempEmployee employee1=new TempEmployee(100,2,Employee.Temp,0.15,0.13,0.2);
        employee1.DisplaySalary1();
        System.Console.WriteLine("-------Permanent Employee Salary--------");
        PerEmployee employee2=new PerEmployee(120,2,Employee.Permanent,0.2,0.18,2);
        employee2.DisplaySalary();
        
    }
}