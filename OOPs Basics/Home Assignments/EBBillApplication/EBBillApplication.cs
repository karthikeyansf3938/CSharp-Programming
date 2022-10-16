using System;
namespace EBBillApplication;
public class CustomerDetails
{
        private static int s_meterId=1000;

        public string MeterID{get;}

        public string Name { get; set; }
        
        public long Phone { get; set; }

        public string MailId { get; set; }
        public double CurrentBill=0;


        public CustomerDetails(string name,long phone,string mail)
        {
            s_meterId++;
            MeterID="EB"+s_meterId;
            Name=name;
            Phone=phone;
            MailId=mail;   
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("\nCustomer Details");
            System.Console.WriteLine("Meter ID:"+MeterID);
            System.Console.WriteLine("Your Name is :"+Name);
            System.Console.WriteLine("Your Phone number is :"+Phone);
            System.Console.WriteLine("Your Mail id is :"+MailId);
            System.Console.WriteLine("Your Currentbill is:"+CurrentBill);
        }
        
        public void CalculateTariff()
        {
            System.Console.WriteLine("Enter the no of units used:");
            double units=double.Parse(Console.ReadLine());

            if(units<100)
            {
                System.Console.WriteLine("Current Bill="+CurrentBill);
            }
            else if(units>=100 && units<200)
            {
                CurrentBill=units*3;
                System.Console.WriteLine("Current Bill="+CurrentBill);
            }
            else if(units>=200 & units<=400)
            {
                CurrentBill=units*5;
                System.Console.WriteLine("Current Bill="+CurrentBill);
            }
            else{
                CurrentBill=units*6;
                System.Console.WriteLine("Current Bill="+CurrentBill);
            }
        }
}