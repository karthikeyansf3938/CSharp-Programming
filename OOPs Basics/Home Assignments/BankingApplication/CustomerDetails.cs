using System;
namespace BankingApplication;

    public enum AccountType{Default,SB,FD,RD}

    public enum Gender{Default,Male,Female,Transgender}
    
    public class CustomerDetails
    {
        private static int s_accountnumber=1000;

        public string AccountNumber{get;}

        public string Name { get; set; }
        
        public string FatherName { get; set; }

        public DateTime DOB { get; set; }

        public string Gender { get; set; }

        public AccountType  AccountType { get; set; }

        public double Balance=0;


        public CustomerDetails(string name,string fatherName,DateTime dob,string gender,AccountType accounttype,double balance)
        {
            s_accountnumber++;
            AccountNumber="HDFC"+s_accountnumber;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Gender=gender;
            AccountType=accounttype;
            Balance=balance;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("\nCustomer Details");
            System.Console.WriteLine("Account Number:"+AccountNumber);
            System.Console.WriteLine("Your Name is :"+Name);
            System.Console.WriteLine("Your Father name is :"+FatherName);
            System.Console.WriteLine("Your Date of birth is :"+DOB);
            System.Console.WriteLine("Your Gender is :"+Gender);
            System.Console.WriteLine("Your Account type is:"+AccountType);
            System.Console.WriteLine("Your Account balance is:"+Balance);
        }
    
        public void Deposit()
        {
            System.Console.WriteLine("Enter the Deposit amount:");
            double deposit=double.Parse(Console.ReadLine());
            Balance+=deposit;
        }
        public void Withdraw()
         {
            System.Console.WriteLine("Enter the amount to withdraw:");
            double withdraw=double.Parse(Console.ReadLine());
            Balance-=withdraw;
        }
        public void BalanceShow()
        {
            Deposit();
            Withdraw();
            System.Console.WriteLine(Balance);
        } 
    }
    
