using System;
using System.Globalization;
namespace EmployeeLibrary
{
    public enum WorkLocation{Default,Madura,Eymard};
    public enum Gender{Default,Male,Female,Transgender};
    public class EmployeeDetails
    {
        private static int s_employeeid=1000;

        public string EmployeeId{get; set;}
        public string EmployeeName{get; set;}

        public string EmployeeRole{get; set;}

        public WorkLocation WorkLocation{get; set;}

        public string TeamName{get; set;}

        public Gender Gender{get; set;}

        public DateTime DateofJoing{get; set;}

        public double Salary=0;

        public EmployeeDetails(String employeename,string employeerole,WorkLocation workLocation,String teamname,Gender gender,DateTime dateofjoining)
        {
            s_employeeid++;
            EmployeeId="SF"+s_employeeid;
            EmployeeName=employeename;
            EmployeeRole=employeerole;
            WorkLocation=workLocation;
            TeamName=teamname;
            Gender=gender;
        }
        public void Calculatesalary()
        {
            System.Console.WriteLine("Enter the Month:");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the year:");
            int year=int.Parse(Console.ReadLine());
            int nodays=DateTime.DaysInMonth(year,month);
            System.Console.WriteLine("Number of leaves taken in month:");
            int leave=int.Parse(Console.ReadLine());
            Salary=(nodays-leave)*500;
            System.Console.WriteLine("Your Salary is:"+Salary);
        }


    }
}