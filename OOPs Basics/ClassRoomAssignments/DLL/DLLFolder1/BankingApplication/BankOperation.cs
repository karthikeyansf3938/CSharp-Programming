using System;
using System.Collections.Generic;
using BankLibrary;
namespace BankApplication
{
    public class BankOperation
    {
        public static void MainMenu()
        {
            List<CustomerDetails> CustomerList=new List<CustomerDetails>();
            string anothercustomer=" ";
            do
            {
                System.Console.WriteLine("Do you want to create another account for another customer(yes/no)");
                anothercustomer=Console.ReadLine().ToLower();
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
                CustomerList.Add(customer);
                System.Console.WriteLine("Created");
                System.Console.WriteLine("Do you want to create another account for another customer(yes/no)");
                anothercustomer=Console.ReadLine().ToLower();
            }while(anothercustomer=="yes");

            foreach(CustomerDetails customers in CustomerList)
            {
                System.Console.WriteLine("\nCustomer Details");
                System.Console.WriteLine("Account Number:"+customers.AccountNumber);
                System.Console.WriteLine("Your Name is :"+customers.Name);
                System.Console.WriteLine("Your Father name is :"+customers.FatherName);
                System.Console.WriteLine("Your Date of birth is :"+customers.DOB);
                System.Console.WriteLine("Your Gender is :"+customers.Gender);
                System.Console.WriteLine("Your Account type is:"+customers.AccountType);
                System.Console.WriteLine("Your Account balance is:"+customers.Balance);
                customers.Deposit();
                customers.Withdraw();
                customers.BalanceShow();
            }
        }
    }
}