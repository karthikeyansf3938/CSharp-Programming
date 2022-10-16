using System;
namespace Hierarchical2
{ 
    public enum Employee{Default,Temp,Permanent}
    public class TempEmployee:SalaryDetails
    {
        private int s_employee=1000;
        public string EmployeeId{get;}
        public Employee Employee1{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        public double PF{get;set;}
        public TempEmployee(double basicSalary,int month,Employee employee1,double da,double hra,double pf):base(basicSalary,month)
        {
            s_employee++;
            EmployeeId="EID"+s_employee;
            DA=da;
            HRA=hra;
            PF=pf;

        }
        public void DisplaySalary1()
        {
            ShowSalary();
            double totalSalary=BasicSalary*31;
            DA=BasicSalary*DA;
            HRA=BasicSalary*HRA;
            double totalSalary1=totalSalary-BasicSalary+DA+HRA;
            System.Console.WriteLine("Total Salary :"+totalSalary1);


        }


    }
}