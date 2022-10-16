using System;
using System.Collections.Generic;
namespace EmployeePayroll
{
    public static class Operation
    {
        static List<EmployeeDetails> EmployeeList = new List<EmployeeDetails>();
        static EmployeeDetails CurrentEmployee=null;
        
        public static void MainMenu()
        {
            string choice="yes";
            do
            {
            System.Console.WriteLine("Select Option \n1.Registration \n2.Login \n3.Exit");
            int Option=int.Parse(Console.ReadLine());
            
                switch(Option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("Exit");
                        choice="no";
                        break;
                    }
            }
            }while(choice=="yes");
        }
        
        public static void Registration()

        {
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
            
            EmployeeDetails employee= new EmployeeDetails(employeename,employeerole,worklocation,teamname,gender,dateofjoing);
            EmployeeList.Add(employee);
            System.Console.WriteLine("Submitted");
            System.Console.WriteLine("Your Employee Id is: "+employee.EmployeeId);
        }
        public static void Login()
        {
            System.Console.WriteLine("Enter your Register Number ");
            string employeeid=Console.ReadLine().ToUpper();
            foreach(EmployeeDetails student in EmployeeList)
            {
                if(student.EmployeeId==employeeid)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    CurrentEmployee=student;
                    SubMenu();
                }
            }
        }
        public static void SubMenu()
        {
           string choice="yes";
           do
           {
            System.Console.WriteLine("Select Submenu option:");
            System.Console.WriteLine("/n1.Show Details /2.Get NO of Leaves /3.Calculate Salary/4.Exit Submenu");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    CurrentEmployee.ShowDetails();
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Get No of leaves");
                    GetLeaves();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Calculate salary");
                    CurrentEmployee.CalculateSalary();
                    break;
                }

                case 4:
                {
                    System.Console.WriteLine("Exit Submenu");
                    choice="no";
                    break;
                }
            }
           }while(choice=="yes");
           }
           public static void GetLeaves()
           {
                System.Console.WriteLine("Enter your No of Leaves");
                int leaves=int.Parse(Console.ReadLine());
           }
    }
}