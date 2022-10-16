using System;
using System.Collections.Generic;
using EmployeeLibrary;
namespace EmployeePayrollApplication;

    class Operation
    {
        public static void MainMenu()
        {
            List<EmployeeDetails> EmployeeList=new List<EmployeeDetails>();
            string anotheremployee=" ";
            do{
                System.Console.WriteLine("Do you want to create another account for another customer(yes/no)");
                anotheremployee=Console.ReadLine().ToLower();
                System.Console.WriteLine("Enter your Employee Name:");
                string employeename=Console.ReadLine();
                System.Console.WriteLine("Enter your employee role:");
                string employeerole=Console.ReadLine();
                System.Console.WriteLine("Enter your work location:");
                WorkLocation worklocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
                System.Console.WriteLine("Enter your team name:");
                string teamname=Console.ReadLine();
                System.Console.WriteLine("Enter your Gender:");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
                System.Console.WriteLine("Enter your date of joining:");
                DateTime dateofjoing=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                
                EmployeeDetails employee=new (employeename,employeerole,worklocation,teamname,gender,dateofjoing);
                EmployeeList.Add(employee);
                System.Console.WriteLine("Salary calculated");
                System.Console.WriteLine("Do you want to create another Employee Payroll for another employee payroll(yes/no)");
                anotheremployee=Console.ReadLine().ToLower();
            }while(anotheremployee=="yes");

            foreach(EmployeeDetails employees in EmployeeList)
            {
                System.Console.WriteLine("\nEmployee Details");
                System.Console.WriteLine("Employee ID:"+employees.EmployeeId);
                System.Console.WriteLine("Your Name is :"+employees.EmployeeName);
                System.Console.WriteLine("Your Role is :"+employees.EmployeeRole);
                System.Console.WriteLine("Your Work location is :"+employees.WorkLocation);
                System.Console.WriteLine("Your Team name is :"+employees.TeamName);
                System.Console.WriteLine("Your Gender is:"+employees.Gender);
                System.Console.WriteLine("Your Date of joining is:"+employees.DateofJoing);
                System.Console.WriteLine("Your Salary is:"+employees.Salary);

                employees.Calculatesalary();
            }
        
        }
    }
        