using System;
namespace HierachicalInheritance
{
    
    public class CustomerDetails : PersonalDetails//inheritance
    {
        private static int s_cid=100;
        public string CustomerId{get;}

        public double WalletBalance{get; set;}

        public CustomerDetails(string aadharId,string name,string fatherName,Gender gender,long phone):base(aadharId,name,fatherName,gender,phone)
        {
            s_cid++;
            CustomerId="CID"+s_cid;
            

        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter a amount to recharge : ");
            WalletBalance+=double.Parse(Console.ReadLine());
        }
        public void ShowCustomerDetails()
        {
            System.Console.WriteLine("Customer Id : "+CustomerId);
            ShowDetails();
            System.Console.WriteLine("Balance : "+WalletBalance);
        }
    }
}