using System;
using System.Collections.Generic;
namespace EBBillApplication
{
    public class Operation
    {
        static List<CustomerDetails> CustomerList = new List<CustomerDetails>();
        static CustomerDetails CurrentCustomer=null;
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
                System.Console.WriteLine("Enter your name:");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your Phone number:");
                long Phone=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Mail id:");
                string mail=Console.ReadLine();
                

                CustomerDetails customer=new CustomerDetails(name,Phone,mail);
                CustomerList.Add(customer);
                System.Console.WriteLine("Created");
                System.Console.WriteLine("Your Meter Id is"+customer.MeterID);
            }
            public static void Login()
        {
            System.Console.WriteLine("Enter your Meter Id ");
            string meterid=Console.ReadLine().ToUpper();
            foreach(CustomerDetails customer in CustomerList)
            {
                if(customer.MeterID==meterid)
                {
                    System.Console.WriteLine("Login Sucessfull");
                    CurrentCustomer=customer;
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
            System.Console.WriteLine("/n1.Show Details /n2.No of Units /n3.Calculate tariff/n4.Exit Submenu");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Show Details");
                    CurrentCustomer.ShowDetails();
                    break;
                }
                case 2:
                {
                    NoOfUnits();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Calculate Tariff");
                    CurrentCustomer.CalculateTariff();
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
           public static void NoOfUnits()
           {
            System.Console.WriteLine("No of units");
            double units=double.Parse(Console.ReadLine());
           }

    }
}