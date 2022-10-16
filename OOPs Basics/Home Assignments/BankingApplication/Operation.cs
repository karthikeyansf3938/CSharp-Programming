using System;
using System.Collections.Generic;
namespace BankingApplication;

    public static class Operation
    {
        static List<CustomerDetails> customerList=new List<CustomerDetails>();
        static CustomerDetails currentStudent = null;
        static string anothercustomer=" ";
        private static CustomerDetails CurrentCustomer;

        public static void MainMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Option \n1.Registration \n2.Login \n3.Exit");
                int Option = int.Parse(Console.ReadLine());

                switch (Option)
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
                            choice = "no";
                            break;
                        }
                }
            } while (choice == "yes");
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter your name:");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your father name:");
                string fathername=Console.ReadLine();
                System.Console.WriteLine("Enter your gender:");
                string gender=Console.ReadLine();
                System.Console.WriteLine("Enter your date of birth:");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                System.Console.WriteLine("Enter your account type:");
                AccountType accounttype=Enum.Parse<AccountType>(Console.ReadLine(),true);
                System.Console.WriteLine("Your balance is:");
                double balance=0;

                CustomerDetails customer=new CustomerDetails(name,fathername,dob,gender,accounttype,balance);
                customerList.Add(customer);
                System.Console.WriteLine("Created");
                System.Console.WriteLine("Your account number is:"+customer.AccountNumber);
        }
        public static void Login()
        {
            Console.WriteLine("Enter your AccountNumber Number ");
            string accountnumber = Console.ReadLine().ToUpper();
            foreach (CustomerDetails customer in customerList)
            {
                if (customer.AccountNumber == accountnumber)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    CurrentCustomer = customer;
                    SubMenu();
                }
            }
        }
         public static void SubMenu()
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("Select Submenu option:");
                System.Console.WriteLine("/n1.Show Details /n2.Deposit /n3.Withdraw /4Show Balance /n5..Exit Submenu");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            System.Console.WriteLine("Show Details");
                            CurrentCustomer.ShowDetails();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("Deposit");
                            CurrentCustomer.Deposit();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Withdraw");
                            CurrentCustomer.Withdraw();
                            break;
                        }
                        case 4:
                        {
                            System.Console.WriteLine("Show Balance");
                            CurrentCustomer.BalanceShow();
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("Exit Submenu");
                            choice = "no";
                            break;
                        }
                }
            } while (choice == "yes");
        }
        

    }
