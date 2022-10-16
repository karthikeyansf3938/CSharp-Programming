using System;
namespace Hierarchical2
{
    public enum Employee2{Default,Temp,Permanent}
    public class PerEmployee:SalaryDetails
    {
        private int s_employee=1000;
        public string EmployeeId{get;}
        public Employee2 Employee2{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        public double PF{get;set;}
        public PerEmployee(double basicSalary,int month,Employee employee1,double da,double hra,double pf):base(basicSalary,month)
        {
            s_employee++;
            EmployeeId="EID"+s_employee;
            DA=da;
            HRA=hra;
            PF=pf;

        }
        public void DisplaySalary()
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