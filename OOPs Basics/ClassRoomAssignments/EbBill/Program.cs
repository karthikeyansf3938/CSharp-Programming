using System;
using System.Collections.Generic;
namespace EbBill
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<CustomerDetails> CustomerList=new List<CustomerDetails>();
            string anothercustomer=" ";
            do
            {
                System.Console.WriteLine("Do you want to create another account for another customer(yes/no)");
                anothercustomer=Console.ReadLine().ToLower();
                System.Console.WriteLine("Enter your name:");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your Phone number:");
                long Phone=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your Mail id:");
                string mail=Console.ReadLine();
                System.Console.WriteLine("Your current bill is:");
                double currentbill=0;

                CustomerDetails customer=new CustomerDetails(name,Phone,mail,currentbill);
                CustomerList.Add(customer);
                System.Console.WriteLine("Created");
                System.Console.WriteLine("Do you want to create another account for another customer(yes/no)");
                anothercustomer=Console.ReadLine().ToLower();
            }while(anothercustomer=="yes");

            foreach(CustomerDetails customers in CustomerList)
            {
                System.Console.WriteLine("\nCustomer Details");
                System.Console.WriteLine("Meter ID:"+customers.MeterID);
                System.Console.WriteLine("Your Name is :"+customers.Name);
                System.Console.WriteLine("Your Phone number is :"+customers.Phone);
                System.Console.WriteLine("Your Mail id is :"+customers.MailId);
                System.Console.WriteLine("Your Currentbill is:"+customers.CurrentBill);
                customers.CalculateBill();
            }
        }
    }
}