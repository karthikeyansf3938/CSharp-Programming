using System;
namespace EbBill
{
    
    public class CustomerDetails
    {
        private static int s_meterId=1000;

        public string MeterID{get;}

        public string Name { get; set; }
        
        public long Phone { get; set; }

        public string MailId { get; set; }
        public double CurrentBill=0;


        public CustomerDetails(string name,long phone,string mail,double currentbill)
        {
            s_meterId++;
            MeterID="EB"+s_meterId;
            Name=name;
            Phone=phone;
            MailId=mail;
            CurrentBill=currentbill;
            
        }
        public void CalculateBill()
        {
            System.Console.WriteLine("Units used:");
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
}