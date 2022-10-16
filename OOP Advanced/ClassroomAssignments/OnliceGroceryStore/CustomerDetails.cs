using System;
namespace OnlineGroceryStore
{
    public  class CustomerDetails : PersonalDetails,IBalance
    {
        private static int s_customerId=1000;
        public string CustomerId{get; set;}
        public double WalletBalance{get; set;}
        public CustomerDetails(string name,string fatherName,Gender gender,long phone,DateTime dateofBirth,string mail )
        {
            s_customerId++;
            CustomerId = "CID" + s_customerId;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Phone=phone;
            DateofBirth=dateofBirth;
            MailId=mail;
        }
        public CustomerDetails(string data )
        {
            string[] value = data.Split(',');
            s_customerId = int.Parse(value[0].Remove(0,3));
            CustomerId = value[0];
            Name = value[1];
            FatherName= value[2];
            Gender = Enum.Parse<Gender>(value[3]);
            Phone=long.Parse(value[4]);
            DateofBirth=DateTime.Parse(value[5]);
            MailId=value[6];
        }
        public void ShowDetails()
        {
            System.Console.WriteLine($"\n{CustomerId}\t\t{Name}\t\t{FatherName}\t\t{Gender}\t\t{Phone}\t\t{DateofBirth.ToShortDateString()}");
        }
        public  void WalletRecharge()
        {
            Console.WriteLine($"Enter the amount to add the wallet");
            double recharge=double.Parse(Console.ReadLine());
            WalletBalance +=recharge;
            System.Console.WriteLine("Your Balance is :"+WalletBalance);
        }
    }
}