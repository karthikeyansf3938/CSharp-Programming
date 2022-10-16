using System;
namespace OnlineFoodDelivery
{
    public class CustomerDetails:PersonalInfo,IWalletBalance
    {
        private static int s_customerId=1000;
        public string CustomerId{get;}
        public double WalletBalance{get; set;}
        
         public CustomerDetails(string name,string fatherName,Gender gender,long phone,string mail,string location,double walletBalance)
         {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            WalletBalance=walletBalance;
         }
          public CustomerDetails(string data)
         {
            string[] value = data.Split(',');
            s_customerId=int.Parse(value[0].Remove(0,3));
            CustomerId=value[0];
            Name=value[1];
            FatherName=value[2];
            Gender = Enum.Parse<Gender>(value[3]);
            Phone = long.Parse(value[4]);
            Mail = value[5];
            Location = value[6];
            WalletBalance=double.Parse(value[7]);
            
         }
    }
}